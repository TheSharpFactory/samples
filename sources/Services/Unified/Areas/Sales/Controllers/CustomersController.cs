using System.Collections.Generic;
using System.Linq;
using System.Net;

using Microsoft.AspNetCore.Mvc;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK;
using TheSharpFactory.Services.Sales;

namespace TheSharpFactory.Services.Unified.Areas.Sales.Controllers
{
    /// <summary>
    /// Sales : Customers Endpoint
    /// </summary>
    [Area("Sales")]
    [ApiController]
    [Route("[area]/[controller]")]
    public class CustomersController
        : ControllerBase
    {
        private readonly ISalesService _sales;

        public CustomersController(
            ISalesService sales
        )
            => _sales = sales;

        /// <summary>
        /// Fetch all the customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<CustomerDTO>))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(ApiException<string>))]
        public List<CustomerDTO> Get()
        {
            _sales.FetchCustomers();
            return _sales.Customers.ToList();
        }
    }
}
