using System.Collections.Generic;
using System.Linq;

using AutoMapper;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Services.GraphTypes
{
    public class Query
    {
        private readonly IMapper _mapper;
        private readonly ISalesAggregate _sales;

        public Query(
            IMapper mapper,
            ISalesAggregate sales
        )
        {
            _mapper = mapper;
            _sales = sales;
        }

        public IEnumerable<ICustomerDTO> GetCustomers()
        {
            _sales.FetchAllCustomers();
            return _sales
                    .Customers
                    .Select(model => _mapper.Map<ICustomerDTO>(model));
        }
    }
}
