using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.SkillsDto;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Controllers
{
    public class SkillController : BaseIdentityController
    {
        private ISkillsService _skillsService;

        public SkillController(ISkillsService skillsService, UserManager<AppUser> userManager) : base(userManager)
        {
            _skillsService = skillsService;
        }

     
        public IActionResult SkillAdd()
        {
            return View();
        }


        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> SkillAdd(SkillAddUpdateDto model)
        {

            var user = await SıgnIn();

            if (ModelState.IsValid)
            {

                _skillsService.Add(new Skills()
                {

                    Skill = model.Skill,
                    AppUserID = await UserId()

                });

                var role = await _userManager.GetRolesAsync(user);

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

        public IActionResult SkillUpdate(int id)
        {
            var skill = _skillsService.GetByid(id);

            SkillAddUpdateDto model = new SkillAddUpdateDto()
            {
                ID = skill.ID,
                Skill = skill.Skill



            };

            return View(model);
        }


        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> SkillUpdate(SkillAddUpdateDto model)
        {
            var user = await SıgnIn();

            if (ModelState.IsValid)
            {
                _skillsService.Update(new Skills()
                {

                    ID = model.ID,
                    Skill = model.Skill,
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
    }

}
