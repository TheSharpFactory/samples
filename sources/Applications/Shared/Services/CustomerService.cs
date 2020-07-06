
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using StrawberryShake;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK;
using TheSharpFactory.SDK.Clients;
using TheSharpFactory.SDK.Graph;
using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.Apps.Shared.Services
{
    public class CustomerService
        : ServiceBase<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers>
    {
        public CustomerService(
            IMapper mapper,
            ApiClient<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers> apiClient
        )
            : base(mapper, apiClient)
        {
        }

        #region Net Standard 2.0
#if netstandard20
        public override async Task<IEnumerable<ICustomerDTO>> Read(
            IOperation<IGetCustomers> getOperation,
            HttpServiceTypes serviceType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => await _apiClient
                .Read(serviceType, getOperation, token: token)
                .ConfigureAwait(false);
#endif

        #endregion

        #region .NET Standard 2.1 
#if netstandard21

        public override async IAsyncEnumerable<ICustomerDTO> Read(
            IOperation<IGetCustomers>? getOperation,
            HttpServiceTypes serviceType = HttpServiceTypes.REST,
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            await foreach (var c in _apiClient.Read(serviceType, getOperation!, token: token).ConfigureAwait(false))
                yield return c;
        }
#endif
        #endregion
    }
}
