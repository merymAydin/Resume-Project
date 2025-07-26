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
    public interface IContactService : IGenericService<Contact>
    {
        Task<IDataResult<IEnumerable<Contact>>> GetContactsListByCityAsync();
    }
}
