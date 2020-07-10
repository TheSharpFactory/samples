using HotChocolate;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Services.GraphTypes.Sales;

namespace TheSharpFactory.Services.GraphTypes
{
    public static class ServiceCollectionExtensions
    {        public static IServiceCollection AddSharpFactoryGraph(
            this IServiceCollection services
        ) {
            _ = services.AddGraphQL(sp
                => SchemaBuilder
                        .New()
                        .AddQueryType<QueryType>()
                        .AddType<CustomerType>()
                        .AddServices(sp)
                        .Create()
            );
            return services;
        }
    }
}
