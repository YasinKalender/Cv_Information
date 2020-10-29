using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.Abstract
{
    public interface IAppUserService
    {

        List<AppUser> AllCv();

        List<AppUser> AllCv(string search, out int sumpage, int activepage=1);

        AppUser CvDetails(int? id);
    }
}
