using System;
using System.ComponentModel;
using System.Linq;

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
        #region Private Members
        #region Fields
        private readonly ItemsViewModel _viewModel;
        #endregion

        #region Methods
        private async void AddItem_Clicked(object sender, EventArgs e)
            => await Navigation.PushModalAsync(
                new NavigationPage(new NewItemPage())
            ).ConfigureAwait(true);

        private async void OnItemSelected(object sender, EventArgs args)
        {
            try
            {
                if (sender is BindableObject layout && layout.BindingContext is Item item)
                {
                    await Navigation.PushAsync(
                        new ItemDetailPage(new ItemDetailViewModel(item))
                    ).ConfigureAwait(true);
                }
            }
            catch
            {
            }
        }

        private async void ItemsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection?.Count > 0 && e.CurrentSelection?.First() is Item item)
            {
                await Navigation.PushAsync(
                    new ItemDetailPage(new ItemDetailViewModel(item))
                ).ConfigureAwait(true);

                if (sender is CollectionView collectionView)
                {
                    collectionView.SelectedItem = null;
                    collectionView.SelectedItems.Clear();
                }
            }
        }

        private async void ItemsTableView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex >= 0 && e.SelectedItem is Item item)
            {
                await Navigation.PushAsync
                    (new ItemDetailPage(new ItemDetailViewModel(item))
                ).ConfigureAwait(true);

                if (sender is ListView listView)
                    listView.SelectedItem = null;
            }
        }
        #endregion
        #endregion

        #region Protected Members
        #region Methods
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.Items.Count == 0)
            {
                _viewModel.IsBusy = true;
            }
        }
        #endregion
        #endregion

        #region Public Members
        #region Constructors
        public ItemsPage()
        {
            InitializeComponent();

            _viewModel = new ItemsViewModel();
            _viewModel.ExecuteLoadItemsCommand().Wait();
            BindingContext = _viewModel;
        }
        #endregion
        #endregion
    }
}