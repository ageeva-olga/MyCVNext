using Logic.Contracts;
using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PersonalInfoRepository : IPersonalInfoRepository
    {
        private string _conectionString = "";
        public PersonalInfoRepository(string connectionString)
        {
            _conectionString = connectionString;
        }
        public List<PersonalInfo> GetPersonalInfo()
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                return db.PersonalsInfo.ToList();
            }
        }

        public void SavePersonalInfo(PersonalInfo model)
        {
            using (CVDbContext db = new CVDbContext(_conectionString))
            {
                db.SaveChanges();
            }
        }
    }
}
