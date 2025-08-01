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
using ResumeProject.Entity.DTOs.Experience;

namespace ResumeProject.Business.Concrete
{
    public sealed class ExperienceManager : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ExperienceManager(IExperienceRepository experienceRepository,IMapper mapper, IUnitOfWork unitOfWork)
        {
           _experienceRepository = experienceRepository;
           _mapper = mapper;
           _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<ExperienceResponseDto>> AddAsync(ExperienceCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ExperienceResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetExperienceByCompanyAsync(string company)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(ExperienceUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
