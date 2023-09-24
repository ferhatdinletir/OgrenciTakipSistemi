using Microsoft.AspNetCore.Mvc;
using OgrenciTakipSistemi.DAL.Contexts;

namespace OgrenciTakipSistemi.WebMVC.Areas.DanismanArea.Controllers
{
    public class DanismanController : Controller
    {
        private readonly SqlDbContext dbContext;

        public DanismanController(SqlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
