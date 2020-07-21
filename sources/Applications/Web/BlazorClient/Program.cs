using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace TheSharpFactory.Apps.Web.BlazorClient
{
    public static class Program
    {
        [SuppressMessage("Design", "RCS1090:Call 'ConfigureAwait(false)'.", Justification = "<Pending>")]
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var startup = new Startup();

            await SharedUI
                    .Program
                    .RunWebAssembly<App, Startup>(
                        builder,
                        "app",
                        startup
                    );
        }
    }
}
