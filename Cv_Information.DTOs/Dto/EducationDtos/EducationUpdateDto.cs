using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.DTOs.Dto.EducationDtos
{
    public class EducationUpdateDto:BaseEntity
    {


        public string Title { get; set; }

        public string UnderTitle { get; set; }

        public string Description { get; set; }

        public int AppUserID { get; set; }
    }
}
