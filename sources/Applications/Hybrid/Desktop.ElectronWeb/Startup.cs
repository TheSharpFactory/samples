
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Hybrid.Desktop.ElectronWeb
{
    public class Startup
        : Web.SharedUI.StartupBase
    {
        public Startup(IConfiguration configuration)
            : base(configuration)
        => AppModel = new BlazorApplicationModel
        {
            Flavor = BlazorFlavor.Server | BlazorFlavor.Hybrid,
            Platform = BlazorPlatform.Web | BlazorPlatform.Electron,
            CommunicationWay = BlazorCommunicationWay.ViaAPI
        };

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            BlazorApplicationModel appModel
        )
            => ConfigureBlazorServer(app, env, appModel);
    }
}
