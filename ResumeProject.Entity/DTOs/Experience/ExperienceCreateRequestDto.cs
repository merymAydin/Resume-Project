using Core.Entities;

namespace ResumeProject.Entity.DTOs.Experience;

public sealed class ExperienceCreateRequestDto(
    string Title,
    string Company,
    string Description,
    DateTime StartDate,
    DateTime? EndDate
) : ICreateDto;