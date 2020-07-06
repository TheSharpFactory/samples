using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK.Clients;
using TheSharpFactory.SDK.Graph;
using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.SDK
{
    public static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddHttpClient(
            this IServiceCollection services,
            Uri apiEndpointUrl
        )
        {
            _ = services
                    .AddHttpClient(
                        ClientNames.RestClient,
                        c => c.BaseAddress = apiEndpointUrl
                    );
            _ = services.AddSingleton<IRestClient<ICustomerDTO, CustomerDTO>>(sp =>
            {
                var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                return new RestClient<ICustomerDTO, CustomerDTO>(
                    httpClientFactory.CreateClient(ClientNames.RestClient)
                );
            });

            return services;
        }

        public static IOperationClientBuilder AddGraphQLClient(
            this IServiceCollection serviceCollection
        )
        {
            if (serviceCollection is null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            serviceCollection.AddSingleton<IGraphQLClient, GraphQLClient>();

            serviceCollection.AddSingleton<IOperationExecutorFactory>(sp =>
                new HttpOperationExecutorFactory(
                    ClientNames.GraphClient,
                    sp.GetRequiredService<IHttpClientFactory>().CreateClient,
                    sp.GetRequiredService<IClientOptions>().GetOperationPipeline<IHttpOperationContext>(ClientNames.GraphClient),
                    sp.GetRequiredService<IClientOptions>().GetOperationFormatter(ClientNames.GraphClient),
                    sp.GetRequiredService<IClientOptions>().GetResultParsers(ClientNames.GraphClient)
                )
            );

            var builder = serviceCollection
                            .AddOperationClientOptions(ClientNames.GraphClient)
                            .AddResultParser(serializers => new GetCustomersResultParser(serializers))
                            .AddOperationFormatter(serializers => new JsonOperationFormatter(serializers))
                            .AddHttpOperationPipeline(b => b.UseHttpDefaultPipeline());

            serviceCollection.TryAddSingleton<IOperationExecutorPool, OperationExecutorPool>();
            return builder;
        }

        [SuppressMessage("Redundancy", "RCS1163:Unused parameter.", Justification = "<Pending>")]
        internal static IServiceCollection AddGrpcClients(
            this IServiceCollection services,
            Uri apiEndpointUrl
        )
        {
#if netstandard21 || netcoreapp31
            _ = services
                    .AddGrpcClient<GrpcService.GrpcServiceClient>(
                        ClientNames.SalesGrpcClient,
                        opt => opt.Address = apiEndpointUrl
                    );
#endif
            _ = services.AddSingleton<GrpcClient<CustomerMessage>, CustomerGrpcClient>();

            return services;
        }

        public static IServiceCollection AddSharpFactoryApiClients(
            this IServiceCollection services,
            string apiEndpoint
        )
        {
            if (string.IsNullOrEmpty(apiEndpoint))
                throw new ArgumentNullException(nameof(apiEndpoint));
         
            if (!Uri.TryCreate(apiEndpoint, UriKind.Absolute, out var apiEndpointUrl)
             || apiEndpointUrl == null
            )
            {
                throw new InvalidOperationException($"Invalid url passed: {apiEndpoint}");
            }

            _ = services.AddHttpClient(apiEndpointUrl);
            _ = services.AddGraphQLClient();
            _ = services.AddGrpcClients(apiEndpointUrl);

            _ = services
                .AddSingleton<ApiClient<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers>, CustomerClient>();

            return services;
        }
    }
}
