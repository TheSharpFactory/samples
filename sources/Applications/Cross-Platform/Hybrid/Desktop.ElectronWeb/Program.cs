
using ElectronNET.API;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using TheSharpFactory.Apps.Web.SharedUI;

using StartupBase = TheSharpFactory.Apps.Web.SharedUI.StartupBase;

namespace TheSharpFactory.Apps.Cross.Desktop.ElectronWeb
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            StartupBase.AppModel = new BlazorApplicationModel
            {
                Flavor = BlazorFlavor.WebAssembly | BlazorFlavor.Hybrid,
                Platform = BlazorPlatform.Web | BlazorPlatform.Electron
            };

            CreateHostBuilder(args).Build().Run();
            //var builder = Host.CreateDefaultBuilder(args);

            //Web
            //    .SharedUI
            //    .Program
            //    .BuildBlazorHost(builder, true, args)
            //    .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseElectron(args);
                    webBuilder.UseStartup<Startup>();
                }
                );
    }
}
