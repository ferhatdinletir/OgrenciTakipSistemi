using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OgrenciTakipSistemi.Business.Abstract;
using OgrenciTakipSistemi.DAL.Contexts;
using OgrenciTakipSistemi.Entities.Concrete;
using OgrenciTakipSistemi.WebMVC.Areas.AdminArea.Models.DTOs;

namespace OgrenciTakipSistemi.WebMVC.Areas.AdminArea.Controllers
{
    public class AdminLoginController : Controller
    {
        private readonly IDanismanManager danismanManager;
        private readonly IOgrenciManager ogrenciManager;
       
        private readonly IMapper mapper;

        public AdminLoginController(IDanismanManager danismanManager, IOgrenciManager ogrenciManager, IMapper mapper)
        {
            this.danismanManager = danismanManager;
            this.ogrenciManager = ogrenciManager;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var Danisman = await danismanManager.GetAllInclude(null, p => p.Ogrenciler);
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            LoginDTO loginDTO = new();
            var ogrenciler = await ogrenciManager.GetAllAsync();
            IList<SelectListItem> list = new List<SelectListItem>();

            foreach (var ogrenci in ogrenciler)
            {
                SelectListItem item = new SelectListItem()
                { Value = ogrenci.Id.ToString(), Text = ogrenci.OgrenciAdi };
                list.Add(item);
            }
            ViewBag.ogrenciler = list;

            return View(loginDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(loginDTO);
            }

            try
            {
                var danisman = mapper.Map<Danisman>(loginDTO);
                await danismanManager.InsertAsync(danisman);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(loginDTO);
            }
        }
    }
}
