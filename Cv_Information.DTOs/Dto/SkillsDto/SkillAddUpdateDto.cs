using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.DTOs.Dto.SkillsDto
{
    public class SkillAddUpdateDto:BaseEntity
    {

        public string Skill { get; set; }

        public int AppUserID { get; set; }
    }
}
