using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.HomeDto;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using PagedList.Core.Mvc;

namespace Cv_Information.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class HomeController : BaseIdentityController
    {

        private IAboutService _aboutService;
        private IEducationService _educationService;
        private IExperienceService _experienceService;
        private ISkillsService _skillsService;
        private IAppUserService _appUserService;

        public HomeController(IAboutService aboutService, IEducationService educationService, IExperienceService experienceService, ISkillsService skillsService,UserManager<AppUser> userManager,IAppUserService appUserService):base(userManager)
        {
            _aboutService = aboutService;
            _educationService = educationService;
            _experienceService = experienceService;
            _skillsService = skillsService;
            _appUserService = appUserService;
        }


        public async Task<IActionResult> Index(int page=1,int pagesize=3)
        {

            var user = await SıgnIn();

            UserListAllViewModel model = new UserListAllViewModel()
            {
                About = _aboutService.GetAll(i => i.AppUserID == user.Id),
                Educations = _educationService.GetAll(i => i.AppUserID == user.Id),
                Experience = _experienceService.GetAll(i => i.AppUserID == user.Id),
                Skills = _skillsService.GetAll(i => i.AppUserID == user.Id),


            };


          
   


  

            return View(model);
        }

        public IActionResult AllCv(string search, int page=1)
        {
            ViewBag.s = search;
            ViewBag.activepage = page;

            var user = _appUserService.AllCv(search, out int sumpage, page);

            ViewBag.sumpage = sumpage;

                

            return View(user);
        }

        public IActionResult CvDetails(int? id)
        {
           
            return View(_appUserService.CvDetails(id));
        }
    }
}
