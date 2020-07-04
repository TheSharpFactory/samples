using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using HotChocolate.AspNetCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

namespace TheSharpFactory.Apps.Web.SharedUI.Areas.Landing.Controllers
{
    [Area("Sales")]
    [Route("[area]/[controller]/{action}")]
    public class CustomersController
        : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomersViewModel _customer;

        public CustomersController(
            ILogger<CustomersController> logger,
            ICustomersViewModel customer
        )
        {
            _logger = logger;
            _customer = customer;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await _customer.GetCustomers(SDK.HttpServiceTypes.REST).ConfigureAwait(true);
            return View(_customer.AllCustomers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
