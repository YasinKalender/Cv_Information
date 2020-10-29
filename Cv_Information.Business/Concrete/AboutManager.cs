using Cv_Information.Business.Abstract;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cv_Information.Business.Concrete
{
    public class AboutManager : IAboutService
    {

        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public void Add(Abouts entity)
        {
            _aboutRepository.Add(entity);
        }

        public void Delete(Abouts entity)
        {
            throw new NotImplementedException();
        }

        public List<Abouts> GetAll()
        {
            return _aboutRepository.GetAll();
        }

        public List<Abouts> GetAll(Expression<Func<Abouts, bool>> expression)
        {
            return _aboutRepository.GetAll(expression);
        }

        public Abouts GetByid(int id)
        {
            return _aboutRepository.GetByid(id);
        }

        public Abouts GetOne(Expression<Func<Abouts, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Abouts entity)
        {
            _aboutRepository.Update(entity);
        }
    }
}
