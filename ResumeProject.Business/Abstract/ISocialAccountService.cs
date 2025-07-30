using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.SocialAccounts;

namespace ResumeProject.Business.Abstract
{
    public interface ISocialAccountService : IGenericService<SocialAccount,SocialAccountsResponseDto,SocialAccountsCreateRequestDto,SocialAccountsUpdateRequestDto,SocialAccountsDetailResponseDto>
    {
        Task<IDataResult<SocialAccountsResponseDto>> GetSocialAccountByNameAsync();
        Task<IDataResult<IEnumerable<SocialAccountsResponseDto>>> GetSocialAccountsByUserNameAsync();
    }
}
