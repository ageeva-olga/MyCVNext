using Logic.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var personalInfo = new PersonalInfo() {Name = "Olga", Surname = "Ageeva", Email = "olga@mail.ru", Phone = "+7568652563" };
            var educat = new Education() { Begin = 2017, End = 2021, SchoolName = "Lobachevski University", Id = Guid.NewGuid()};
            var workExp = new WorkExperience() { Id = Guid.NewGuid(), Begin = 2018, End = 2021, WorkName = "University", PositionName = "Student" };
            var skillCat = new SkillCategory() { Id = Guid.NewGuid(), Name = "Language"};
            var skill1 = new Skill() { Id = Guid.NewGuid(), Name = "C", WorkExperienceId = workExp.Id, SkillCategoryId = skillCat.Id};
            var skill2 = new Skill() { Id = Guid.NewGuid(), Name = "C++", WorkExperienceId = workExp.Id, SkillCategoryId = skillCat.Id};

            modelBuilder.Entity<PersonalInfo>().HasData(
                personalInfo
                );
            modelBuilder.Entity<Education>().HasData(
                educat
                );
            modelBuilder.Entity<WorkExperience>().HasData(
                workExp
                );
            modelBuilder.Entity<SkillCategory>().HasData(
                skillCat
                );
            modelBuilder.Entity<Skill>().HasData(
                skill1,
                skill2
                );
        }
    }
}
