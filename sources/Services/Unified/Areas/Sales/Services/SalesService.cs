using System.Collections.Generic;
using System.Linq;

using AutoMapper;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Services.Sales
{
    public class SalesService
        : ISalesService
    {
        private readonly ISalesAggregate _sales;
        private readonly IMapper _mapper;

        public IReadOnlyCollection<CustomerDTO> Customers { get; private set; }
            = new List<CustomerDTO>();

        public SalesService(
            ISalesAggregate sales,
            IMapper mapper
        )
        {
            _sales = sales;
            _mapper = mapper;
        }

        public void FetchCustomers()
        {
            _sales.FetchAllCustomers();
            Customers = _sales
                            .Customers
                            .Select(c => _mapper.Map<CustomerDTO>(c))
                            .ToList();
        }
    }
}
