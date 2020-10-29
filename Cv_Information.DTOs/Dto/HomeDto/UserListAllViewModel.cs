using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.DTOs.Dto.HomeDto
{
    public class UserListAllViewModel
    {
        public List<Abouts > About { get; set; }

        public List<Education> Educations { get; set; }

        public List<Experience> Experience { get; set; }

        public List<Skills> Skills { get; set; }

    }
}
