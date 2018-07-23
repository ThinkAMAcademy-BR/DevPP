using Microsoft.AspNetCore.Antiforgery;
using DevPP.Controllers;

namespace DevPP.Web.Host.Controllers
{
    public class AntiForgeryController : DevPPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
