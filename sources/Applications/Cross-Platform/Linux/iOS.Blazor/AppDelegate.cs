
using Foundation;

using TheSharpFactory.Apps.Cross.SharedUI;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using XamarinEssentialsPlatform = Xamarin.Essentials.Platform;

namespace TheSharpFactory.Apps.Cross.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate
        : FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            LoadApplication(new BlazorApp());

            return base.FinishedLaunching(app, options);
        }

        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
            => XamarinEssentialsPlatform.OpenUrl(app, url, options) || base.OpenUrl(app, url, options);
    }
}
