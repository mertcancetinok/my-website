using System;
using System.Collections.Generic;
using System.Linq;
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
            using (var context = new TContext())
            {
               return context.Set<TEntity>().ToList();
            }
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