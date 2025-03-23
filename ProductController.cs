using DI.Models;
using DI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class ProductController : Controller
    {
        IProduct prod;

        public ProductController(IProduct prod)
        {
            this.prod = prod;
        }
        public IActionResult Index()
        {
            var data = prod.FetchProduct();
            return View(data);
        }

        [HttpPost]
        public IActionResult IndexSearch(string str)
        {
            var data = prod.IndexSearch(str);
      
            if (data == null)
            {
                return View("NoData");
            }
            else
            {
                return View(data);
            }
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            prod.AddProduct(p);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            prod.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult FetchUpdate(int id)
        {
            var data = prod.FetchUpdate(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);

        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            prod.UpdateProduct(p);
            return RedirectToAction("Index");
        }
    }
}
