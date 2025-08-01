using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.About;

namespace ResumeProject.DataAccess.Abstract
{
    public interface IAboutService : IGenericService<About,AboutResponseDto,AboutCreateRequestDto,AboutUpdateRequestDto,AboutDetailResponseDto>
    {

    }
}
