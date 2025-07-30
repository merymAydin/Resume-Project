using Core.Entities;

namespace ResumeProject.Entity.DTOs.Language;

public sealed class LanguageDetailResponseDto(
    Guid Id,
    string Name,
    byte Level,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;