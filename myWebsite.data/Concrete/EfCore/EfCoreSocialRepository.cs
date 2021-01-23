using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreSocialRepository:EfCoreGenericRepository<SocialMedia,ShopContext>,ISocialRepository
    {
        
    }
}