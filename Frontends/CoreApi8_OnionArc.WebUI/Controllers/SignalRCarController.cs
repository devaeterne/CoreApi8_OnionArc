using Microsoft.AspNetCore.Mvc;

namespace CoreApi8_OnionArc.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
