using SkillCheck_BE_BusinessServices_Audits.Service.IntefaceUpdated;
using SkillCheck_BE_DTOs_Audits.DtoUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_BusinessServices_Audits.Service.ImplementaionUpdated
{
    public class TechnologyService : ITechnologyService
    {
        public Task<IEnumerable<TechnologyDto>> GetAllTechnologies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TechnologyDto>> GetAllTechnologyByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
