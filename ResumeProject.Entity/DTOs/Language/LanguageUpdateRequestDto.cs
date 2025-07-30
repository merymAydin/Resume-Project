using Core.Entities;

namespace ResumeProject.Entity.DTOs.Language;

public sealed record LanguageUpdateRequestDto(
    Guid Id,
    string Name,
    byte Level,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;