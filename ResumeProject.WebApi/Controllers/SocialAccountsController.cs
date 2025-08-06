﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeProject.Business.Abstract;
using ResumeProject.Entity.DTOs.SocialAccounts;

namespace ResumeProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialAccountsController : ControllerBase
    {
        private readonly ISocialAccountService _socialAccountService;

        public SocialAccountsController(ISocialAccountService socialAccountService)
        {
            _socialAccountService = socialAccountService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(SocialAccountsCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid data");
            }

            var result = await _socialAccountService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(SocialAccountsUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid data");
            }
            var result = await _socialAccountService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _socialAccountService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _socialAccountService.GetAllAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _socialAccountService.GetByIdAsync(id);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{platform}")]
        public async Task<IActionResult> GetBySocialPlatform(string platform)
        {
            var result = await _socialAccountService.GetSocialAccountByNameAsync(platform);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{username}")]
        public async Task<IActionResult> GetAllByUsername(string username)
        {
            var result = await _socialAccountService.GetSocialAccountByNameAsync(username);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }
    }
}
