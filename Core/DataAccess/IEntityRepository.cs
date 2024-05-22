using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint 
    //class referans tip olabilir.
    //IEntity: IEntity olabilir veya IEntity'den implemente eden bir nesne olabilir
    //new(): ne^w'lenebilir.
    public interface IEntityRepository<T> where T: class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
