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
using ResumeProject.Entity.DTOs.Interest;

namespace ResumeProject.Business.Concrete
{
    public sealed class InterestManager : IInterestService
    {
        private readonly IInterestRepository _interestRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public InterestManager(IInterestRepository interestRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _interestRepository = interestRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<InterestResponseDto>> AddAsync(InterestCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<InterestResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<InterestResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(InterestUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
