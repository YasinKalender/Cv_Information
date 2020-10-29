using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_Information.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Information.UI.BaseController
{
    public class BaseIdentityController : Controller
    {
        protected readonly UserManager<AppUser> _userManager;
        

        public BaseIdentityController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }



        protected async Task<AppUser> SıgnIn()
        {

            return await _userManager.FindByNameAsync(User.Identity.Name);

        }

        protected async Task<int> UserId()
        {
            var user =  await _userManager.FindByNameAsync(User.Identity.Name);

            return user.Id;

        }
    }

}
