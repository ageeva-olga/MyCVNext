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
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder
               .ToTable("Skills")
                   .HasKey(x => x.Id);
            builder
                .HasOne(x => x.SkillCategory)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.SkillCategoryId);
            builder
               .HasOne(x => x.WorkExperience)
               .WithMany(x => x.Skills)
               .HasForeignKey(x => x.WorkExperienceId);
        }
    }
}
