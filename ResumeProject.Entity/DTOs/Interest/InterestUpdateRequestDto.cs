using Core.Entities;

namespace ResumeProject.Entity.DTOs.Interest;

public sealed record InterestUpdateRequestDto(
    Guid Id,
    string Description,
    byte Order,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;