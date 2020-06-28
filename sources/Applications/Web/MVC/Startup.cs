using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Shared.ViewModels;
using TheSharpFactory.Apps.Web.SharedUI;
using TheSharpFactory.Common.Extensions.DependencyInjection.Mappers;

using StartupBase = TheSharpFactory.Apps.Web.SharedUI.StartupBase;

namespace TheSharpFactory.Apps.Web.MVC
{
    public class Startup
        : StartupBase
    {
        public Startup(IConfiguration configuration)
            : base(configuration)
        => AppModel = new MvcApplicationModel()
        {
            CommunicationWay = MvcCommunicationWay.ViaAPI
        };

        // This method gets called by the runtime. Use this method to add services to the container.
        public override void ConfigureServices(IServiceCollection services)
        {
            /// register HttpClient services here
            /// register SDK services here
            services.AddMapper(false, false, typeof(DTOToViewModelMappingProfile).Assembly);

            base.ConfigureServices(services);
        }
    }
}
