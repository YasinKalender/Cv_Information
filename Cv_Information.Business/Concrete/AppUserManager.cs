using Cv_Information.Business.Abstract;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {

        private IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
        public List<AppUser> AllCv()
        {
            return _appUserRepository.AllCv();
        }

        public List<AppUser> AllCv( string search, out int sumpage, int activepage)
        {
            return _appUserRepository.AllCv(search, out sumpage,activepage);
        }

        public AppUser CvDetails(int? id)
        {
            return _appUserRepository.CvDetails(id);
        }
    }
}
