using Core.Entities;

namespace ResumeProject.Entity.DTOs.Certificate;

public sealed record CertificateCreateRequestDto(
    string Title,
    string Degree,
    string Organization,
    string Description,
    DateTime DateAt
) : ICreateDto;