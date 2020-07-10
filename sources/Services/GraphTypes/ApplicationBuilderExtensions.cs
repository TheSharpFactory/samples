
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;

using Microsoft.AspNetCore.Builder;

namespace TheSharpFactory.Services.GraphTypes
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSharpFactoryGraph(
            this IApplicationBuilder app
        )
        {
            const string graphEndpoint = "/graph";
            var playgroundEndpoint = $"/{graphEndpoint}/playground";
            var graphiqlEndpoint = $"/{graphEndpoint}/graphiql";
            var voyagerEndpoint = $"/{graphEndpoint}/voyager";
            app.UseGraphQL(graphEndpoint);
            app.UsePlayground(graphEndpoint, playgroundEndpoint);
            app.UseGraphiQL(graphEndpoint, graphiqlEndpoint);
            app.UseVoyager(graphEndpoint, voyagerEndpoint);
            return app;
        }
    }
}
