using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

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
        public IActionResult Index(CancellationToken token)
        {
            _customer.GetCustomers(SDK.HttpServiceTypes.REST, token);
            _logger.LogInformation(JsonConvert.SerializeObject(_customer.AllCustomers));
            return View(_customer.AllCustomers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
