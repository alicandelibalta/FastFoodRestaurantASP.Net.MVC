using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Hamburgerci.Presentation.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ProductController : Controller
    {
        BurgerManager burgerManager = new BurgerManager(new EfBurgerRepo());
        FryManager fryManager = new FryManager(new EfFryRepo());
        BeverageManager beverageManager = new BeverageManager(new EfBeverageRepo());
        SauceManager sauceManager = new SauceManager(new EfSauceRepo());

        Context _context = new Context(); 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel pVm)
        {

            string SelectedCategoryID = pVm.CategoryID;

            if(SelectedCategoryID == "1") 
            {
                Burger burger1 = new Burger()
                {
                    CategoryID = Convert.ToInt32(pVm.CategoryID),
                    Name = pVm.Name,
                    Price = pVm.Price,
                    Description = pVm.Description,
                    Image = pVm.Image
                };

                burgerManager.TAdd(burger1);
            }

            if(SelectedCategoryID == "2")
            {
                Fry fry1 = new Fry()
                {
                    CategoryID = Convert.ToInt32(pVm.CategoryID),
                    Name = pVm.Name,
                    Price = pVm.Price,
                    Description = pVm.Description,
                    Image = pVm.Image
                };

                fryManager.TAdd(fry1);
                
            }

            if(SelectedCategoryID == "3")
            {
                Beverage beverage1 = new Beverage()
                {
                    CategoryID = Convert.ToInt32(pVm.CategoryID),
                    Name = pVm.Name,
                    Price = pVm.Price,
                    Description = pVm.Description,
                    Image = pVm.Image
                };

                beverageManager.TAdd(beverage1);
                
            }

            if(SelectedCategoryID == "4")
            {
                Sauce sauce1 = new Sauce()
                {
                    CategoryID = Convert.ToInt32(pVm.CategoryID),
                    Name = pVm.Name,
                    Price = pVm.Price,
                    Description = pVm.Description,
                    Image = pVm.Image
                };
                sauceManager.TAdd(sauce1);
                
            }

            return View(pVm);
            //return RedirectToAction("Index", "Profile");

            //using (var db = new Context())
            //{
            //    var categories = from c in db.Categories select c;
            //    categories = categories.OrderByDescending(c => c.CategoryID);
            //    var model = new AdminViewModel
            //    {
            //        Categories = categories.ToList(),
            //        Products = db.
            //    }
            //}
        }


        public IActionResult ListProduct()
        {
       
            return View();
        }

        public IActionResult UpdateProduct()
        {
            return View();
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }
    }
}
