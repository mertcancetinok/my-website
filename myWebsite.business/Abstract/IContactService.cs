using myWebsite.business.Utilities.Result;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IResult Create(Contact entity);
        IResult Update(Contact entity);
        IResult Delete(Contact entity);
    }
}
