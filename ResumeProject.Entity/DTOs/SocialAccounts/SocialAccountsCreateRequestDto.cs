using Core.Entities;

namespace ResumeProject.Entity.DTOs.SocialAccounts;

public sealed record SocialAccountsCreateRequestDto(
    string Name,
    string WebUrl,
    string UserName,
    string Icon
) : ICreateDto;