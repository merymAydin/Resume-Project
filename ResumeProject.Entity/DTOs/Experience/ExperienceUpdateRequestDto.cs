using Core.Entities;

namespace ResumeProject.Entity.DTOs.Experience;

public sealed class ExperienceUpdateRequestDto(
    Guid Id,
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
) : IUpdateDto;