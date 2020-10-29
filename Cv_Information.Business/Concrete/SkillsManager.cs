using Cv_Information.Business.Abstract;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cv_Information.Business.Concrete
{
    public class SkillsManager : ISkillsService
    {

        private ISkillsRepository _skillsRepository;

        public SkillsManager(ISkillsRepository skillsRepository)
        {
            _skillsRepository = skillsRepository;
        }

        public void Add(Skills entity)
        {
            _skillsRepository.Add(entity);
        }

        public void Delete(Skills entity)
        {
            throw new NotImplementedException();
        }

        public List<Skills> GetAll()
        {
            return _skillsRepository.GetAll();
        }

        public List<Skills> GetAll(Expression<Func<Skills, bool>> expression)
        {
            return _skillsRepository.GetAll(expression);
        }

        public Skills GetByid(int id)
        {
            return _skillsRepository.GetByid(id);
        }

        public Skills GetOne(Expression<Func<Skills, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Skills entity)
        {
            _skillsRepository.Update(entity);
        }
    }
}
