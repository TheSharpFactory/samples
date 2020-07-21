
using WebWindows.Blazor;

namespace TheSharpFactory.Apps.Hybrid.Desktop.WebWindow
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "RCS1102:Make class static.", Justification = "<Pending>")]
    public static class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancy", "RCS1163:Unused parameter.", Justification = "<Pending>")]
        public static void Main(string[] args)
            => ComponentsDesktop
                .Run<Startup>("The Sharp Factory Samples", "wwwroot/index.html");
    }
}
