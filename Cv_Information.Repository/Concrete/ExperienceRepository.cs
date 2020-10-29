using Cv_Information.DAL.Context;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cv_Information.Repository.Concrete
{
    public class ExperienceRepository:BaseRepository<Experience>,IExperienceRepository
    {

        public ExperienceRepository(ProjectContext projectContext):base(projectContext)
        {

        }
    }
}
