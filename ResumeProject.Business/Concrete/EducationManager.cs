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
    public sealed class EducationManager : IEducationService
    {
        private readonly IEducationRepository _educationRepository;

        public EducationManager(IEducationRepository educationRepository)
        {
            _educationRepository= educationRepository;
        }
        public async Task<IDataResult<Education>> AddAsync(Education entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> AnyContinueAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Education>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Education>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Education>> GetEducationAsync(string grade)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Education entity)
        {
            throw new NotImplementedException();
        }
    }
}
