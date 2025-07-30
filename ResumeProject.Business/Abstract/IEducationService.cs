using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Education;

namespace ResumeProject.Business.Abstract
{
    public interface IEducationService : IGenericService<Education, EducationResponseDto, EducationCreateRequestDto, EducationUpdateRequestDto, EducationDetailResponseDto>
    {
        Task<IDataResult<EducationResponseDto>> GetEducationAsync(string grade);
        Task<IResult> AnyContinueAsync();
    }
}
