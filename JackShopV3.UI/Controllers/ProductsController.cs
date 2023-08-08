using JackShopV3.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JackShopV3.UI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _service.GetProductsAsync();

            return View(products);
        }
    }
}
