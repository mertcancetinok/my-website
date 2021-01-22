using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using myWebsite.data.Abstract;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity,TContext>:IRepository<TEntity>
        where TEntity:class
        where TContext:DbContext,new()
    {
        public List<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Create(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}