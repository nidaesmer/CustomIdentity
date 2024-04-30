using CustomIdentity.Models;
using CustomIdentity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Controllers
{
	public class AccountController : Controller
	{
		private readonly SignInManager<AppUser> signInManager;
		public  AccountController(SignInManager<AppUser> signInManager)
		{
			this.signInManager = signInManager;
		}
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
        public async Task<IActionResult> LoginAsync(LoginVM model)
        {
			if(ModelState.IsValid)
			{
				//login
				var result = await signInManager.PasswordSignInAsync(model.Username!, model.Password!, model.RememberMe, false);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				ModelState.AddModelError("", "Invalid login attemp");
				return View(model);
			}
            return View(model);
        }


        public IActionResult Register()
		{
			return View();
		}

		public IActionResult Logout()
		{
			return View();
		}
	}
}
