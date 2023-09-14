using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuRepo());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepo());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View("AddCategory");
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryManager.TAdd(category);
            return View("AddCategory");
        }


        public IActionResult ListCategory()
        {
            var values = categoryManager.TGetList();
            return View();
        }

        public IActionResult UpdateCategory()
        {
            return View();
        }

        public IActionResult DeleteCategory()
        {
            return View();
        }
    }
}
