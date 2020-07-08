using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using StrawberryShake;

using TheSharpFactory.SDK;
using TheSharpFactory.SDK.Graph;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public interface ICustomersViewModel
    {
        IReadOnlyCollection<ICustomerViewModel> AllCustomers { get; }

        Task GetCustomers(
            HttpServiceTypes apiTypes = HttpServiceTypes.REST,
            CancellationToken token = default
        );

        Task GetCustomers(
            IOperation<IGetCustomers> getOperation,
            HttpServiceTypes apiTypes = HttpServiceTypes.REST,
            CancellationToken token = default
        );

        Task GetCustomersStream(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        );
    }
}
