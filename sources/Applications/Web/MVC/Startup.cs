using Microsoft.Extensions.Configuration;

using TheSharpFactory.Apps.Web.SharedUI;

using StartupBase = TheSharpFactory.Apps.Web.SharedUI.StartupBase;

namespace TheSharpFactory.Apps.Web.MVC
{
    public class Startup
        : StartupBase
    {
        public Startup(
            IConfiguration configuration
        )
            : base(configuration)
        => AppModel = new MvcApplicationModel()
            {
                CommunicationWay = MvcCommunicationWay.ViaAPI
            };
    }
}
