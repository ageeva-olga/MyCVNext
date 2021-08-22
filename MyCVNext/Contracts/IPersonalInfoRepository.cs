using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IPersonalInfoRepository
    {
        PersonalInfo GetPersonalInfo();
        void SavePersonalInfo(PersonalInfo model);
    }
}
