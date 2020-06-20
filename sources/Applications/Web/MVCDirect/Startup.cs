using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Web.SharedUI;

//using Data.Repository.Common;
//using Data.Repository.Container;
//using Data.Repository.Container.Interfaces;

namespace TheSharpFactory.Apps.Web.MVCDirect
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
            //Database.RegisterModelConnectionString(
            //    RepoLookup.ModelId.WWI,
            //    Configuration.GetConnectionString("WWIConnectionString")
            //);
            //services.AddSingleton<IRepositoryContainer, RepositoryContainer>();

            /// register business objects here

            base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env, MvcApplicationModel appModel)
            => base.Configure(app, env, appModel);
    }
}
