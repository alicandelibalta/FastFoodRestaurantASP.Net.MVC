using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BeverageController : Controller
    {
       BeverageManager beverageManager = new BeverageManager(new EfBeverageRepo());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBeverage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBeverage(Beverage beverage)
        {
            beverage.CategoryID = 3;
            beverageManager.TAdd(beverage);
            return View();
        }


        public IActionResult ListBeverage()
        {

            return View();
        }

        public IActionResult UpdateBeverage()
        {
            return View();
        }

        public IActionResult DeleteBeverage()
        {
            return View();
        }
    }
}
