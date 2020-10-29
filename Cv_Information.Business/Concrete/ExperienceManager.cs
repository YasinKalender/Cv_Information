using Cv_Information.Business.Abstract;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cv_Information.Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {

        private readonly IExperienceRepository _experienceRepository;

        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }
        public void Add(Experience entity)
        {
            _experienceRepository.Add(entity);
        }

        public void Delete(Experience entity)
        {
            throw new NotImplementedException();
        }

        public List<Experience> GetAll()
        {
            return _experienceRepository.GetAll();
        }

        public List<Experience> GetAll(Expression<Func<Experience, bool>> expression)
        {
            return _experienceRepository.GetAll(expression);
        }

        public Experience GetByid(int id)
        {
            return _experienceRepository.GetByid(id);
        }

        public Experience GetOne(Expression<Func<Experience, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Experience entity)
        {
             _experienceRepository.Update(entity);
        }
    }
}
