using Hamburgerci.BusinessLayer.Abstract;
using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class MenuController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuRepo());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMenu()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMenu(Menu menu)
        {
            menuManager.TAdd(menu);
            return View();
        }


        public IActionResult ListMenu()
        {
            var values = menuManager.TGetList();
            return View(values);
        }

        public IActionResult UpdateMenu()
        {
            return View();
        }

        public IActionResult DeleteMenu()
        {
            return View();
        }
    }
}
