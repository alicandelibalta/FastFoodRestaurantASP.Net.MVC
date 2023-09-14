using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BurgerController : Controller
    {
        BurgerManager burgerManager = new BurgerManager(new EfBurgerRepo());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBurger()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBurger(Burger burger)
        {
            burger.CategoryID = 1;
            burgerManager.TAdd(burger);
            return View();
        }


        public IActionResult ListBurger()
        {
            
            return View();
        }

        public IActionResult UpdateBurger()
        {
            return View();
        }

        public IActionResult DeleteBurger()
        {
            return View();
        }
    }
}
