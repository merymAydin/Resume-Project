using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeProject.Business.Abstract;
using ResumeProject.Entity.DTOs.Skill;

namespace ResumeProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(SkillCreateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid data");
            }

            var result = await _skillService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SkillUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Invalid data");
            }

            var result = await _skillService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _skillService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
