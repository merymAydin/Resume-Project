using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Skill;

namespace ResumeProject.Business.Abstract
{
    public interface ISkillService: IGenericService<Skill,SkillResponseDto,SkillCreateRequestDto,SkillUpdateRequestDto,SkillDetailResponseDto >
    {
        Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync();
        Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsToolsAsync(bool tools);
    }
}
