using Logic.Contracts;
using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private string _conectionString = "";
        public EducationRepository(string connectionString)
        {
            _conectionString = connectionString;
        }
        public Education AddEducation(Education education)
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                db.Educations.AddRange(education);
                db.SaveChanges();
            }
            return education;
        }

        public void DeleteEducation(Guid id)
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                Education education = db.Educations.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Education> GetEducations()
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                return db.Educations.ToList();
            }
        }
    }
}
