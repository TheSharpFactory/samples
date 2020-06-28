
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.MVC
{
    public static class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder
                    => webBuilder.UseStartup<Startup>()
                );
    }
}
