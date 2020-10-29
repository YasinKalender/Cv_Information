using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.HomeDto;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Areas.Member.Controllers
{

    [Area("Member")]
    public class HomeController : BaseIdentityController
    {

        private IAboutService _aboutService;
        private IEducationService _educationService;
        private IExperienceService _experienceService;
        private ISkillsService _skillsService;

        public HomeController(IAboutService aboutService, IEducationService educationService, IExperienceService experienceService, ISkillsService skillsService, UserManager<AppUser> userManager):base(userManager)
        {
            _aboutService = aboutService;
            _educationService = educationService;
            _experienceService = experienceService;
            _skillsService = skillsService;
        }



        public async Task<IActionResult> Index()
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
    }
}
