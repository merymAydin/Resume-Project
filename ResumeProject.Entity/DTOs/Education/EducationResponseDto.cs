using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace ResumeProject.Entity.DTOs.Education
{
    public sealed class EducationResponseDto(

    ) : IResponseDto;
    public sealed class EducationDetailResponseDto() : IDetailDto;
    public sealed class EducationCreateRequestDto() : ICreateDto;
    public sealed class EducationUpdateRequestDto() : IUpdateDto;
}
