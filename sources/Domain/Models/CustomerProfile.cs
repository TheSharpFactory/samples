using System.Collections.Generic;

namespace TheSharpFactory.Domain.Models
{
    public class CustomerProfile
        : ICustomerProfile
    {
        public ICollection<IAddress> Addresses { get; set; }
    }
}
