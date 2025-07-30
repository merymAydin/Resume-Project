using Core.Entities;

namespace ResumeProject.Entity.DTOs.Skill;

public sealed class SkillCreateRequestDto(
    string Title,
    string Icon,
    bool IsProgramLanguageAndTool
) : ICreateDto;