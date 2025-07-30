using Core.Entities;

namespace ResumeProject.Entity.DTOs.About;

public sealed record AboutUpdateRequestDto(
    Guid Id,
    string Description,
    byte Order,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;