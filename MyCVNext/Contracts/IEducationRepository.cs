using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IEducationRepository
    {
        public List<Education> GetEducations();
        public Education AddEducation(Education education);
        public void DeleteEducation(Guid id);
    }
}
