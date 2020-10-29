using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Business.Abstract;
using Cv_Information.DTOs.Dto.AppUserDtos;
using Cv_Information.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly INLog _nLog;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, INLog nLog)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _nLog = nLog;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(AppUserRegister model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Image=model.Email,
                    Adress=model.Adress,
                    Telephone=model.Telephone,
                    UserName=model.Username


                };

                var result =await _userManager.CreateAsync(appUser, model.Pass);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "Member");
                    return RedirectToAction("Login");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            

            return View(model);
        }




        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(AppUserSıgn model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                  

                    if (result.Succeeded)
                    {
                        var role = await _userManager.GetRolesAsync(user);

                        if (role.Contains("Admin"))
                        {

                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }

                        return RedirectToAction("Index", "Home", new { area = "Member" });

                    }

                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış");
                    }

                   


                }
            }


            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }

        public IActionResult StatusCode(int? code)
        {

            if (code==404)
            {
                ViewBag.code = code;
                ViewBag.mesaj = "Sayfa bulunamadı";
            }

            return View();
        }


        public IActionResult Error()
        {
            var exceptionHandlerPathFeature =HttpContext.Features.Get<IExceptionHandlerPathFeature>();
          

            _nLog.Log($"Hata yeri:{exceptionHandlerPathFeature.Path}, Hata mesajı:{exceptionHandlerPathFeature.Error.Message}");

            ViewBag.hata = exceptionHandlerPathFeature.Error.Message;
            ViewBag.path = exceptionHandlerPathFeature.Path;


            return View();        
        
        
        }

        public void Hata()
        {


            throw new Exception("Bu bir hata");
        }
    }

}
