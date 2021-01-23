using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using myWebsite.data.Abstract;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class EfCoreUserRepository:EfCoreGenericRepository<User,ShopContext>,IUserRepository
    {
        public User getUser()
        {
            using (var context = new ShopContext())
            {
                return context.Users.FirstOrDefault();
            }
        }

        public UserDetail GetUserWithDetails()
        {
            using (var context = new ShopContext())
            {
                return context.UserDetails
                    .Include(i=>i.User)
                    .FirstOrDefault();

            }
        }  
    }
}