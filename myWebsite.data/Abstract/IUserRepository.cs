using myWebsite.entity;
using System.Threading.Tasks;

namespace myWebsite.data.Abstract
{
    public interface IUserRepository:IRepository<User>
    {
        User GetUser();
        UserDetail GetUserWithDetails();
    }
}