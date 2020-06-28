using TheSharpFactory.Apps.Cross.SharedUI.Models;

namespace TheSharpFactory.Apps.Cross.SharedUI.ViewModels
{
    public class ItemDetailViewModel
        : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
