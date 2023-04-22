using SkillCheck_BE_DTOs_Audits.DtoUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_BusinessServices_Audits.Service.IntefaceUpdated
{
    public interface ITechnologyService
    {
        Task<IEnumerable<TechnologyDto>> GetAllTechnologies();
        Task<IEnumerable<TechnologyDto>> GetAllTechnologyByUserId(Guid userId);
    }
}
