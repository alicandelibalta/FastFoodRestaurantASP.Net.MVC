using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class SauceController : Controller
    {
        SauceManager sauceManager = new SauceManager(new EfSauceRepo());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddSauce()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSauce(Sauce sauce)
        {
            sauce.CategoryID = 4;
            sauceManager.TAdd(sauce);
            return View();
        }


        public IActionResult ListSauce()
        {

            return View();
        }

        public IActionResult UpdateSaucer()
        {
            return View();
        }

        public IActionResult DeleteSauce()
        {
            return View();
        }
    }
}
