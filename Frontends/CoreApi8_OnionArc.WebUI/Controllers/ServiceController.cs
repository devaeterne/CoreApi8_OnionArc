using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CoreApi8_OnionArc.Dtos.ServiceDtos;

namespace CoreApi8_OnionArc.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
