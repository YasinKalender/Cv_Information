using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.ExperienceDtos;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Controllers
{
    public class ExperienceController : BaseIdentityController
    {

        private readonly IExperienceService _experienceService;



        public ExperienceController(IExperienceService experienceService, UserManager<AppUser> userManager) : base(userManager)
        {
            _experienceService = experienceService;
        }


   
        public IActionResult ExperienceAdd()
        {


            return View();
        }

        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> ExperienceAdd(ExperienceAddDto model)
        {

            if (ModelState.IsValid)
            {
                _experienceService.Add(new Experience()
                {
                    Title = model.Title,
                    UnderTitle = model.UnderTitle,
                    Description = model.Description,
                    AppUserID = await UserId()


                });

                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }


            return View(model);
        }



        public IActionResult ExperienceUpdate(int id)
        {
            var experience = _experienceService.GetByid(id);

            ExperienceUpdateDto model = new ExperienceUpdateDto()
            {
                Title = experience.Title,
                UnderTitle = experience.UnderTitle,
                Description = experience.Description

            };

            return View(model);
        }


        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> ExperienceUpdate(ExperienceUpdateDto model)
        {

            if (ModelState.IsValid)
            {

                _experienceService.Update(new Experience()
                {
                    ID = model.ID,
                    Title = model.Title,
                    UnderTitle = model.UnderTitle,
                    Description = model.Description,
                    AppUserID = await UserId()


                });

                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            return View(model);
        }
    }
}
