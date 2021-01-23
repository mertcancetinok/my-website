using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreJobRepository:EfCoreGenericRepository<Job,ShopContext>,IJobRepository
    {
        
    }
}