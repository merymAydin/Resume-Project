using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.Business.Abstract
{
    public interface ISocialAccountService : IGenericService<SocialAccount>
    {
        Task<IDataResult<SocialAccount>> GetSocialAccountByNameAsync();
        Task<IDataResult<IEnumerable<SocialAccount>>> GetSocialAccountsByUserNameAsync();
    }
}
