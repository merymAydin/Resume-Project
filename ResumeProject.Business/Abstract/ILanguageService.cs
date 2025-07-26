using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.DataAccess;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.Business.Abstract
{
    public interface ILanguageService: IGenericService<Language>
    {
        Task<IDataResult<IEnumerable<Language>>> GetLanguagesGreaterLevelAsync(byte level);
    }
}
