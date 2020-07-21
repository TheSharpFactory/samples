using System.Collections.Generic;
using System.Linq;
using System.Threading;

using AutoMapper;

using StrawberryShake;

using TheSharpFactory.Apps.Shared.Services;
using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK;
using TheSharpFactory.SDK.Clients;
using TheSharpFactory.SDK.Graph;
using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public class CustomersViewModel
        : ICustomersViewModel
    {
        #region Common

        #region Private Members
        #region Fields
        private readonly IMapper _mapper;
        private readonly ServiceBase<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers> _customerService;
        #endregion
        #endregion

        #region Public Members

        #region Constructors
        public CustomersViewModel(
            IMapper mapper,
            ServiceBase<ICustomerDTO, CustomerDTO, CustomerMessage, GrpcClient<CustomerMessage>, IGetCustomers> customerService
        )
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        #endregion

        #region Methods

        public void GetCustomers(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => AllCustomers = _customerService
                                    .Read(apiType, token)
                                    .Select(c => _mapper.Map<CustomerViewModel>(c));

        public void GetCustomers(
            IOperation<IGetCustomers> getOperation,
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => AllCustomers = _customerService.Read(getOperation, apiType, token)
                                .Select(c => _mapper.Map<CustomerViewModel>(c));

        public void GetCustomersStream(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => AllCustomers = _customerService
                                .Read(apiType, token)
                                .Select(dto => _mapper.Map<CustomerViewModel>(dto));
        #endregion

        #endregion

        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Public Members
        #region Properties
        public IAsyncEnumerable<ICustomerViewModel> AllCustomers { get; private set; }
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1 
#if netstandard21 
        #region Public Members
        #region Properties
        public IAsyncEnumerable<ICustomerViewModel>? AllCustomers { get; private set; }
        #endregion
        #endregion
#endif
        #endregion
    }
}
