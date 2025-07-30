using Core.Entities;

namespace ResumeProject.Entity.DTOs.Contact;

public sealed record ContactCreateRequestDto(
    string Address,
    string City,
    string Town,
    string Phone,
    string Email
) : ICreateDto;