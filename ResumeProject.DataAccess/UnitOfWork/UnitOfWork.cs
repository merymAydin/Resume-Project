using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.UnitOfWorks;
using ResumeProject.DataAccess.Contexts;

namespace ResumeProject.DataAccess.UnitOfWork
{
    public class UnitOfWork(ResumeProjectDbContext context) : IUnitOfWork
    {
        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
