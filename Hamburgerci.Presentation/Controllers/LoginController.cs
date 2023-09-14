using Hamburgerci.EntityLayer;
using Hamburgerci.Presentation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> SignUp(SignUpViewModel s)
        {
            AppUser appUser = new AppUser()
            {
                Name = s.Name,
                Surname = s.Surname,
                Email = s.Mail,
                UserName = s.Username,

            };

            if (s.Password == s.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, s.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(s);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel si)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(si.Username, si.Password, false, true);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area = "Users" });
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }

      

    }
}
