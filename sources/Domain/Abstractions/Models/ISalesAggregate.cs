using System.Collections.Generic;

namespace TheSharpFactory.Domain.Models
{
    public interface ISalesAggregate
    {
        IReadOnlyCollection<ICustomer> Customers { get; }

        void FetchAllCustomers();
    }
}