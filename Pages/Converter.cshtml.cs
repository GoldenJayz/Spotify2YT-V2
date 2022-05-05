using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Spotify2YT.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ConverterModel : PageModel
    {
        // to access from frontend to backend by @Model.whatever
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        private readonly ILogger<ErrorModel> _logger;


        public ConverterModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }


        public void Redirect()
        {

        }


        public void OnGet()
        {

        }
    }
}
