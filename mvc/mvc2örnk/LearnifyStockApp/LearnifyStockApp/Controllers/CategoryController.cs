using System.Data;
using LearnifyStockApp.Models.Repositories;
using LearnifyStockApp.Models.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LearnifyStockApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ActionResult> Index()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(AddCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _categoryRepository.AddAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
