using System.Collections.Generic;

namespace myWebsite.data.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        

    }
}