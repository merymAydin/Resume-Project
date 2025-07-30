using Core.Entities;

namespace ResumeProject.Entity.DTOs.Interest;

public sealed record InterestDetailResponseDto(
    Guid Id,
    string Description,
    byte Order,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;