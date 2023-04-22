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
    public class AuditCheckRepository : GenericRepository<AuditCheck>, IAuditCheckRepository
    {
        public AuditCheckRepository(SkillCheckDb context) : base(context)
        {

        }

        public Task<IEnumerable<AuditCheck>> GetAllModuleByTechnologies(long technologyId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuditCheck>> GetAllUnitByModuleName(string moduleName)
        {
            throw new NotImplementedException();
        }
    }
}
