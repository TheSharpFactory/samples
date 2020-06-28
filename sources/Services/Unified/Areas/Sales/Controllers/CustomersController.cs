using System.Collections.Generic;
using System.Linq;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Services.Unified.Areas.Sales.Controllers
{
    [Area("Sales")]
    [ApiController]
    public class CustomersController
        : ControllerBase
    {
        private readonly ISalesAggregate _sales;
        private readonly IMapper _mapper;

        public CustomersController(
            ISalesAggregate sales,
            IMapper mapper
        )
        {
            _sales = sales;
            _mapper = mapper;
        }

        public List<CustomerDTO> Get()
        {
            _sales.FetchAllCustomers();
            return _sales
                        .Customers
                        .Select(c =>
                            _mapper.Map<CustomerDTO>(c)
                        )
                        .ToList();
        }
    }
}
