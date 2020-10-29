using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.DTOs.Dto.AppUserDtos;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.UI.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Controllers
{
    public class ProfileController : BaseIdentityController
    {

        public ProfileController(UserManager<AppUser> userManager):base(userManager)
        {

        }

        public async Task<IActionResult> Index()
        {

            var user = await SıgnIn();

            return View(user);
        }

        public IActionResult UserUpdate(int id)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == id);

            AppUserUpdateDto model = new AppUserUpdateDto()
            {
                Id=user.Id,
                FirstName=user.FirstName,
                LastName=user.LastName,
                Adress=user.Adress,
                Email=user.Email,
                Username=user.UserName,
                Telephone=user.Telephone,
                Image=user.Image,


            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UserUpdate(AppUserUpdateDto model,IFormFile images)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == model.Id);

            if (ModelState.IsValid)
            {
                if (images != null)
                {
                    string path = Path.GetExtension(images.FileName);
                    string image = Guid.NewGuid() + path;
                    string pathimage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/image/" + image);

                   using(var stream = new FileStream(pathimage, FileMode.Create))
                    {

                        await images.CopyToAsync(stream);

                    }

                    user.Image = image;
                }


                user.Id = model.Id;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.Username;
                user.Email = model.Email;
                user.Adress = model.Adress;
                user.Telephone = model.Telephone;
            }

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }


            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }






            return View();
        }
    }
}
