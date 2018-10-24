using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerSideAzureAd.Server.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Content("<h1>Oh! hai!</h1><a href='/app'>Visit the app mate!</a>", contentType: "text/html");
        }

        [HttpGet("signin")]
        public IActionResult SignIn(string redirectUri = "")
        {
            return Challenge(new AuthenticationProperties { RedirectUri = redirectUri }, AzureADDefaults.AuthenticationScheme);
        }

        [HttpGet("signout")]
        public IActionResult SignOut()
        {
            return Redirect("/AzureAD/Account/SignOut");
        }
    }
}