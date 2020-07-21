using System.Collections.Generic;
using System.Threading;

using StrawberryShake;

using TheSharpFactory.SDK;
using TheSharpFactory.SDK.Graph;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public interface ICustomersViewModel
    {
        IAsyncEnumerable<ICustomerViewModel> AllCustomers { get; }

        void GetCustomers(
            HttpServiceTypes apiTypes = HttpServiceTypes.REST,
            CancellationToken token = default
        );

        void GetCustomers(
            IOperation<IGetCustomers> getOperation,
            HttpServiceTypes apiTypes = HttpServiceTypes.REST,
            CancellationToken token = default
        );

        void GetCustomersStream(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        );
    }
}
