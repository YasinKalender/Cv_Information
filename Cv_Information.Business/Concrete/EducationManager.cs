using Cv_Information.Business.Abstract;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cv_Information.Business.Concrete
{

    public class EducationManager : IEducationService
    {
        private IEducationRepository _educationRepository;

        public EducationManager(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }


        public void Add(Education entity)
        {
            _educationRepository.Add(entity);
        }

        public void Delete(Education entity)
        {
            throw new NotImplementedException();
        }

        public List<Education> GetAll()
        {
            return _educationRepository.GetAll();
        }

        public List<Education> GetAll(Expression<Func<Education, bool>> expression)
        {
            return _educationRepository.GetAll(expression);
        }

        public Education GetByid(int id)
        {
            return _educationRepository.GetByid(id);
        }

        public Education GetOne(Expression<Func<Education, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Education entity)
        {
            _educationRepository.Update(entity);
        }
    }
}
