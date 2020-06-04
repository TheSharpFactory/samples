using Xamarin.Essentials;

namespace TheSharpFactory.Apps.Cross.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            Platform.MapServiceToken = "RJHqIE53Onrqons5CNOx~FrDr3XhjDTyEXEjng-CRoA~Aj69MhNManYUKxo6QcwZ0wmXBtyva0zwuHB04rFYAPf7qqGJ5cHb03RCDw1jIW8l";

            LoadApplication(new SharedUI.XFApp());
        }
    }
}
