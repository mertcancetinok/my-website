using myWebsite.business.Abstract;
using myWebsite.business.Utilities.Result;
using myWebsite.data.Abstract;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Concrete
{
    public class SocialManager : ISocialService
    {
        private readonly ISocialRepository _socialRepository;
        public SocialManager(ISocialRepository socialRepository)
        {
            _socialRepository = socialRepository;
        }
        public IResult Create(SocialMedia entity)
        {
            _socialRepository.Create(entity);
            return new SuccessResult();
        }

        public IResult Delete(SocialMedia entity)
        {
            _socialRepository.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<SocialMedia>> GetAll()
        {
            return new SuccessDataResult<List<SocialMedia>>(_socialRepository.GetAll());

        }

        public IResult Update(SocialMedia entity)
        {
            _socialRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
