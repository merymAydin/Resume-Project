using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.DataAccess.Contexts;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.DataAccess.Concrete.EntityFramework
{
    public class EfCertificateRepository : EfGenericRepository<Certificate,ResumeProjectDbContext>,ICertificateRepository
    {
        public EfCertificateRepository(ResumeProjectDbContext context) : base(context)
        {
        }
    }
}
