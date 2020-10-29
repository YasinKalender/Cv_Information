using Cv_Information.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Repository.Abstract
{
    public interface IAppUserRepository
    {
        List<AppUser> AllCv();

        List<AppUser> AllCv(string search,out int sumpage,int activepage);

        AppUser CvDetails(int? id);

    }
}
