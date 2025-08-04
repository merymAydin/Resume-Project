﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeProject.Business.Abstract;
using ResumeProject.Entity.DTOs.Contact;

namespace ResumeProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService= contactService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid data");
            }

            var result = await _contactService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ContactUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid data");
            }

            var result = await _contactService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _contactService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _contactService.GetAllAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _contactService.GetByIdAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("[action]/{city}")]
        public async Task<IActionResult> GetAllByCity(string city)
        {
            var result = await _contactService.GetContactsListByCityAsync(city);
            if (!result.Success)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Data);
        }
    }
}
