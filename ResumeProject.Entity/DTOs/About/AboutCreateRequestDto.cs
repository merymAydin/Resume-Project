using Core.Entities;

namespace ResumeProject.Entity.DTOs.About;

public sealed record AboutCreateRequestDto(
    string Description,
    byte Order
) : ICreateDto;