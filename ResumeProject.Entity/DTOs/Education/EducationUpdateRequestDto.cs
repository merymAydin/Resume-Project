using Core.Entities;

namespace ResumeProject.Entity.DTOs.Education;

public sealed class EducationUpdateRequestDto(
    Guid id,
    string School,
    string Section,
    string Department,
    decimal GPA,
    string Grade,
    DateTime StartDate,
    DateTime? EndDate,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;