using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Entities.ORM.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Image { get; set; }

        public string Telephone { get; set; }

        public string Adress { get; set; }

        public List<Abouts> Abouts { get; set; }

        public List<Education> Educations { get; set; }

        public List<Experience> Experiences { get; set; }

        public List<Skills> Skills { get; set; }

    }
}
