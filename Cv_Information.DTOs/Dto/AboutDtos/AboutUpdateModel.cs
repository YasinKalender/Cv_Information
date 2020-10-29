using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.DTOs.Dto.AboutDtos
{
    public class AboutUpdateModel:BaseEntity
    {
        public string About { get; set; }

    }
}
