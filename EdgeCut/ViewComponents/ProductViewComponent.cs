using EdgeCut.DAL;
using EdgeCut.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EdgeCut.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private EdgeDbContext _context { get; set; }
        public ProductViewComponent(EdgeDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
    }
}
