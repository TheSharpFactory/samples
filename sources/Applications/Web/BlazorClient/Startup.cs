using TheSharpFactory.Apps.Web.SharedUI;

namespace TheSharpFactory.Apps.Web.BlazorClient
{
    public class Startup
        : StartupBase
    {
        public Startup()
            => AppModel = new BlazorApplicationModel
            {
                Flavor = BlazorFlavor.WebAssembly | BlazorFlavor.PWA,
                Platform = BlazorPlatform.Web,
                CommunicationWay = BlazorCommunicationWay.ViaAPI
            };
    }
}
