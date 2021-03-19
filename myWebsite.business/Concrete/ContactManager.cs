using myWebsite.business.Abstract;
using myWebsite.business.Utilities.Result;
using myWebsite.data.Abstract;
using myWebsite.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Concrete
{
    public class ContactManager:IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IResult Create(Contact entity)
        {
            _contactRepository.Create(entity);
            return new SuccessResult();
        }

        public IResult Delete(Contact entity)
        {
            _contactRepository.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactRepository.GetAll());
        }

        public IResult Update(Contact entity)
        {
            _contactRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
