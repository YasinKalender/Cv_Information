using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cv_Information.DTOs.Dto.ExperienceDtos
{
    public class ExperienceAddDto:BaseEntity
    {

        public string Title { get; set; }
        public string UnderTitle { get; set; }
        public string Description { get; set; }

        public Task<int> AppUserID { get; set; }
    }
}
