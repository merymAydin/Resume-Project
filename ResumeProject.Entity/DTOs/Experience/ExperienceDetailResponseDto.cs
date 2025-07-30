using Core.Entities;

namespace ResumeProject.Entity.DTOs.Experience;

public sealed record ExperienceDetailResponseDto(
    Guid Id,
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
) : IDetailDto;