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
using ResumeProject.Entity.DTOs.SocialAccounts;

namespace ResumeProject.Business.Concrete
{
    public sealed class SocialAccountManager: ISocialAccountService
    {
        private readonly ISocialAccountRepository _socialAccountRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public SocialAccountManager(ISocialAccountRepository socialAccountRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _socialAccountRepository = socialAccountRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<SocialAccountsResponseDto>> AddAsync(SocialAccountsCreateRequestDto dto)
        {
            try
            {
                var social = _mapper.Map<SocialAccount>(dto);
                await _socialAccountRepository.AddAsync(social);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<SocialAccountsResponseDto>(social);
                return new SuccessDataResult<SocialAccountsResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<SocialAccountsResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<SocialAccountsResponseDto>>> GetAllAsync()
        {
            try
            {
                var socials = await _socialAccountRepository.GetAll(s => !s.isDeleted).ToListAsync();
                if (socials == null)
                {
                    return new ErrorDataResult<IEnumerable<SocialAccountsResponseDto>>(ResultMessages.ErrorListed);
                }

                var dtos = _mapper.Map<IEnumerable<SocialAccountsResponseDto>>(socials);
                return new SuccessDataResult<IEnumerable<SocialAccountsResponseDto>>(dtos,ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<SocialAccountsResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<SocialAccountsResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var social = await _socialAccountRepository.GetAsync(s => s.Id == id);
                if (social == null)
                {
                    return new ErrorDataResult<SocialAccountsResponseDto>(ResultMessages.ErrorListed);
                }

                var response = _mapper.Map<SocialAccountsResponseDto>(social);
                return new SuccessDataResult<SocialAccountsResponseDto>(response, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<SocialAccountsResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<SocialAccountsResponseDto>> GetSocialAccountByNameAsync(string platform)
        {
            try
            {
                var social = await _socialAccountRepository.GetAsync(s => s.Name == platform);
                if (social == null)
                {
                    return new ErrorDataResult<SocialAccountsResponseDto>(ResultMessages.ErrorGet);
                }

                var response = _mapper.Map<SocialAccountsResponseDto>(social);
                return new SuccessDataResult<SocialAccountsResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<SocialAccountsResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<SocialAccountsResponseDto>>> GetSocialAccountsByUserNameAsync(string username)
        {
            try
            {
                var socials = await _socialAccountRepository.GetAll(s => s.UserName == username).ToListAsync();
                if (socials == null)
                {
                    return new ErrorDataResult<IEnumerable<SocialAccountsResponseDto>>(ResultMessages.ErrorListed);
                }

                var response = _mapper.Map<IEnumerable<SocialAccountsResponseDto>>(socials);
                return new SuccessDataResult<IEnumerable<SocialAccountsResponseDto>>(response,
                    ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<SocialAccountsResponseDto>>(e.Message);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var social = await _socialAccountRepository.GetAsync(s=>s.Id == id);
                if (social == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                social.UpdateAt=DateTime.Now;
                social.isDeleted = true;
                social.isActive = false;
                _socialAccountRepository.Update(social);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(SocialAccountsUpdateRequestDto dto)
        {
            try
            {
                var social = _mapper.Map<SocialAccount>(dto);
                social.UpdateAt= DateTime.Now;
                _socialAccountRepository.Update(social);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessUpdated);
            }
            catch (Exception e)
            {
                return new SuccessResult(e.Message);
            }
        }
    }
}
