using myWebsite.business.Abstract;
using myWebsite.business.Utilities.Result;
using myWebsite.data.Abstract;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace myWebsite.business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IResult Create(User entity)
        {
            if (entity != null)
            {
                _userRepository.Create(entity);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult Delete(User entity)
        {
            if (entity != null)
            {
                _userRepository.Delete(entity);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userRepository.GetAll());
        }


        public IDataResult<User> GetUser()
        {
            return new SuccessDataResult<User>(_userRepository.GetUser());
        }

        public IDataResult<UserDetail> GetUserWithDetails()
        {
            return new SuccessDataResult<UserDetail>(_userRepository.GetUserWithDetails());
        }

        public IResult Update(User entity)
        {
            if (entity != null)
            {
                _userRepository.Update(entity);
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
