using System.Linq;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using TheSharpFactory.Apps.Shared.ViewModels.Conventional;
using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Apps.Web.MVCDirect.Areas.Customers.Controllers
{
    [Area("Sales")]
    public class CustomersController
        : Controller
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

        public IActionResult Index()
        {
            _sales.FetchAllCustomers();
            var model =  _sales
                            .Customers
                            .Select(c =>
                                _mapper.Map<CustomerViewModel>(c) // VM needs to be created
                            )
                            .ToList();
            return View(model);
        }
    }
}
