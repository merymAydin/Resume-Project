using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Interest;

namespace ResumeProject.Business.Abstract
{
    public interface IInterestService : IGenericService<Interest,InterestResponseDto, InterestCreateRequestDto,InterestUpdateRequestDto,InterestDetailResponseDto>
    {
    }
}