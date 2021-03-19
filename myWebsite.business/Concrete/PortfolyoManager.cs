using myWebsite.business.Abstract;
using myWebsite.business.Utilities.Result;
using myWebsite.data.Abstract;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Concrete
{
    public class PortfolyoManager:IPortfolyoService
    {
        private readonly IPortfolyoRepository _portfolyoRepository;
        public PortfolyoManager(IPortfolyoRepository portfolyoRepository)
        {
            _portfolyoRepository = portfolyoRepository;
        }
        public IResult Create(Portfolyo entity)
        {
            _portfolyoRepository.Create(entity);;
            return new SuccessResult();
        }

        public IResult Delete(Portfolyo entity)
        {
            _portfolyoRepository.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Portfolyo>> GetAll()
        {
            return new SuccessDataResult<List<Portfolyo>>(_portfolyoRepository.GetAll());
        }

        public IResult Update(Portfolyo entity)
        {
            _portfolyoRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
