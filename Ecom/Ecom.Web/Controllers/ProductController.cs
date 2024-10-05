using Ecom.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Web.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var model = new CreateProductViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel model)
        {
            Db.Products.Add(model);
            return View(model);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
