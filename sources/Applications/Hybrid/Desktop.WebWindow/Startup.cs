
using TheSharpFactory.Apps.Web.BlazorClient;
using TheSharpFactory.Apps.Web.SharedUI;

using WebWindows.Blazor;

namespace TheSharpFactory.Apps.Hybrid.Desktop.WebWindow
{
    public class Startup
        : StartupBase
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(DesktopApplicationBuilder app)
            => ConfigureWebWindow<App>(app, "app");
    }
}
