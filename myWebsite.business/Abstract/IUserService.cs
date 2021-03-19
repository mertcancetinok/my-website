using myWebsite.business.Utilities.Result;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace myWebsite.business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Create(User entity);
        IResult Update(User entity);
        IResult Delete(User entity);
        IDataResult<User> GetUser();
        IDataResult<UserDetail> GetUserWithDetails();
    }
}
