using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreContactRepository:EfCoreGenericRepository<Contact>,IContactRepository
    {
        public EfCoreContactRepository(ShopContext context) : base(context)
        {

        }

    }
}