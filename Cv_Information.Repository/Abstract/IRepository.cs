﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cv_Information.Repository.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        T GetOne(Expression<Func<T, bool>> expression);
        T GetByid(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);



    }
}
