using Core.Entities;

namespace ResumeProject.Entity.DTOs.Education;

public sealed record EducationDetailResponseDto (
    Guid id,
    string School,
    string Section,
    string Department,
    decimal GPA,
    string Grade,
    DateTime StartDate,
    DateTime? EndDate
) : IDetailDto;