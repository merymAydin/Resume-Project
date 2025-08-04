﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Core.UnitOfWorks;
using ResumeProject.Business.Abstract;
using ResumeProject.Business.Concrete;
using ResumeProject.DataAccess.Abstract;
using ResumeProject.DataAccess.Concrete.EntityFramework;
using ResumeProject.DataAccess.UnitOfWork;
using IAboutService = ResumeProject.Business.Abstract.IAboutService;


namespace ResumeProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfAboutRepository>().As<IAboutRepository>();
            builder.RegisterType<AboutManager>().As<IAboutService>();
            builder.RegisterType<EfCertificateRepository>().As<ICertificateRepository>();
            builder.RegisterType<CertificateManager>().As<ICertificateService>();
            builder.RegisterType<EfContactRepository>().As<IContactRepository>();
            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfEducationRepository>().As<IEducationRepository>();
            builder.RegisterType<EducationManager>().As<IEducationService>();
            builder.RegisterType<EfExperienceRepository>().As<IExperienceRepository>();
            builder.RegisterType<ExperienceManager>().As<IExperienceService>();
            builder.RegisterType<EfInterestRepository>().As<IInterestRepository>();
            builder.RegisterType<InterestManager>().As<IInterestService>();
            builder.RegisterType<EfLanguageRepository>().As<ILanguageRepository>();
            builder.RegisterType<LanguageManager>().As<ILanguageService>();
            builder.RegisterType<EfPersonalInfoRepository>().As<IPersonalInfoRepository>();
            builder.RegisterType<PersonalInfoManager>().As<IPersonalInfoService>();
            builder.RegisterType<EfSkillRepository>().As<ISkillRepository>();
            builder.RegisterType<SkillManager>().As<ISkillService>();
            builder.RegisterType<EfSocialAccountRepository>().As<ISocialAccountRepository>();
            builder.RegisterType<SocialAccountManager>().As<ISocialAccountService>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
