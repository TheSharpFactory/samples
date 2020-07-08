
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.BlazorServer
{
    public class Startup
        : SharedUI.StartupBase
    {
        public Startup(IConfiguration configuration)
            : base(configuration)
            => AppModel = new BlazorApplicationModel
            {
                Flavor = BlazorFlavor.Server,
                Platform = BlazorPlatform.Web,
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
