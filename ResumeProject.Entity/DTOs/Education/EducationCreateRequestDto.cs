using Core.Entities;

namespace ResumeProject.Entity.DTOs.Education;

public sealed class EducationCreateRequestDto(
    string School,
    string Section,
    string Department,
    decimal GPA,
    string Grade,
    DateTime StartDate,
    DateTime? EndDate
) : ICreateDto;