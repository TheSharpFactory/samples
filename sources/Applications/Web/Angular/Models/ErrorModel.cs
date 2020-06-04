using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SF.Apps.Web.Angular.Models
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        private readonly ILogger<ErrorModel> _logger;
        public string RequestId { get; set; }

        public ErrorModel(ILogger<ErrorModel> logger)
            => _logger = logger;


        public bool ShowRequestId
            => !string.IsNullOrEmpty(RequestId);

        public void OnGet()
            => RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}
