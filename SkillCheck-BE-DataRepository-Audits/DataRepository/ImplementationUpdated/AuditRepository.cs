using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.InterfaceUpdated;
using SkillCheck_BE_Entities_Audits.EntitiesUpdated;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.ImplementationUpdated
{
    public class AuditRepository : GenericRepository<Audit>, IAuditRepository
    {
        public AuditRepository(SkillCheckDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddAudit(Audit audit)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAuditByAuditId(int auditId)
        {
            throw new NotImplementedException();
        }
    }
}
