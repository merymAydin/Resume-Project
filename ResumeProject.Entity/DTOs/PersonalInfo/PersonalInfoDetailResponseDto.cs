using Core.Entities;

namespace ResumeProject.Entity.DTOs.PersonalInfo;

public sealed class PersonalInfoDetailResponseDto(
    Guid Id,
    string FirstName,
    string LastName,
    string ImageUrl,
    bool MaritalStatus,
    string Gender,
    string DrivingLicence,
    DateTime BirthDate,
    string BirthPlace,
    string Nationality,
    bool IsActive,
    bool IsDeleted
) : IDetailDto;