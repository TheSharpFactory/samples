using Microsoft.MobileBlazorBindings;

using Xamarin.Forms;

using BlazorViews = TheSharpFactory.Apps.Cross.SharedUI.Views.BlazorNative;

namespace TheSharpFactory.Apps.Cross.SharedUI
{
    public class BlazorApp : Application
    {
        public BlazorApp()
        {
            var host = MobileBlazorBindingsHost
                .CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    // services.AddSingleton<AppState>();
                })
                .Build();

            MainPage = new ContentPage();
            host.AddComponent<BlazorViews.HelloWorld>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
