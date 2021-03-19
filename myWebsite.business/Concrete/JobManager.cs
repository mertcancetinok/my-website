using myWebsite.business.Abstract;
using myWebsite.business.Utilities.Result;
using myWebsite.data.Abstract;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Concrete
{
    public class JobManager:IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobManager(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public IResult Create(Job entity)
        {
            _jobRepository.Create(entity);
            return new SuccessResult();
        }

        public IResult Delete(Job entity)
        {
            _jobRepository.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Job>> GetAll()
        {
            return new SuccessDataResult<List<Job>>(_jobRepository.GetAll());
        }

        public IResult Update(Job entity)
        {
            _jobRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
