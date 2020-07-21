
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Shared.ViewModels;
using TheSharpFactory.Apps.Web.SharedUI;
using TheSharpFactory.Common.Extensions.DependencyInjection.Mappers;
using TheSharpFactory.Domain.Extensions.DependencyInjection;

namespace TheSharpFactory.Apps.Web.BlazorServerDirect
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
                CommunicationWay = BlazorCommunicationWay.Direct
            };

        public new void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddMapper(true, true, typeof(DomainModelToViewModelMappingProfile).Assembly);
            _ = services.AddSharpFactoryDomain(() => Configuration.GetConnectionString("WWI"));
            base.ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            BlazorApplicationModel appModel
        )
            => ConfigureBlazorServer(app, env, appModel);
    }
}
