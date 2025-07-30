using Core.Entities;

namespace ResumeProject.Entity.DTOs.Certificate;

public sealed class CertificateDetailResponseDto(
    Guid Id,
    string Title,
    string Degree,
    string Organization,
    string Description,
    DateTime DateAt,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;