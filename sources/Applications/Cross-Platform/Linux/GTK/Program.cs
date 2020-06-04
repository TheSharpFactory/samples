using System;

using TheSharpFactory.Apps.Cross.SharedUI;

using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace TheSharpFactory.Apps.Cross.Linux
{
    internal static class Program
    {
        [STAThread]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Redundancy", "RCS1163:Unused parameter.", Justification = "<Pending>")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        public static void Main(string[] args = null)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new XFApp();
            var window = new FormsWindow()
            {
                Title = "The Sharp Factory Sample App"
            };
            window.LoadApplication(app);
            window.SetApplicationTitle("Game of Life");
            window.Show();

            Gtk.Application.Run();
        }
    }
}
