using Cv_Information.Entities.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Entities.Abstract
{
    public interface ICore
    {
        int ID { get; set; }
        DateTime AddDate { get; set; }

        DateTime? DeleteDate { get; set; }

        DateTime? UpdateDate { get; set; }

        Status status { get; set; }
    }
}
