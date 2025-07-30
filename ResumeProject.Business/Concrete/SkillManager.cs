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
    public sealed class SkillManager : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        public SkillManager(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public async Task<IDataResult<Skill>> AddAsync(Skill entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Skill>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Skill>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Skill>>> GetSkillsProgramLanguagesAsync(bool program)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Skill>>> GetSkillsToolsAsync(bool tools)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Skill entity)
        {
            throw new NotImplementedException();
        }
    }
}
