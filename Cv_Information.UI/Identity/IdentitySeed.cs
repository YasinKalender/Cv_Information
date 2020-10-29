using Cv_Information.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv_Information.UI.Identity
{
    public static class IdentitySeed
    {
        public static async Task IdentityData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {


            var adminrole = await roleManager.FindByNameAsync("Admin");

            if (adminrole == null)
            {
                await roleManager.CreateAsync(new AppRole() {Name="Admin" });
            }

            var memberrole = await roleManager.FindByNameAsync("Member");

            if (memberrole==null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Member" });
            }

            var user = await userManager.FindByNameAsync("Yasin");

            if (user==null)
            {
                AppUser appUser = new AppUser()
                {
                    FirstName="Yasin",
                    LastName="Kalender",
                    UserName="Yasin",
                    Email="ysn@gmail.com"



                };

                await userManager.CreateAsync(appUser, "1");
                await userManager.AddToRoleAsync(appUser, "Admin");
              

            }



        }


    }
}
