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
    public sealed class ExperienceManager : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        public ExperienceManager(IExperienceRepository experienceRepository)
        {
           _experienceRepository = experienceRepository;
        }
        public async Task<IDataResult<Experience>> AddAsync(Experience entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Experience>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Experience>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Experience>>> GetExperienceByCompanyAsync(string company)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Experience entity)
        {
            throw new NotImplementedException();
        }
    }
}
