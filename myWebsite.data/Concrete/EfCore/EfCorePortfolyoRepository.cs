using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCorePortfolyoRepository:EfCoreGenericRepository<Portfolyo>,IPortfolyoRepository
    {
        public EfCorePortfolyoRepository(ShopContext context) : base(context)
        {

        }
    }
}