using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgerci.Presentation.Areas.Users.Controllers
{
	[Area("Users")]
	[AllowAnonymous]
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
