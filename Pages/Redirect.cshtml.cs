using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Spotify2YT.Pages
{
    public class Redirect : PageModel
    {
        public string redirectURI = "https://localhost:5001/callback";
        public string responseURI = "https://accounts.spotify.com/authorize?";

        public RedirectResult OnGet()
        {
            return Redirect("");
        }
    }
}
