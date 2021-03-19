using myWebsite.business.Utilities.Result;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Abstract
{
    public interface ISkillService
    {
        IDataResult<List<Skill>> GetAll();
        IResult Create(Skill entity);
        IResult Update(Skill entity);
        IResult Delete(Skill entity);

    }
}
