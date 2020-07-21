
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TheSharpFactory.Apps.Web.BlazorServerDirect
{
    public static class Program
    {
        public static void Main(string[] args)
        //=> CreateHostBuilder(args).Build().Run();
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);
            SharedUI
                .Program
                .BuildBlazorHost<Startup>(hostBuilder, args: args)
                .Run();

        }
    }
}
