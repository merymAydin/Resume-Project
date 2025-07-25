using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.DataAccess.Contexts
{
    public sealed class ResumeProjectDbContext(DbContextOptions<ResumeProjectDbContext>options) : DbContext(options)
    {
        //public ResumeProjectDbContext(DbContextOptions<ResumeProjectDbContext> options) : base(options)
        //{
            
        //}

        //burada modelBuilder ile yaptığımız konfigürasyonları Configuration klasöründeki ilgili classlar yardımızya yaptık.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Education>().Property(e => e.School).HasMaxLength(100);
        //    base.OnModelCreating(modelBuilder);
        //}


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //IEntityTypeConfiguration<T> interface ini implement eden classları çağrıyoruz
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

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
