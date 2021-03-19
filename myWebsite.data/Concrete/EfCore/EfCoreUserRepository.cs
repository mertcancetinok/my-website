using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreUserRepository:EfCoreGenericRepository<User>,IUserRepository
    {
        public EfCoreUserRepository(ShopContext context):base(context)
        {

        }
        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public User GetUser()
        {
            
                return ShopContext.Users.First();
            
        }

        public UserDetail GetUserWithDetails()
        {
           
                return ShopContext.UserDetails
                    .Include(i => i.User)
                    .FirstOrDefault();

           
        }
    }
}