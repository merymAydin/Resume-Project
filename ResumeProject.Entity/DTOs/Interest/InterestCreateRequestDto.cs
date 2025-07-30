using Core.Entities;

namespace ResumeProject.Entity.DTOs.Interest;

public sealed class InterestCreateRequestDto(
    string Description,
    byte Order
) : ICreateDto;