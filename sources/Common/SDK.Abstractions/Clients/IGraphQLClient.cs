using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

using StrawberryShake;

using TheSharpFactory.SDK.Graph;

namespace TheSharpFactory.SDK.Clients
{
    [GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IGraphQLClient
    {
        Task<IOperationResult<IGetCustomers>> GetCustomersAsync(
            CancellationToken cancellationToken = default
        );

        Task<IOperationResult<IGetCustomers>> GetCustomersAsync(
            IOperation<IGetCustomers> operation,
            CancellationToken cancellationToken = default
        );
    }
}
