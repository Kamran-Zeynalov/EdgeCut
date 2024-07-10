using EdgeCut.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EdgeCut.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Product> products = new()
            {
               new Product {
                Name = "Brown",
                Price = 200,
                Url = "f1.png"
                },
                new Product{
                  Name = "Red",
                Price = 200,
                Url = "f1.png"
                },
                new Product
                {
                    Name = "Blue",
                    Price = 200,
                    Url = "f1.png"
                },


                };
            return View(products);
        }
    }
}
