using System;
using System.ComponentModel;

using TheSharpFactory.Apps.Cross.SharedUI.Models;
using TheSharpFactory.Apps.Cross.SharedUI.ViewModels;

using Xamarin.Forms;

namespace TheSharpFactory.Apps.Cross.SharedUI.Views.XamarinForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            _viewModel = new ItemsViewModel();
            _viewModel.ExecuteLoadItemsCommand().Wait();
            BindingContext = _viewModel;
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            try
            {
                var layout = (BindableObject)sender;
                var item = (Item)layout.BindingContext;
                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
            }
            catch
            {
            }
        }

        async void AddItem_Clicked(object sender, EventArgs e)
            => await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.Items.Count == 0)
                _viewModel.IsBusy = true;
        }

        private async void ItemsTableView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Item item)
                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }
    }
}