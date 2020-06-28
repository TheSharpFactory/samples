using System.ComponentModel.DataAnnotations;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public class CustomerViewModel
        : ICustomerViewModel
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
