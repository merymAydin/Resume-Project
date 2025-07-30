using Core.Entities;

namespace ResumeProject.Entity.DTOs.SocialAccounts;

public sealed class SocialAccountsCreateRequestDto(
    string Name,
    string WebUrl,
    string UserName,
    string Icon
) : ICreateDto;