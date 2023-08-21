using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.InterfaceUpdated;
using SkillCheck_BE_Entities_Audits.EntitiesUpdated;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.ImplementationUpdated
{
    public class AuditCheckRepository : GenericRepository<AuditCheck>, IAuditCheckRepository
    {
        private readonly SkillCheckDbContext _dbContext;
        public AuditCheckRepository(SkillCheckDbContext context) : base(context)
        {
            _dbContext = context;
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
