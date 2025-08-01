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
using ResumeProject.Entity.DTOs.PersonalInfo;

namespace ResumeProject.Business.Concrete
{
    public sealed class PersonalInfoManager : IPersonalInfoService
    {
        private readonly IPersonalInfoRepository _personalInfoRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PersonalInfoManager(IPersonalInfoRepository personalInfoRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _personalInfoRepository = personalInfoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<PersonalInfoResponseDto>> AddAsync(PersonalInfoCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<PersonalInfoResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<PersonalInfoResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(PersonalInfoUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
