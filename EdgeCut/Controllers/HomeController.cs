using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EdgeCut.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
