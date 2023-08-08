using JackShopV3.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JackShopV3.UI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _service.GetCategoriesAsync();

            return View(categories);
        }
    }
}
