using AutoMapper;
using AutoMapper.Execution;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OgrenciTakipSistemi.Entities.Authentication;
using OgrenciTakipSistemi.WebMVC.Models.DTOs;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
	public class GirisController : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly RoleManager<AppRole> roleManager;
		private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;

        public GirisController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper)
		{
			this.userManager = userManager;
			this.roleManager = roleManager;
			this.signInManager = signInManager;
            this.mapper = mapper;
        }

		public IActionResult Index()
		{
            GirisDTO girisDTO = new GirisDTO();
            return View(girisDTO);
        }

        #region Giris
        [HttpPost]
        public async Task<IActionResult> Giris(GirisDTO girisDTO)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Wrong Password or Email Adress");
                return View(girisDTO);
            }

            AppUser? user = await userManager.FindByEmailAsync(girisDTO.Email);

            var result = await signInManager.PasswordSignInAsync(user, girisDTO.Password, true, true);
            var role = userManager.GetRolesAsync(user).Result.FirstOrDefault();

            if (result.Succeeded)
            {
                if (role == "Admin")
                {
                    return RedirectToAction("Index", "Home", new { Area = "AdminArea" });
                }
                else if (role == "Danisman")
                {
                    return RedirectToAction("Index", "Home", new { Area = "DanismanArea" });
                }
                else if (role == "Ogrenci")
                {
                    return RedirectToAction("Index", "Home", new { Area = "OgrenciArea" });
                }
            }
            return View(girisDTO);
        } 
        #endregion

        #region Cikis
        public async Task<IActionResult> Cikis()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Ogrenci Kayit
        [HttpGet]
        public async Task<IActionResult> Kayit()
        {
            KayitDTO kayitDTO = new KayitDTO();
            return View(kayitDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Kayit(KayitDTO kayitDTO)
        {
            AppUser user = mapper.Map<AppUser>(kayitDTO);
            user.UserName = kayitDTO.Email;

            var result = await userManager.CreateAsync(user, kayitDTO.Password);
            if (result.Succeeded)
            {
                var userRole = await roleManager.FindByNameAsync("Ogrenci");
                if (userRole == null)
                {
                    userRole = new AppRole();
                    userRole.Name = "Ogrenci";
                    await roleManager.CreateAsync(userRole);

                }
                await userManager.AddToRoleAsync(user, userRole.Name);


                return RedirectToAction("Index", "Login", new { Area = "OgrenciArea" });

            }
            ModelState.AddModelError("", "Kayıt Başarısız");
            return View(kayitDTO);
        } 
        #endregion
    }
}
