using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Experience
{
    public sealed class ExperienceResponseDto(
        Guid Id,
        string Title,
        string Company,
        string Description,
        DateTime StartDate,
        DateTime? EndDate
    ) : IResponseDto;
}
