using System;
using System.Collections.Generic;
using System.Text;

#if netstandard21 || netcoreapp31
using Grpc.Net.Client;
#endif

using Microsoft.AspNetCore.Builder;

namespace TheSharpFactory.SDK
{
#if netcoreapp31
    public static class AppicationBuilderExtensions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "RCS1001:Add braces (when expression spans over multiple lines).", Justification = "<Pending>")]
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
