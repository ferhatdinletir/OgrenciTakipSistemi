using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OgrenciTakipSistemi.Entities.Authentication;
using OgrenciTakipSistemi.WebMVC.Models;
using System.Diagnostics;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //AppUser admin = new AppUser { UserName = "Ferhat", Email = "ferhat@gmail.com", PhoneNumberConfirmed = true, TwoFactorEnabled = false, EmailConfirmed = true, AccessFailedCount = 0, LockoutEnabled = false };
            //var result = await userManager.CreateAsync(admin, "123");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}