using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using ResumeProject.Business.Abstract;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.Business.Concrete
{
    public sealed class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository= contactRepository;
        }
        public async Task<IDataResult<Contact>> AddAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Contact>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Contact>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Contact>>> GetContactsListByCityAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
