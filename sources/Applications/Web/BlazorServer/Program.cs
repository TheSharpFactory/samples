
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TheSharpFactory.Apps.Web.BlazorServer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);

            SharedUI
                .Program
                .BuildBlazorHost<Startup>(builder, false, args)
                .Run();
        }
    }
}
