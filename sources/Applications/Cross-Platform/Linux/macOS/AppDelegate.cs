using AppKit;
using Foundation;

using Xamarin.Forms;

using TheSharpFactory.Apps.Cross.SharedUI;
using Xamarin.Forms.Platform.MacOS;

namespace TheSharpFactory.Apps.Cross.macOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate
        : FormsApplicationDelegate
    {
        readonly NSWindow window;

        public override NSWindow MainWindow
            => window;

        public AppDelegate()
        {
            const NSWindowStyle style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var rect = new CoreGraphics.CGRect(0, 0, 1024, 768);
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false)
            {
                Title = "Xamarin.Forms on Mac!", // choose your own Title here
                TitleVisibility = NSWindowTitleVisibility.Visible
            };
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            Forms.Init();
            LoadApplication(new XFApp());
            base.DidFinishLaunching(notification);

        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
