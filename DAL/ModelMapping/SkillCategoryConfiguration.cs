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
    public class SkillCategoryConfiguration : IEntityTypeConfiguration<SkillCategory>
    {
        public void Configure(EntityTypeBuilder<SkillCategory> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder
                .ToTable("SkillsCategory")
                    .HasKey(x => x.Id);
            builder
                 .HasMany(p => p.Skills)
                 .WithOne(p => p.SkillCategory)
                 .HasForeignKey(x => x.SkillCategoryId);
        }
    }
}
