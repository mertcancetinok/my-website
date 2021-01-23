using myWebsite.entity;

namespace myWebsite.data.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
        public User getUser();
        public UserDetail GetUserWithDetails();
    }
}