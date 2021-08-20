using DAL.ModelMapping;
using Logic.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CVDbContext : DbContext
    {
        public DbSet<Education> Educations { get; set; }
        public DbSet<PersonalInfo> PersonalsInfo { get; set; }
        public DbSet<SkillCategory> SkillsCategory { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<WorkExperience> WorksExperience { get; set; }
        private string _conectionString = "Server=.\\SQLEXPRESS;Database=courcedb;Trusted_Connection=True;";

        public CVDbContext()
        {
            Database.EnsureCreated();
        }
        public CVDbContext(string connectionString)
        {
            _conectionString = connectionString;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EducationConfiguration().Configure(modelBuilder.Entity<Education>());

            new PersonalInfoConfiguration().Configure(modelBuilder.Entity<PersonalInfo>());

            new SkillCategoryConfiguration().Configure(modelBuilder.Entity<SkillCategory>());

            new SkillConfiguration().Configure(modelBuilder.Entity<Skill>());

            new WorkExperienceConfiguration().Configure(modelBuilder.Entity<WorkExperience>());
            modelBuilder.Seed();
        }
    }
}
