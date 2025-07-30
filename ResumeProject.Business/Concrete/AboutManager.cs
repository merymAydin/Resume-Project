using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.Entity.Concrete;
using IAboutService = ResumeProject.Business.Abstract.IAboutService;

namespace ResumeProject.Business.Concrete
{
    public sealed class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public async Task<IDataResult<About>> AddAsync(About entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(About entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<About>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<About>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
