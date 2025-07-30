using Core.Entities;

namespace ResumeProject.Entity.DTOs.About;

public sealed class AboutDetailResponseDto(
    Guid Id,
    string Description,
    byte Order,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;