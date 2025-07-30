using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Language
{
    public sealed record LanguageResponseDto(
        Guid Id,
        string Name,
        byte Level
    ) : IResponseDto;
}
