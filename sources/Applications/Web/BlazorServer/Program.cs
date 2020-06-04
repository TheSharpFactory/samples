
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.BlazorServer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            SharedUI.StartupBase.AppModel = new BlazorApplicationModel
            {
                Flavor = BlazorFlavor.Server,
                Platform = BlazorPlatform.Web
            };

            CreateHostBuilder(args).Build().Run();

            //var builder = Host.CreateDefaultBuilder(args);

            //SharedUI
            //    .Program
            //    .BuildBlazorHost(builder)
            //    .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder
                    => webBuilder.UseStartup<Startup>()
                );
    }
}
