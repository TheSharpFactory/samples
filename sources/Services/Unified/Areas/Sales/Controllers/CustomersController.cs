using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.Services.Unified.Areas.Sales.Controllers
{
    [Area("Sales")]
    [ApiController]
    public class CustomersController
        : ControllerBase
    {
        private readonly ISalesService _sales;

        public CustomersController(
            ISalesService sales
        )
            => _sales = sales;

        public List<CustomerDTO> Get()
        {
            _sales.FetchCustomers();
            return _sales.Customers.ToList();
        }
    }
}
