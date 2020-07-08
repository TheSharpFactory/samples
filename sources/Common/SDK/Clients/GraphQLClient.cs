using System;
using System.CodeDom.Compiler;
using System.Threading.Tasks;

using StrawberryShake;

using TheSharpFactory.SDK.Graph;

namespace TheSharpFactory.SDK.Clients
{
    [GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GraphQLClient
        : IGraphQLClient
    {
        private readonly IOperationExecutor _executor;

        public GraphQLClient(IOperationExecutorPool executorPool)
            => _executor = executorPool.CreateExecutor(ClientNames.ApiClient);

        public Task<IOperationResult<IGetCustomers>> GetCustomersAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetCustomersOperation(),
                cancellationToken);
        }

        public Task<IOperationResult<IGetCustomers>> GetCustomersAsync(
            IOperation<IGetCustomers> operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
