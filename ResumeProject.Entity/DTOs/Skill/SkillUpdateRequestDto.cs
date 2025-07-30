using Core.Entities;

namespace ResumeProject.Entity.DTOs.Skill;

public sealed class SkillUpdateRequestDto(
    Guid Id,
    string Title,
    string Icon,
    bool IsProgramLanguageAndTool,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;