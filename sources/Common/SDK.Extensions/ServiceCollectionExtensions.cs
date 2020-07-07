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

#if netstandard21 || netcoreapp31
using Grpc.Net.Client;
#endif

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
                        ClientNames.ApiClient,
                        client => client.BaseAddress = apiEndpointUrl
                    );

            return services;
        }

        private static IServiceCollection AddRestClient(
            this IServiceCollection services
        )
        {
            _ = services.AddSingleton<IRestClient<ICustomerDTO, CustomerDTO>>(sp =>
            {
                var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                return new RestClient<ICustomerDTO, CustomerDTO>(
                    httpClientFactory.CreateClient(ClientNames.ApiClient)
                );
            });
            return services;
        }

        public static IOperationClientBuilder AddGraphQLClient(
            this IServiceCollection services
        )
        {
            _ = services.AddSingleton<IOperationExecutorFactory>(sp =>
                    new HttpOperationExecutorFactory(
                        ClientNames.ApiClient,
                        sp.GetRequiredService<IHttpClientFactory>().CreateClient,
                        sp.GetRequiredService<IClientOptions>().GetOperationPipeline<IHttpOperationContext>(ClientNames.ApiClient),
                        sp.GetRequiredService<IClientOptions>().GetOperationFormatter(ClientNames.ApiClient),
                        sp.GetRequiredService<IClientOptions>().GetResultParsers(ClientNames.ApiClient)
                    )
                );

            var builder = services
                            .AddOperationClientOptions(ClientNames.ApiClient)
                            .AddResultParser(serializers => new GetCustomersResultParser(serializers))
                            .AddOperationFormatter(serializers => new JsonOperationFormatter(serializers))
                            .AddHttpOperationPipeline(b => b.UseHttpDefaultPipeline());

            services.TryAddSingleton<IOperationExecutorPool, OperationExecutorPool>();

            _ = services.AddSingleton<IGraphQLClient>(sp
                => new GraphQLClient(
                    sp.GetRequiredService<IOperationExecutorPool>()
                )
            );

            return builder;
        }

        [SuppressMessage("Redundancy", "RCS1163:Unused parameter.", Justification = "<Pending>")]
        internal static IServiceCollection AddGrpcClients(
            this IServiceCollection services
        )
        {
            IHttpClientFactory factory;
            HttpClient client;
            Uri apiEndpointUrl;
            using (var sp = services.BuildServiceProvider())
            {
                factory = sp.GetRequiredService<IHttpClientFactory>();
                client = factory.CreateClient(ClientNames.ApiClient);
                apiEndpointUrl = client.BaseAddress;
            }
#if netstandard21 || netcoreapp31
            _ = services
                    .AddGrpcClient<GrpcService.GrpcServiceClient>(
                        ClientNames.ApiClient,
                        opt => opt.Address = apiEndpointUrl
                    );
            var channel = GrpcChannel
                            .ForAddress(
                                apiEndpointUrl,
                                new GrpcChannelOptions
                                {
                                    HttpClient = client,
                                    DisposeHttpClient = true
                                }
                            );
            _ = services.AddSingleton<GrpcClient<CustomerMessage>, CustomerGrpcClient>(_
                    => new CustomerGrpcClient(channel)
                );
#endif
            return services;
        }

        public static IServiceCollection AddSharpFactoryApiClients(
            this IServiceCollection services,
            string apiEndpoint
        )
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrEmpty(apiEndpoint))
                throw new ArgumentNullException(nameof(apiEndpoint));

            if (!Uri.TryCreate(apiEndpoint, UriKind.Absolute, out var apiEndpointUrl)
             || apiEndpointUrl == null
            )
            {
                throw new InvalidOperationException($"Invalid url passed: {apiEndpoint}");
            }

            _ = services.AddHttpClient(apiEndpointUrl);
            _ = services.AddRestClient();
            _ = services.AddGraphQLClient();
            _ = services.AddGrpcClients();

            _ = services
                .AddSingleton<ApiClient<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers>, CustomerClient>();

            return services;
        }
    }
}
