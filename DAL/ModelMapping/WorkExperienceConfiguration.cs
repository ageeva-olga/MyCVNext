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
    public class WorkExperienceConfiguration : IEntityTypeConfiguration<WorkExperience>
    {
        public void Configure(EntityTypeBuilder<WorkExperience> builder)
        {
            builder.Property(x => x.Begin).IsRequired();
            builder.Property(x => x.End).IsRequired();
            builder.Property(x => x.WorkName).IsRequired();
            builder.Property(x => x.PositionName).IsRequired();

            builder
                .ToTable("WorksExperience")
                    .HasKey(x => x.Id);
            builder
                 .HasMany(p => p.Skills)
                 .WithOne(p => p.WorkExperience)
                 .HasForeignKey(x => x.WorkExperienceId);
        }
    }
}
