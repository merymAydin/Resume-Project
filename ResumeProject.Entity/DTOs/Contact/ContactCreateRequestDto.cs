using Core.Entities;

namespace ResumeProject.Entity.DTOs.Contact;

public sealed class ContactCreateRequestDto(
    string Address,
    string City,
    string Town,
    string Phone,
    string Email
) : ICreateDto;