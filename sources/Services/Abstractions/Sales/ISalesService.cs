
using System.Collections.Generic;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.Services.Sales
{
    public interface ISalesService
    {
        IReadOnlyCollection<CustomerDTO> Customers { get; }
        void FetchCustomers();
    }
}