using System.Collections.Generic;
using System.Linq;

using AutoMapper;

using TheSharpFactory.Data.Repository.Container.Interfaces;

namespace TheSharpFactory.Domain.Models
{
    public class SalesAggregate : ISalesAggregate
    {
        private readonly IRepositoryContainer _repository;
        private readonly IMapper _mapper;

        public IReadOnlyCollection<ICustomer> Customers { get; private set; }

        public SalesAggregate(
            IRepositoryContainer repository,
            IMapper mapper
        )
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void FetchAllCustomers()
        {
            var customerEntityList = _repository.WorldWideImporters.Sales.Customer.ToList();
            Customers = customerEntityList.Select(c => _mapper.Map<Customer>(c)).ToList();
        }
    }
}
