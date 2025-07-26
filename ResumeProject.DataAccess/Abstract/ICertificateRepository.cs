using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.DataAccess.Abstract
{
    public interface ICertificateRepository : IGenericRepository<Certificate>
    {
    }
}
