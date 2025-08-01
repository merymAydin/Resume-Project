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
using ResumeProject.Entity.DTOs.Education;

namespace ResumeProject.Business.Concrete
{
    public sealed class EducationManager : IEducationService
    {
        private readonly IEducationRepository _educationRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public EducationManager(IEducationRepository educationRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _educationRepository= educationRepository;
            _mapper= mapper;
            _unitOfWork= unitOfWork;
        }

        public async Task<IDataResult<EducationResponseDto>> AddAsync(EducationCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> AnyContinueAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<EducationResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<EducationResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<EducationResponseDto>> GetEducationAsync(string grade)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(EducationUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
