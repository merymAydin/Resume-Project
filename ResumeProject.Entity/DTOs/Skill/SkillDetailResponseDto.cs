﻿using Core.Entities;

namespace ResumeProject.Entity.DTOs.Skill;

public sealed record SkillDetailResponseDto(
    Guid Id,
    string Title,
    string Icon,
    bool IsProgramLanguageAndTool,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;