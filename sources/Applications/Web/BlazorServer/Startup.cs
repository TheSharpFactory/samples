
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.BlazorServer
{
    public class Startup
        : SharedUI.StartupBase
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BlazorApplicationModel appModel)
            => ConfigureBlazorServer(app, env, appModel);
    }
}
