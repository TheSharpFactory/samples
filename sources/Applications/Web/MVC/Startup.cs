using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.MVC
{
    public class Startup
        : SharedUI.StartupBase
    {
        public Startup(IConfiguration configuration)
            : base(configuration)
        {

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public override void ConfigureServices(IServiceCollection services)
        {
            /// register HttpClient services here
            /// register SDK services here

            base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env, MvcApplicationModel appModel)
            => base.Configure(app, env, appModel);
    }
}
