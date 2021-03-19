using myWebsite.business.Abstract;
using myWebsite.business.Utilities.Result;
using myWebsite.data.Abstract;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        public SkillManager(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        public IResult Create(Skill entity)
        {
            _skillRepository.Create(entity);
            return new SuccessResult();
        }

        public IResult Delete(Skill entity)
        {
            _skillRepository.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Skill>> GetAll()
        {
            return new SuccessDataResult<List<Skill>>(_skillRepository.GetAll());
        }

        public IResult Update(Skill entity)
        {
            _skillRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
