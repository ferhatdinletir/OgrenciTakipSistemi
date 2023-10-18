using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OgrenciTakipSistemi.Entities.Authentication;
using OgrenciTakipSistemi.WebMVC.Models;
using System.Diagnostics;

namespace OgrenciTakipSistemi.WebMVC.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

	}
}
