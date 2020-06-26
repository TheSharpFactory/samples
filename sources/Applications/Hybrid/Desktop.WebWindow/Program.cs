
using TheSharpFactory.Apps.Web.SharedUI;

using WebWindows.Blazor;

using StartupBase = TheSharpFactory.Apps.Web.SharedUI.StartupBase;

namespace TheSharpFactory.Apps.Hybrid.Desktop.WebView
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "RCS1102:Make class static.", Justification = "<Pending>")]
    public static class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancy", "RCS1163:Unused parameter.", Justification = "<Pending>")]
        public static void Main(string[] args)
        {
            StartupBase.AppModel = new BlazorApplicationModel
            {
                Flavor = BlazorFlavor.WebAssembly | BlazorFlavor.Hybrid,
                Platform = BlazorPlatform.WebWindow
            };
            ComponentsDesktop
                .Run<Startup>("The Sharp Factory Samples", "wwwroot/index.html");
        }
    }
}
