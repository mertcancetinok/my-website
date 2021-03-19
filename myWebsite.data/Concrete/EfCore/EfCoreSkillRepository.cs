using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreSkillRepository:EfCoreGenericRepository<Skill>,ISkillRepository
    {
        public EfCoreSkillRepository(ShopContext context) : base(context)
        {

        }
    }
}