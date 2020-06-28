
using TheSharpFactory.Apps.Web.BlazorClient;
using TheSharpFactory.Apps.Web.SharedUI;

using WebWindows.Blazor;

namespace TheSharpFactory.Apps.Hybrid.Desktop.WebWindow
{
    public class Startup
        : StartupBase
    {
        public Startup()
        => AppModel = new BlazorApplicationModel()
        {
            Flavor = BlazorFlavor.WebAssembly | BlazorFlavor.Hybrid,
            Platform = BlazorPlatform.WebWindow,
            CommunicationWay = BlazorCommunicationWay.ViaAPI
        };

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(DesktopApplicationBuilder app)
            => ConfigureWebWindow<App>(app, "app");
    }
}
