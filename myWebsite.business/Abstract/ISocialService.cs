using myWebsite.business.Utilities.Result;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Abstract
{
    public interface ISocialService
    {
        IDataResult<List<SocialMedia>> GetAll();
        IResult Create(SocialMedia entity);
        IResult Update(SocialMedia entity);
        IResult Delete(SocialMedia entity);
    }
}
