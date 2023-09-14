using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Controllers
{

    [AllowAnonymous]
    public class DefaultController : Controller
    {
        BurgerManager burgerManager = new BurgerManager(new EfBurgerRepo());
        public IActionResult Index()
        {
            var values = burgerManager.TGetList();
            return View(values);
        }
    }
}
