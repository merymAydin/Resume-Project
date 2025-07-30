using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Skill
{
    public sealed class SkillResponseDto(
        Guid Id,
        string Title,
        string Icon,
        bool IsProgramLanguageAndTool
    ) : IResponseDto;
}
