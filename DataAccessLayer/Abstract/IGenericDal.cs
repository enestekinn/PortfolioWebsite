using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
        List<T> GetList();
        List<T> GetByFilter(Expression<Func<T, bool>> filter);

    }
}