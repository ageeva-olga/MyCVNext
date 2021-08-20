using Logic.Contracts;
using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        private string _conectionString = "";
        public WorkExperienceRepository(string connectionString)
        {
            _conectionString = connectionString;
        }
        public WorkExperience AddWorkExperience(WorkExperience workExperience)
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                db.WorksExperience.AddRange(workExperience);
                db.SaveChanges();
            }
            return workExperience;
        }

        public void DeleteSkillExperience(Guid id)
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                Skill skill = db.Skills.FirstOrDefault(x => x.Id == id);
            }
        }

        public void DeleteWorkExperience(Guid id)
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                WorkExperience workExperience = db.WorksExperience.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<WorkExperience> GetWorkExperience()
        {
            throw new NotImplementedException();
        }
    }
}
