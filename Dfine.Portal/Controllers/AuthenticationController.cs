using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECSM.Portal.Controllers
{
    [AllowAnonymous]
    [Route("[controller]/[action]")]
    public class AuthenticationController : Controller
    {
        IConfiguration configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet("{scheme?}")]
        public IActionResult SignIn(string scheme)
        {
            var redirectUrl = Url.Content("~/");
            var properties = new AuthenticationProperties
            {
                RedirectUri = redirectUrl
            };
            var challenge = Challenge(properties, scheme);
            return challenge;
        }

        public async Task<IActionResult> SignOut(string scheme)
        {
            await HttpContext.SignOutAsync().ConfigureAwait(false);
            if (scheme == "B2C")
                return Redirect($"https://StridentiaB2C.b2clogin.com/StridentiaB2C.onmicrosoft.com/B2C_1_SignInFlow/oauth2/v2.0/logout?post_logout_redirect_uri={configuration.GetValue<string>("AzureB2C:LogOutRedirect")}");
            else
                return Redirect("/");
        }
    }
}
