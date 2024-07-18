using EdgeCut.DAL;
using EdgeCut.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EdgeCut.Areas.AdminArea.Controllers
{
    [Area("AdminArea")] 
    public class ProductController : Controller
    {
        private readonly EdgeDbContext _context;

        public ProductController( EdgeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
    }
}
