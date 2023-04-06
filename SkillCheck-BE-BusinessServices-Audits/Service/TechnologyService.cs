using Master;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_BusinessServices_Audits.Service
{
    public class TechnologyService : ITechnologyService
    {
        public IEnumerable<Technology> GetTechnologies(Guid UserId)
        {
            throw new NotImplementedException();
        }

        public Technology GetTechnology(Guid BatchId, Guid UserId)
        {
            throw new NotImplementedException();
        }
    }
}
