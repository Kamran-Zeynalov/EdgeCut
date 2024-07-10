using EdgeCut.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Xml.Linq;

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
