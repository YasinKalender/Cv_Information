using Cv_Information.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv_Information.UI.ViewComponents
{
    public class Wrapper:ViewComponent
    {
        private UserManager<AppUser> _userManager;

        public Wrapper(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
           var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var roles = _userManager.GetRolesAsync(user).Result;

            if (roles.Contains("Admin"))
            {
                return View("Admin", user);
            }


            return View("Member",user);
        }


    }
}
