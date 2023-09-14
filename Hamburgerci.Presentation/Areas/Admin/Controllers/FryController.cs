using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class FryController : Controller
    {
        FryManager fryManager = new FryManager(new EfFryRepo());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddFry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFry(Fry fry)
        {
            fry.CategoryID = 2;
            fryManager.TAdd(fry);
            return View();
        }


        public IActionResult ListFry()
        {

            return View();
        }

        public IActionResult UpdateFry()
        {
            return View();
        }

        public IActionResult DeleteFry()
        {
            return View();
        }
    }
}
