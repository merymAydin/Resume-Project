using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.Business.Abstract
{
    public interface IExperienceService : IGenericService<Experience>
    {
        Task<IDataResult<IEnumerable<Experience>>> GetExperienceByCompanyAsync(string company);
    }
}
