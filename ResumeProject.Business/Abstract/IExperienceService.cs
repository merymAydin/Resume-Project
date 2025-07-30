using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Experience;

namespace ResumeProject.Business.Abstract
{
    public interface IExperienceService : IGenericService<Experience, ExperienceResponseDto,ExperienceCreateRequestDto,ExperienceUpdateRequestDto,ExperienceDetailResponseDto >
    {
        Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetExperienceByCompanyAsync(string company);
    }
}
