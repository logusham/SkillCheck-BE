using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SkillCheckDbContext _dbContext;

        public IAuditCheckRepository AuditCheck { get; }

        public IAuditRepository Audit { get; }

        public ITechnologyRepository Technology { get; }

        public UnitOfWork(
            SkillCheckDbContext dbContext,
            IAuditCheckRepository auditCheckRepo,
            IAuditRepository auditRepo,
            ITechnologyRepository technologyRepo
            )
        {
            _dbContext = dbContext;
            AuditCheck = auditCheckRepo;
            Audit = auditRepo;
            Technology = technologyRepo;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
