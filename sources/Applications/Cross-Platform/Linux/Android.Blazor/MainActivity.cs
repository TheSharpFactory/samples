using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Widget;

using TheSharpFactory.Apps.Cross.SharedUI;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using XamarinEssentialsPlatform = Xamarin.Essentials.Platform;

namespace TheSharpFactory.Apps.Cross.Droid
{
    [Activity(Label = "Apps.Web.BlazorMobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity
        : FormsAppCompatActivity
    {
        private void Platform_ActivityStateChanged(object sender, ActivityStateChangedEventArgs e)
            => Toast.MakeText(this, e.State.ToString(), ToastLength.Short).Show();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            XamarinEssentialsPlatform.Init(this, savedInstanceState);
            Forms.Init(this, savedInstanceState);
            LoadApplication(new BlazorApp());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            XamarinEssentialsPlatform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnResume()
        {
            base.OnResume();

            XamarinEssentialsPlatform.OnResume();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            XamarinEssentialsPlatform.ActivityStateChanged -= Platform_ActivityStateChanged;
        }
    }
}
