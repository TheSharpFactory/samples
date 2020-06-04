
using TheSharpFactory.Apps.Cross.SharedUI.Services;
using TheSharpFactory.Apps.Cross.SharedUI.Views.XamarinForms;

using Xamarin.Forms;

namespace TheSharpFactory.Apps.Cross.SharedUI
{
    public partial class XFApp : Application
    {

        public XFApp()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
