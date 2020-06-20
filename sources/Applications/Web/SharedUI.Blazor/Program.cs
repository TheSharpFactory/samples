using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

#if netcoreapp31
using ElectronNET.API;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
#endif

namespace TheSharpFactory.Apps.Web.SharedUI
{
    public static class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "RCS1090:Call 'ConfigureAwait(false)'.", Justification = "<Pending>")]
        public static async Task RunWebAssembly<TApplication>(WebAssemblyHostBuilder builder, string selector)
            where TApplication : ComponentBase, new()
        {
            if (string.IsNullOrEmpty(selector))
                throw new ArgumentNullException(nameof(selector));
            builder.RootComponents.Add<TApplication>(selector);

            var services = builder.Services;

            StartupBase.AppModel = new BlazorApplicationModel()
            {
                Flavor = BlazorFlavor.WebAssembly,
                Platform = BlazorPlatform.Web
            };

            var startup = new StartupBase();
            startup.ConfigureServices(services);

            await builder.Build().RunAsync();
        }
#if netcoreapp31
        public static IHost BuildBlazorHost(IHostBuilder builder, bool isElectron = false, string[] args = null)
        {
            var appModel = new BlazorApplicationModel
            {
                Flavor = BlazorFlavor.Server,
                Platform = BlazorPlatform.Web
            };

            if (isElectron)
            {
                appModel.Flavor = BlazorFlavor.Hybrid;
                appModel.Platform = BlazorPlatform.Electron;
            }
            StartupBase.AppModel = appModel;
            return builder
                    .ConfigureWebHostDefaults(b =>
                    {
                        if (isElectron)
                            b.UseElectron(args);
                        b.UseStartup<StartupBase>();
                    }
                    )
                    .Build();
        }
#endif
    }
}
