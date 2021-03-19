using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreSocialRepository:EfCoreGenericRepository<SocialMedia>,ISocialRepository
    {
        public EfCoreSocialRepository(ShopContext context) : base(context)
        {

        }

    }
}