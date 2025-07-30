using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using ResumeProject.Business.Abstract;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.Business.Concrete
{
    public sealed class InterestManager : IInterestService
    {
        private readonly IInterestRepository _interestRepository;
        public InterestManager(IInterestRepository interestRepository)
        {
            _interestRepository = interestRepository;
        }
        public async Task<IDataResult<Interest>> AddAsync(Interest entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Interest entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Interest>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Interest>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
