using System.ComponentModel.DataAnnotations;
using System;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public class CustomerViewModel
        : ICustomerViewModel
    {
        public string Id { get; set; } = Guid.Empty.ToString();
        [Required(AllowEmptyStrings = false, ErrorMessage = "'{0}' field is required")]
        public string Name { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
    }
}
