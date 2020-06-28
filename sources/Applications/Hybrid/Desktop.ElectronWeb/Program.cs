
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TheSharpFactory.Apps.Hybrid.Desktop.ElectronWeb
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);

            Web
                .SharedUI
                .Program
                .BuildBlazorHost<Startup>(builder, true, args)
                .Run();
        }
    }
}
