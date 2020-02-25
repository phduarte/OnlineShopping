using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Inventory;

namespace OnlineShopping.WebStore.Controllers
{
    public class ProductsController : Controller
    {
        readonly ISearchInventory _searchInventory;

        public ProductsController(ISearchInventory searchInventory)
        {
            _searchInventory = searchInventory;
        }

        public IActionResult Index()
        {
            //return Content("Hello World!!");
            return View();
        }

        [Route("/products/{name}")]
        public IActionResult Products(string name)
        {
            var x = _searchInventory.FindByName(name);

            return View(x);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return View(product);
        }
    }
}
