using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.InterfaceUpdated;
using SkillCheck_BE_Entities_Audits.EntitiesUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.ImplementationUpdated
{
    public class TechnologyRepository : GenericRepository<Technology>, ITechnologyRepository
    {
        public TechnologyRepository(SkillCheckDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<Technology>> GetAllTechnologies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Technology>> GetAllTechnologyByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
