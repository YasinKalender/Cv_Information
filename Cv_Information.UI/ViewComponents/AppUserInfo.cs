using Cv_Information.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv_Information.UI.ViewComponents
{
    public class AppUserInfo:ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public AppUserInfo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            return View(user);

        }

    }
}
