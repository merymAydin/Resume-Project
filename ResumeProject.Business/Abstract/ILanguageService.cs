using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.DataAccess;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Language;

namespace ResumeProject.Business.Abstract
{
    public interface ILanguageService: IGenericService<Language,LanguageResponseDto,LanguageCreateRequestDto,LanguageUpdateRequestDto,LanguageDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<LanguageResponseDto>>> GetLanguagesGreaterLevelAsync(byte level);
    }
}
