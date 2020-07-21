using System.Collections.Generic;

namespace TheSharpFactory.Domain.Models
{
    public interface ICustomerProfile
    {
        ICollection<IAddress> Addresses { get; set; }
    }
}