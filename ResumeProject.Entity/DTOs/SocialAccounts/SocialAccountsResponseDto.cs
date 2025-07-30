using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.SocialAccounts
{
    public sealed record SocialAccountsResponseDto(
        Guid Id,
        string Name,
        string WebUrl,
        string UserName,
        string Icon
    ) : IResponseDto;
}
