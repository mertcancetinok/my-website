using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myWebsite.data.Abstract;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity>:IRepository<TEntity>
        where TEntity:class
    {
        protected readonly DbContext context;
        public EfCoreGenericRepository(DbContext ctx)
        {
            context = ctx;
        }
        public List<TEntity> GetAll()
        {
            
                return context.Set<TEntity>().ToList();
            
        }

        public void Create(TEntity entity)
        {
           
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            
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