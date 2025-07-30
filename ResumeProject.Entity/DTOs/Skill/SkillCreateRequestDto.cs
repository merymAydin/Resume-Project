using Core.Entities;

namespace ResumeProject.Entity.DTOs.Skill;

public sealed record SkillCreateRequestDto(
    string Title,
    string Icon,
    bool IsProgramLanguageAndTool
) : ICreateDto;