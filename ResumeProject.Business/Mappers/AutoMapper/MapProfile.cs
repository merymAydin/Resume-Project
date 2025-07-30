using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ResumeProject.Entity.Concrete;
using ResumeProject.Entity.DTOs.About;
using ResumeProject.Entity.DTOs.Certificate;
using ResumeProject.Entity.DTOs.Contact;
using ResumeProject.Entity.DTOs.Education;
using ResumeProject.Entity.DTOs.Experience;
using ResumeProject.Entity.DTOs.Interest;
using ResumeProject.Entity.DTOs.Language;
using ResumeProject.Entity.DTOs.PersonalInfo;
using ResumeProject.Entity.DTOs.Skill;
using ResumeProject.Entity.DTOs.SocialAccounts;

namespace ResumeProject.Business.Mappers.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<About, AboutResponseDto>();
            CreateMap<About, AboutDetailResponseDto>();
            CreateMap<AboutCreateRequestDto, About>();
            CreateMap<AboutUpdateRequestDto, About>();

            CreateMap<Certificate, CertificateResponseDto>();
            CreateMap<Certificate, CertificateDetailResponseDto>();
            CreateMap<CertificateCreateRequestDto, Certificate>();
            CreateMap<CertificateUpdateRequestDto, Certificate>();

            CreateMap<Contact,ContactResponseDto>();
            CreateMap<Contact, ContactDetailResponseDto>();
            CreateMap<ContactCreateRequestDto, Contact>();
            CreateMap<ContactUpdateRequestDto, Contact>();

            CreateMap<Education, EducationResponseDto>();
            CreateMap<Education, EducationDetailResponseDto>();
            CreateMap<EducationCreateRequestDto, Education>();
            CreateMap<EducationUpdateRequestDto, Education>();

            CreateMap<Experience,ExperienceResponseDto>();
            CreateMap<Experience, ExperienceDetailResponseDto>();
            CreateMap<ExperienceCreateRequestDto, Experience>();
            CreateMap<ExperienceUpdateRequestDto, Experience>();

            CreateMap<Interest, InterestResponseDto>();
            CreateMap<Interest, InterestDetailResponseDto>();
            CreateMap<InterestCreateRequestDto, Interest>();
            CreateMap<InterestUpdateRequestDto, Interest>();

            CreateMap<Language, LanguageResponseDto>();
            CreateMap<Language,LanguageDetailResponseDto>();
            CreateMap<LanguageCreateRequestDto, Language>();
            CreateMap<LanguageUpdateRequestDto, Language>();

            CreateMap<PersonalInfo, PersonalInfoResponseDto>();
            CreateMap<PersonalInfo, PersonalInfoDetailResponseDto>();
            CreateMap<PersonalInfoCreateRequestDto, PersonalInfo>();
            CreateMap<PersonalInfoUpdateRequestDto, PersonalInfo>();

            CreateMap<Skill, SkillResponseDto>();
            CreateMap<Skill, SkillDetailResponseDto>();
            CreateMap<SkillCreateRequestDto, Skill>();
            CreateMap<SkillUpdateRequestDto, Skill>();

            CreateMap<SocialAccount, SocialAccountsResponseDto>();
            CreateMap<SocialAccount, SocialAccountsDetailResponseDto>();
            CreateMap<SocialAccountsCreateRequestDto, SocialAccount>();
            CreateMap<SocialAccountsUpdateRequestDto, SocialAccount>();
        }
    }
}
