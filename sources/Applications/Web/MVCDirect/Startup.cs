using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Apps.Shared.ViewModels;
using TheSharpFactory.Apps.Web.SharedUI;
using TheSharpFactory.Common.Extensions.DependencyInjection.Mappers;
using TheSharpFactory.Domain.Extensions.DependencyInjection;

using StartupBase = TheSharpFactory.Apps.Web.SharedUI.StartupBase;

namespace TheSharpFactory.Apps.Web.MVCDirect
{
    public class Startup
        : StartupBase
    {
        public Startup(IConfiguration configuration)
            : base(configuration)
        => AppModel = new MvcApplicationModel()
        {
            CommunicationWay = MvcCommunicationWay.Direct
        };

        // This method gets called by the runtime. Use this method to add services to the container.
        public override void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddMapper(true, false, typeof(DomainModelToViewModelMappingProfile).Assembly);
            _ = services.AddSharpFactoryDomain(() => Configuration.GetConnectionString("WWI"));
            base.ConfigureServices(services);
        }
    }
}
