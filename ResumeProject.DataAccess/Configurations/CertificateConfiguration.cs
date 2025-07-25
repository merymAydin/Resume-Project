using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.DataAccess.Configurations
{
    internal class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Degree).HasMaxLength(30);
            builder.Property(c => c.Organization).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(500).IsRequired();
            builder.Property(c => c.DateAt).IsRequired();
        }
    }
}
