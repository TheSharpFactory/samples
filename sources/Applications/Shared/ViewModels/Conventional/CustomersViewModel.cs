using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
        #region Properties
        public IReadOnlyCollection<ICustomerViewModel> AllCustomers { get; private set; }
            = new List<ICustomerViewModel>();
        #endregion

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
        #endregion

        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Public Members
        #region Methods

        public async Task GetCustomers(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => AllCustomers = (await _customerService.Read(apiType, token).ConfigureAwait(false))
                                .Select(c => _mapper.Map<CustomerViewModel>(c))
                                .ToList();

        public async Task GetCustomers(
            IOperation<IGetCustomers> getOperation,
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => AllCustomers = (await _customerService.Read(getOperation, apiType, token).ConfigureAwait(false))
                                .Select(c => _mapper.Map<CustomerViewModel>(c))
                                .ToList();

        public async Task GetCustomersStream(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
            => AllCustomers = (await _customerService.Read(apiType, token).ConfigureAwait(false))
                                .Select(dto => _mapper.Map<CustomerViewModel>(dto))
                                .ToList();
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1
#if netstandard21
        #region Public Members
        #region Methods

        public async Task GetCustomers(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
        {
            IList<ICustomerViewModel> vmList = new List<ICustomerViewModel>();
            await foreach (var c in _customerService.Read(apiType, token).ConfigureAwait(false))
                vmList.Add(_mapper.Map<CustomerViewModel>(c));
            AllCustomers = new ReadOnlyCollection<ICustomerViewModel>(vmList);
        }

        public async Task GetCustomers(
            IOperation<IGetCustomers>? getOperation,
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
        {
            IList<ICustomerViewModel> vmList = new List<ICustomerViewModel>();
            await foreach (var c in _customerService.Read(getOperation, apiType, token).ConfigureAwait(false))
                vmList.Append(_mapper.Map<CustomerViewModel>(c));
            AllCustomers = new ReadOnlyCollection<ICustomerViewModel>(vmList);
        }

        public async Task GetCustomersStream(
            HttpServiceTypes apiType = HttpServiceTypes.REST,
            CancellationToken token = default
        )
        {
            IList<ICustomerViewModel> customerList = new List<ICustomerViewModel>();

            var stream = _customerService
                            .ReadStream(apiType, token)
                            .ConfigureAwait(false);
            await foreach (var c in stream)
            {
                if (c != null)
                {
                    var customerVM = _mapper.Map<CustomerViewModel>(c);
                    customerList.Add(customerVM);
                }
            }
            AllCustomers = new ReadOnlyCollection<ICustomerViewModel>(customerList);
        }

        #endregion
        #endregion
#endif
        #endregion
    }
}
