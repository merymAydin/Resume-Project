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
    public sealed class CertificateManager : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;

        public CertificateManager(ICertificateRepository certificateRepository)
        {
            _certificateRepository=certificateRepository;
        }
        public async Task<IDataResult<Certificate>> AddAsync(Certificate entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Certificate>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Certificate>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<Certificate>>> GetCertificatesByOrganizationAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Certificate entity)
        {
            throw new NotImplementedException();
        }
    }
}
