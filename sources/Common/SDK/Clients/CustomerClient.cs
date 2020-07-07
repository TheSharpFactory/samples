using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Google.Protobuf.WellKnownTypes;

using Grpc.Core;
using Grpc.Core.Utils;

using StrawberryShake;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK.Graph;
using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.SDK.Clients
{
    public class CustomerClient
        : ApiClient<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers>                                                    
    {
        #region Common
        #region Public Members
        #region Contructors
        public CustomerClient(
            IMapper mapper,
            IRestClient<ICustomerDTO, CustomerDTO> restClient,
            IGraphQLClient graphClient,
            GrpcClient<CustomerMessage> grpcClient
        )
            : base(
                  mapper,
                  restClient,
                  graphClient,
                  grpcClient,
                  "Sales",
                  "Customers"
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
        public override async Task<IEnumerable<ICustomerDTO>> ReadGrpc(
            CancellationToken token = default
        )
        {
            var result = await _grpcClient
                            .GetCustomersStream(
                                new Empty(),
                                cancellationToken: token
                            )
                            .ResponseStream
                            .ToListAsync();
            return result
                    .Select(c => _mapper.Map<CustomerDTO>(c))
                    .ToList();
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

        public override async IAsyncEnumerable<ICustomerDTO> ReadGrpc(
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            var result = _grpcClient
                            .GetCustomersStream(
                                new Empty(),
                                cancellationToken: token
                            )
                            .ResponseStream
                            .ReadAllAsync();
            await foreach (var c in result)
                yield return _mapper.Map<CustomerDTO>(c);

        }
        #endregion
        #endregion
#endif
        #endregion

    }
}
