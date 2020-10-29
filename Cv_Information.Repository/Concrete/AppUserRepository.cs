using Cv_Information.DAL.Context;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cv_Information.Repository.Concrete
{
    public class AppUserRepository : IAppUserRepository
    {

        private ProjectContext _projectContext;

        public AppUserRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        //Select FirstName, LastName, Email, Telephone, About from AspNetUsers join About on AspNetUsers.Id=About.AppUserID
        public List<AppUser> AllCv()
        {
            return _projectContext.Users.Include(i => i.Abouts).ToList();
        }

        public List<AppUser> AllCv(string search, out int sumpage, int activepage=1)
        {
            var user = _projectContext.Users.Include(i => i.Abouts).AsQueryable();

            sumpage = (int)Math.Ceiling((double)user.Count() / 3);

            if (!string.IsNullOrWhiteSpace(search))
            {
                user = user.Where(i => i.FirstName.Contains(search) || i.LastName.Contains(search));
                sumpage = (int)Math.Ceiling((double)user.Count() / 3);

            }

            user = user.Skip((activepage - 1) * 3).Take(3);

            return user.ToList();
        }

        public AppUser CvDetails(int? id)
        {
            return _projectContext.Users.Include(i => i.Abouts).Include(i => i.Educations).Include(i => i.Educations).Include(i => i.Experiences).Include(i => i.Skills).FirstOrDefault(i => i.Id == id);
        }
    }
}
