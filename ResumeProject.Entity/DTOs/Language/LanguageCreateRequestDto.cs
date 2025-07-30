using Core.Entities;

namespace ResumeProject.Entity.DTOs.Language;

public sealed class LanguageCreateRequestDto(
    string Name,
    byte Level
) : ICreateDto;