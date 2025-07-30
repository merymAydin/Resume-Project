using Core.Entities;

namespace ResumeProject.Entity.DTOs.PersonalInfo;

public sealed record PersonalInfoCreateRequestDto(
    string FirstName,
    string LastName,
    string ImageUrl,
    bool MaritalStatus,
    string Gender,
    string DrivingLicence,
    DateTime BirthDate,
    string BirthPlace,
    string Nationality
) : ICreateDto;