using myWebsite.business.Utilities.Result;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Abstract
{
    public interface IJobService
    {
        IDataResult<List<Job>> GetAll();
        IResult Create(Job entity);
        IResult Update(Job entity);
        IResult Delete(Job entity);
    }
}
