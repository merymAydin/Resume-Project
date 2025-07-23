using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.DataAccess.Contexts
{
    public sealed class ResumeProjectDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Contact> Contacts {  get; set; }
        public DbSet<Education> Educations { get; set; }    
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialAccount> SocialAccounts { get; set; }

    }
}
