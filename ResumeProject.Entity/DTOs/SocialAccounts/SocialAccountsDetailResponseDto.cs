using Core.Entities;

namespace ResumeProject.Entity.DTOs.SocialAccounts;

public sealed class SocialAccountsDetailResponseDto(
    Guid Id,
    string Name,
    string WebUrl,
    string UserName,
    string Icon,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;