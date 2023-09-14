using Hamburgerci.BusinessLayer.Concrete;
using Hamburgerci.DataAccessLayer;
using Hamburgerci.DataAccessLayer.EntityFramework;
using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hamburgerci.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ProfileController : Controller
    {
        private Context _context;
        public ProfileController(Context dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            List<AppUser> usersFromDb = _context.Users.ToList();

            //List<AppUser> users = usersFromDb.Select(u => new UserModel

            //{

            //    UserId = u.Id,

            //    UserName = u.UserName,

            //    // Diğer özellikleri buraya ekle

            //}).ToList();



            return View(usersFromDb);
        }
    }
}
