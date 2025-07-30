using Core.Entities;

namespace ResumeProject.Entity.DTOs.About;

public sealed class AboutCreateRequestDto(
    string Description,
    byte Order
) : ICreateDto;