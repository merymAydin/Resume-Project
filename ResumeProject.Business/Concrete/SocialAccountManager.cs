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
using ResumeProject.Entity.DTOs.SocialAccounts;

namespace ResumeProject.Business.Concrete
{
    public sealed class SocialAccountManager: ISocialAccountService
    {
        private readonly ISocialAccountRepository _socialAccountRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public SocialAccountManager(ISocialAccountRepository socialAccountRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _socialAccountRepository = socialAccountRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<SocialAccountsResponseDto>> AddAsync(SocialAccountsCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SocialAccountsResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SocialAccountsResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SocialAccountsResponseDto>> GetSocialAccountByNameAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SocialAccountsResponseDto>>> GetSocialAccountsByUserNameAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(SocialAccountsUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
