using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Results;
using ResumeProject.Business.Abstract;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Certificate;

namespace ResumeProject.Business.Concrete
{
    public sealed class CertificateManager : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CertificateManager(ICertificateRepository certificateRepository,IMapper mapper,IUnitOfWork unitOfWork)
        {
            _certificateRepository=certificateRepository;
            _mapper = mapper;
            _unitOfWork=unitOfWork;
        }

        public async Task<IDataResult<CertificateResponseDto>> AddAsync(CertificateCreateRequestDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<CertificateResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetCertificatesByOrganizationAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(CertificateUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
