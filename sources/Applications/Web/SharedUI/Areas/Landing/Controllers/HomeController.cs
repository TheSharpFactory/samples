using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using TheSharpFactory.Apps.Shared.Services;
using TheSharpFactory.Apps.Shared.ViewModels.Conventional;

namespace TheSharpFactory.Apps.Web.SharedUI.Areas.Landing.Controllers
{
    [Area("Landing")]
    public class HomeController
        : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICounterService _counterService;
        private readonly IFetchDataViewModel _fetchDataViewModel;

        public HomeController(
            ILogger<HomeController> logger,
            ICounterService counterService,
            IFetchDataViewModel fetchDataViewModel
        )
        {
            _logger = logger;
            _counterService = counterService;
            _fetchDataViewModel = fetchDataViewModel;
        }

        public IActionResult Index()
            => View();

        public IActionResult Counter()
            => View();

        public async Task<IActionResult> FetchData()
        {
            await _fetchDataViewModel.GetForecastAsync(DateTime.Now).ConfigureAwait(false);
            return View(_fetchDataViewModel.Forecasts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
