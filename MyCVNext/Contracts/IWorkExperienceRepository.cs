using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IWorkExperienceRepository
    {
        public List<WorkExperience> GetWorkExperience();
        public void DeleteWorkExperience(Guid id);
        public WorkExperience AddWorkExperience(WorkExperience workExperience);
        public void DeleteSkillExperience(Guid id);
    }
}
