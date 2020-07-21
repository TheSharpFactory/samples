using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Diagnostics.CodeAnalysis;

#if netcoreapp31
using ElectronNET.API;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
#endif

namespace TheSharpFactory.Apps.Web.SharedUI
{
    public static class Program
    {
        [SuppressMessage("Design", "RCS1090:Call 'ConfigureAwait(false)'.", Justification = "<Pending>")]
        public static async Task RunWebAssembly<TApplication, TStartup>(
            WebAssemblyHostBuilder builder,
            string selector,
            TStartup startup
        )
            where TApplication : ComponentBase, new()
            where TStartup : StartupBase, new()
        {
            if (string.IsNullOrEmpty(selector))
                throw new ArgumentNullException(nameof(selector));
            builder.RootComponents.Add<TApplication>(selector);

            var services = builder.Services;
            startup.ConfigureServices(services);

            await builder.Build().RunAsync();
        }
#if netcoreapp31
        public static IHost BuildBlazorHost<TStartup>(
            IHostBuilder builder,
            bool isElectron = false,
            params string[] args
        )
            where TStartup : StartupBase
        => builder
                .ConfigureWebHostDefaults(b =>
                {
                    if (isElectron)
                        b.UseElectron(args);
                    b.UseStartup<TStartup>();
                }
                )
                .Build();
#endif
    }
}
