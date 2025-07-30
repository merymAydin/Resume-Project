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
    public sealed class PersonalInfoManager : IPersonalInfoService
    {
        private readonly IPersonalInfoRepository _personalInfoRepository;
        public PersonalInfoManager(IPersonalInfoRepository personalInfoRepository)
        {
            _personalInfoRepository = personalInfoRepository;
        }
        public async Task<IDataResult<PersonalInfo>> AddAsync(PersonalInfo entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<PersonalInfo>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<PersonalInfo>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(PersonalInfo entity)
        {
            throw new NotImplementedException();
        }
    }
}
