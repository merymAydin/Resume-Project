using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Interest
{
    public sealed record InterestResponseDto(
        Guid Id,
        string Description,
        byte Order
    ) : IResponseDto;
}
