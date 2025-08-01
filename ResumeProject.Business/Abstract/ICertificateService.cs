using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using Core.Utilities.Results;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.Certificate;

namespace ResumeProject.Business.Abstract
{
    public interface ICertificateService:IGenericService<Certificate,CertificateResponseDto,CertificateCreateRequestDto,CertificateUpdateRequestDto,CertificateDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetCertificatesByOrganizationAsync(string organization);
    }
}
