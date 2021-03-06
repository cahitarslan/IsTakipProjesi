using AutoMapper;
using CahitYazilim.Todo.Business.Interfaces;
using CahitYazilim.Todo.DTO.DTOs.AppUserDtos;
using CahitYazilim.Todo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CahitYazilim.Todo.Web.ViewComponents
{
    public class Wrapper : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public Wrapper(UserManager<AppUser> userManager, IBildirimService bildirimService, IMapper mapper)
        {
            _mapper = mapper;
            _bildirimService = bildirimService;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var identityUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
           var model= _mapper.Map<AppUserListDto>(identityUser);
   

            var bildirimler = _bildirimService.GetirOkunmayanlar(model.Id).Count;

            ViewBag.BildirimSayisi = bildirimler;
            var roles = _userManager.GetRolesAsync(identityUser).Result;

            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member", model);
           
        }
    }
}
