using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

using TheSharpFactory.Apps.Cross.SharedUI.Models;

using Xamarin.Forms;

namespace TheSharpFactory.Apps.Cross.SharedUI.Views.XamarinForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = Device.RuntimePlatform == Device.macOS
                           ? MasterBehavior.Default
                           : MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                    MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                    break;
                    case (int)MenuItemType.About:
                    MenuPages.Add(id, new NavigationPage(new AboutPage()));
                    break;
                }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100).ConfigureAwait(false);

                IsPresented = false;
            }
        }
    }
}