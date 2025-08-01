using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Contact;

namespace ResumeProject.Business.Abstract
{
    public interface IContactService : IGenericService<Contact,ContactResponseDto,ContactCreateRequestDto,ContactUpdateRequestDto,ContactDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<ContactResponseDto>>> GetContactsListByCityAsync(string city);
    }
}
