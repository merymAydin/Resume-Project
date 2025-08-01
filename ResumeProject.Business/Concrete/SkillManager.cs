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
using ResumeProject.Entity.DTOs.Skill;

namespace ResumeProject.Business.Concrete
{
    public sealed class SkillManager : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public SkillManager(ISkillRepository skillRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<SkillResponseDto>> AddAsync(SkillCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SkillResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SkillResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync(bool program)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsToolsAsync(bool tools)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(SkillUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
