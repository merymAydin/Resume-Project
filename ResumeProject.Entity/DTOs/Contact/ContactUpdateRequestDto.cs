using Core.Entities;

namespace ResumeProject.Entity.DTOs.Contact;

public sealed class ContactUpdateRequestDto(
    Guid Id,
    string Address,
    string City,
    string Town,
    string Phone,
    string Email,
    bool IsActive,
    bool IsDeleted
) : IUpdateDto;