using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using StrawberryShake;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK.Graph;
using TheSharpFactory.Services.GRPC.Sales;

namespace TheSharpFactory.SDK.Clients
{
    public class CustomerClient
        : ApiClient<ICustomerDTO, CustomerDTO, Customer, SalesAggregatorService.SalesAggregatorServiceClient, IGetCustomers>
                                                             
    {
        #region Common
        #region Public Members
        #region Contructors
        public CustomerClient(
            IMapper mapper,
            RestClient<ICustomerDTO, CustomerDTO> restClient,
            IGraphQLClient graphClient,
            GrpcClient<SalesAggregatorService.SalesAggregatorServiceClient, Customer> grpcClient
        )
            : base(
                  mapper,
                  restClient,
                  graphClient,
                  grpcClient,
                  "sales",
                  "customers"
            )
        {
        }
        #endregion
        #endregion

        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Public Members
        #region Methods
        public override async Task<IEnumerable<ICustomerDTO>> ReadGraph(
            IOperation<IGetCustomers> operation = null,
            CancellationToken token = default
        )
        {
            var response = operation is null
                         ? await _graphClient
                                .GetCustomersAsync(token)
                                .ConfigureAwait(false)
                         : await _graphClient
                                .GetCustomersAsync(operation, token)
                                .ConfigureAwait(false);
            return response.Data.Customers;
        }
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1 Or ASP.NET Core 3.1
#if netstandard21 || netcoreapp31
        #region Public Members
        #region Methods
        public override async IAsyncEnumerable<ICustomerDTO> ReadGraph(
            IOperation<IGetCustomers>? operation = null,
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            var response = operation is null
                         ? await _graphClient
                                .GetCustomersAsync(token)
                                .ConfigureAwait(false)
                         : await _graphClient
                                .GetCustomersAsync(operation, token)
                                .ConfigureAwait(false); ;

            foreach (var c in response!.Data!.Customers)
                yield return c;
        }
        #endregion
        #endregion
#endif
        #endregion

    }
}
