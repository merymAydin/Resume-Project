using Core.Entities;

namespace ResumeProject.Entity.DTOs.Language;

public sealed record LanguageCreateRequestDto(
    string Name,
    byte Level
) : ICreateDto;