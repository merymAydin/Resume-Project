﻿using Core.Entities;

namespace ResumeProject.Entity.DTOs.Skill;

public sealed record SkillUpdateRequestDto(
    Guid Id,
    string Title,
    string Icon,
    bool IsProgramLanguageAndTool,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;