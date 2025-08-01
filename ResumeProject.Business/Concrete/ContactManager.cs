using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Results;
using ResumeProject.Business.Abstract;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Contact;

namespace ResumeProject.Business.Concrete
{
    public sealed class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ContactManager(IContactRepository contactRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _contactRepository= contactRepository;
            _mapper= mapper;
            _unitOfWork= unitOfWork;
        }

        public async Task<IDataResult<ContactResponseDto>> AddAsync(ContactCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<ContactResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ContactResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<ContactResponseDto>>> GetContactsListByCityAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(ContactUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
