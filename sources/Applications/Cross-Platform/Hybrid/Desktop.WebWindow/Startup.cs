
using WebWindows.Blazor;

namespace TheSharpFactory.Apps.Cross.Desktop.WebView
{
    public class Startup
        : Web.SharedUI.StartupBase
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(DesktopApplicationBuilder app)
            => ConfigureWebWindow<Web.BlazorClient.App>(app, "app");
    }
}
