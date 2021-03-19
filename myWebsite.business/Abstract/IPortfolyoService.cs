using myWebsite.business.Utilities.Result;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Abstract
{
    public interface IPortfolyoService
    {
        IDataResult<List<Portfolyo>> GetAll();
        IResult Create(Portfolyo entity);
        IResult Update(Portfolyo entity);
        IResult Delete(Portfolyo entity);
    }
}
