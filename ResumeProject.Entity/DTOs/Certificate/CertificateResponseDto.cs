using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Certificate
{
    public sealed record CertificateResponseDto(
        Guid Id,
        string Title,
        string Degree,
        string Organization,
        string Description,
        DateTime DateAt
        ) : IResponseDto;
}
