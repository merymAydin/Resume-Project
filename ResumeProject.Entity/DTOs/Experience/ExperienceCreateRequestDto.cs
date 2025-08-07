using Core.Entities;

namespace ResumeProject.Entity.DTOs.Experience;

public sealed record ExperienceCreateRequestDto(
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
) : ICreateDto;