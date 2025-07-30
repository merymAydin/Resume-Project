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
    public sealed class SocialAccountManager: ISocialAccountService
    {
        private readonly ISocialAccountRepository _socialAccountRepository;
        public SocialAccountManager(ISocialAccountRepository socialAccountRepository)
        {
            _socialAccountRepository = socialAccountRepository;
        }

        public async Task<IDataResult<SocialAccount>> AddAsync(SocialAccount entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SocialAccount>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SocialAccount>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SocialAccount>> GetSocialAccountByNameAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SocialAccount>>> GetSocialAccountsByUserNameAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(SocialAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
