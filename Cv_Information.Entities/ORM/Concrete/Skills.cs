using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Entities.ORM.Concrete
{
    public class Skills:BaseEntity
    {

        public string Skill { get; set; }

        public int AppUserID { get; set; }
    }
}
