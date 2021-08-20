using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Domain
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SkillCategory SkillCategory;
        public Guid SkillCategoryId;
        public WorkExperience WorkExperience;
        public Guid WorkExperienceId;
    }
}
