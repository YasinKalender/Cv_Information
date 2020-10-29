using Cv_Information.Entities.Abstract;
using Cv_Information.Entities.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Entities.ORM.Concrete
{
    public class BaseEntity : ICore
    {
        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        private Status _status;
        public Status status { get { return _status; } set { _status = value; } }
}
}
