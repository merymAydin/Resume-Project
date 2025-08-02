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
            try
            {
                var experience = _mapper.Map<Experience>(dto);
                await _experienceRepository.AddAsync(experience);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<ExperienceResponseDto>(experience);
                return new SuccessDataResult<ExperienceResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ExperienceResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetAllAsync()
        {
            try
            {
                var experiences = await _experienceRepository.GetAll(e=>!e.isDeleted).ToListAsync();
                if (experiences == null)
                {
                    return new ErrorDataResult<IEnumerable<ExperienceResponseDto>>(ResultMessages.ErrorListed);
                }

                var dtos = _mapper.Map<IEnumerable<ExperienceResponseDto>>(experiences);
                return new SuccessDataResult<IEnumerable<ExperienceResponseDto>>(dtos);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<ExperienceResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<ExperienceResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var experience = await _experienceRepository.GetAsync(e => e.Id == id);
                if (experience == null)
                {
                    return new ErrorDataResult<ExperienceResponseDto>(ResultMessages.ErrorGet);
                }

                var response = _mapper.Map<ExperienceResponseDto>(experience);
                return new SuccessDataResult<ExperienceResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ExperienceResponseDto>(e.Message);
            }
        }
        public async Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetExperienceByCompanyAsync(string company)
        {
            try
            {
                var experiences = await _experienceRepository.GetAll(e=>!e.isDeleted && e.Company==company).ToListAsync();
                if (experiences == null)
                {
                    return new ErrorDataResult<IEnumerable<ExperienceResponseDto>>(ResultMessages.ErrorListed);
                }

                var dtos = _mapper.Map<IEnumerable<ExperienceResponseDto>>(experiences);
                return new SuccessDataResult<IEnumerable<ExperienceResponseDto>>(dtos,ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<ExperienceResponseDto>>(e.Message);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var experience = await _experienceRepository.GetAsync(e => e.Id == id);
                if (experience == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                experience.UpdateAt= DateTime.Now;
                experience.isDeleted = true;
                experience.isActive = false;
                _experienceRepository.Update(experience);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessUpdated);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(ExperienceUpdateRequestDto dto)
        {
            try
            {
                var experience = _mapper.Map<Experience>(dto);
                experience.UpdateAt = DateTime.Now;
                _experienceRepository.Update(experience);
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
