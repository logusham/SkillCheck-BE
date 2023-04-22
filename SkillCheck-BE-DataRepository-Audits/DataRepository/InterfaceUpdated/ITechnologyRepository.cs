using SkillCheck_BE_Entities_Audits.EntitiesUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.InterfaceUpdated
{
    public interface ITechnologyRepository : IGenericRepository<Technology>
    {
        Task<IEnumerable<Technology>> GetAllTechnologies();
        Task<IEnumerable<Technology>> GetAllTechnologyByUserId(Guid userId);

    }
}
