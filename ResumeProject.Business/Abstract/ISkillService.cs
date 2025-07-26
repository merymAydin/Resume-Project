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
    public interface ISkillService: IGenericService<Skill>
    {
        Task<IDataResult<IEnumerable<Skill>>> GetSkillsProgramLanguagesAsync(bool program);
        Task<IDataResult<IEnumerable<Skill>>> GetSkillsToolsAsync(bool tools);
    }
}
