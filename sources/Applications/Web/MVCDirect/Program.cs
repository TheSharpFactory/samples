
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.MVCDirect
{
    public static class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            SharedUI.StartupBase.AppModel = new MvcApplicationModel
            {
                CommunicationWay = MvcCommunicationWay.Direct
            };
            return Host
                        .CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder
                          => webBuilder.UseStartup<Startup>()
                        );
        }
    }
}
