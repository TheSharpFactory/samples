using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TheSharpFactory.Apps.Shared.Services;
using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

namespace TheSharpFactory.Apps.Web.BlazorClient
{
    public static class Program
    {
        [SuppressMessage("Design", "RCS1090:Call 'ConfigureAwait(false)'.", Justification = "<Pending>")]
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await SharedUI.Program.RunWebAssembly<App>(builder, "app");
        }
    }
}
