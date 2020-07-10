using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Builder;

#if netcoreapp31
using Grpc.Net.Client;
#endif

namespace TheSharpFactory.SDK
{
#if netcoreapp31
    public static class AppicationBuilderExtensions
    {
        [SuppressMessage("Style", "RCS1001:Add braces (when expression spans over multiple lines).", Justification = "<Pending>")]
        public static IApplicationBuilder UseSharpFactoryGrpc(
            this IApplicationBuilder app,
            GrpcWebOptions? grpcWebOptions = null
        )
        {
            if (grpcWebOptions is null)
                grpcWebOptions = new GrpcWebOptions
                {
                    DefaultEnabled = true
                };
            return app.UseGrpcWeb(grpcWebOptions);
        }
    }
#endif
}
