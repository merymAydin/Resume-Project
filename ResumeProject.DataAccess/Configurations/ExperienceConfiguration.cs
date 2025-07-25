﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResumeProject.Entity.Concrete;

namespace ResumeProject.DataAccess.Configurations
{
    internal class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.Property(e=>e.Title).HasMaxLength(100).IsRequired();
            builder.Property(e=>e.Company).HasMaxLength(100).IsRequired();
            builder.Property(e=>e.Description).HasMaxLength(500).IsRequired();
            builder.Property(e=>e.StartDate).IsRequired();
        }
    }
}
