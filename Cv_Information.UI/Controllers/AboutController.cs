using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.AboutDtos;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Controllers
{
    public class AboutController : BaseIdentityController
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService, UserManager<AppUser> userManager) : base(userManager)
        {
            _aboutService = aboutService;

        }



        public IActionResult AboutAdd()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AboutAdd(AboutAddViewModel model)
        {
            var user = await SıgnIn();


            if (ModelState.IsValid)
            {

                _aboutService.Add(new Entities.ORM.Concrete.Abouts()
                {
                    About = model.About,
                    AppUserID = user.Id



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

        public IActionResult AboutUpdate(int id)
        {
            var about = _aboutService.GetByid(id);

            AboutUpdateModel model = new AboutUpdateModel()
            {
                About = about.About,
                ID = about.ID,

            };

            return View(model);
        }


        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> AboutUpdate(AboutUpdateModel model)
        {
            var user = await SıgnIn();
            if (ModelState.IsValid)
            {
                _aboutService.Update(new Abouts()
                {
                    ID = model.ID,
                    About = model.About,
                    AppUserID = user.Id


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



    }
}

