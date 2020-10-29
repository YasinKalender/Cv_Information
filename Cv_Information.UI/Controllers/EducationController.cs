using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.EducationDtos;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Controllers
{
    public class EducationController : BaseIdentityController
    {
        private IEducationService _educationService;

        public EducationController(IEducationService educationService, UserManager<AppUser> userManager) : base(userManager)
        {
            _educationService = educationService;
        }


      

        public IActionResult EducationAdd()
        {

            return View();
        }


        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> EducationAdd(EducationDto model)
        {

            var user = await SıgnIn();

            if (ModelState.IsValid)
            {
                _educationService.Add(new Education()
                {
                    Title = model.Title,
                    UnderTitle = model.UnderTitle,
                    Description = model.Description,
                    AppUserID = await UserId()



                });

                var role =await _userManager.GetRolesAsync(user);

                if (role.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }

                else
                {
                    return RedirectToAction("Index", "Home", new { area = "Member" });
                }
            }

            return View(model);
        }

        public IActionResult EducationUpdate(int id)
        {
            var education = _educationService.GetByid(id);

            EducationUpdateDto model = new EducationUpdateDto()
            {
                Title = education.Title,
                UnderTitle = education.UnderTitle,
                Description = education.Description

            };

            return View(model);
        }


        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> EducationUpdate(EducationUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _educationService.Update(new Education()
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
