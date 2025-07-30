using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Education
{
    public sealed record EducationResponseDto(
        Guid Id,
        string School,
        string Section,
        string Department,
        decimal GPA,
        string Grade,
        DateTime StartDate,
        DateTime? EndDate
    ) : IResponseDto;

}
