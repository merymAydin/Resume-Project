using Core.Entities;

namespace ResumeProject.Entity.DTOs.Interest;

public sealed record InterestCreateRequestDto(
    string Description,
    byte Order
) : ICreateDto;