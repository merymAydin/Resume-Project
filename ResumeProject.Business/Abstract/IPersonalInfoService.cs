using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.PersonalInfo;

namespace ResumeProject.Business.Abstract
{
    public interface IPersonalInfoService : IGenericService<PersonalInfo,PersonalInfoResponseDto,PersonalInfoCreateRequestDto,PersonalInfoUpdateRequestDto,PersonalInfoDetailResponseDto>
    {
    }
}
