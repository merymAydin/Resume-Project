using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Business.Abstract;
using ResumeProject.Business.Constants;
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
            try
            {
                var interest = _mapper.Map<Interest>(dto);
                await _interestRepository.AddAsync(interest);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<InterestResponseDto>(interest);
                return new SuccessDataResult<InterestResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<InterestResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<InterestResponseDto>>> GetAllAsync()
        {
            try
            {
                var interests = await _interestRepository.GetAll(i => !i.isDeleted).ToListAsync();
                if (interests == null)
                {
                    return new ErrorDataResult<IEnumerable<InterestResponseDto>>(ResultMessages.ErrorListed);
                }

                var dtos = _mapper.Map<IEnumerable<InterestResponseDto>>(interests);
                return new SuccessDataResult<IEnumerable<InterestResponseDto>>(dtos,ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<InterestResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<InterestResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var interest = await _interestRepository.GetAsync(i => i.Id == id);
                if (interest == null)
                {
                    return new ErrorDataResult<InterestResponseDto>(ResultMessages.ErrorGet);
                }

                var response = _mapper.Map<InterestResponseDto>(interest);
                return new SuccessDataResult<InterestResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<InterestResponseDto>(e.Message);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var interest = await _interestRepository.GetAsync(i => i.Id == id);
                if (interest == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                interest.UpdateAt = DateTime.Now;
                interest.isDeleted = true;
                interest.isActive = false;
                _interestRepository.Update(interest);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(InterestUpdateRequestDto dto)
        {
            try
            {
                var interest = _mapper.Map<Interest>(dto);
                interest.UpdateAt = DateTime.Now;
                _interestRepository.Update(interest);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessUpdated);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
