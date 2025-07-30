using Core.Entities;

namespace ResumeProject.Entity.DTOs.Experience;

public sealed record ExperienceUpdateRequestDto(
    Guid Id,
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
) : IUpdateDto;