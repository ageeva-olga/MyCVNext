using Logic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModelMapping
{
    public class EducationConfiguration: IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.Property(x => x.Begin).IsRequired();
            builder.Property(x => x.End).IsRequired();
            builder.Property(x => x.SchoolName).IsRequired();

            builder
                .ToTable("Educations")
                    .HasKey(x => x.Id);
        }
    }
}
