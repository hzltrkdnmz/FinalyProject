using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class:referans tipi
    //IEntity:IEntity olabilir veya IEntity implemete eden bir nesne olabilir.
    //IEntity newlenemez soyutlanan IEntityi devre dişi bırakmak için yaotık
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

  
    }
}
