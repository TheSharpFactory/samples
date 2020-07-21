
using TheSharpFactory.Apps.Cross.SharedUI;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using XamarinEssentialsPlatform = Xamarin.Essentials.Platform;

namespace TheSharpFactory.Apps.Cross.Tizen
{
    internal class Program
        : FormsApplication
	{
		protected override void OnCreate()
		{
			base.OnCreate();
            XamarinEssentialsPlatform.MapServiceToken = "RJHqIE53Onrqons5CNOx~FrDr3XhjDTyEXEjng-CRoA~Aj69MhNManYUKxo6QcwZ0wmXBtyva0zwuHB04rFYAPf7qqGJ5cHb03RCDw1jIW8l"; ;
			LoadApplication(new XFApp());
		}

        private static void Main(string[] args = null)
		{
			var app = new Program();
            Forms.Init(app);
            app.Run(args);
		}
	}
}
