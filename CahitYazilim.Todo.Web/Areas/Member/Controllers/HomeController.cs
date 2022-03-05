using CahitYazilim.Todo.Business.Interfaces;
using CahitYazilim.Todo.Entities.Concrete;
using CahitYazilim.Todo.Web.BaseControllers;
using CahitYazilim.Todo.Web.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CahitYazilim.Todo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class HomeController : BaseIdentityController
    {
        private readonly IRaporService _raporService;
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
       
        public HomeController(IRaporService raporService, UserManager<AppUser> userManager, IGorevService gorevService, IBildirimService bildirimService):base(userManager)
        {
            _bildirimService = bildirimService;
            _gorevService = gorevService;
           
            _raporService = raporService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await GetirGirisYapanKullanici();
            TempData["Active"] = TempdataInfo.Anasayfa;
            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiileAppUserId(user.Id);
            ViewBag.TamamlananGorevSayisi = _gorevService.GetirGorevSayisiTamamlananileAppUserId(user.Id);

            ViewBag.TamamlanmasiGerekenGorevSayisi = _gorevService.GetirGorevSayisiTamamlanmasiGerekenileAppUserId(user.Id);

            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);
            return View();
        }
    }
}