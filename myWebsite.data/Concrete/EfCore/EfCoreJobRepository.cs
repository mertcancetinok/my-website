using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreJobRepository:EfCoreGenericRepository<Job>,IJobRepository
    {
        public EfCoreJobRepository(ShopContext context) : base(context)
        {

        }
    }
}