namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAuditCheckRepository AuditCheck { get; }

        IAuditRepository Audit { get; }

        ITechnologyRepository Technology { get; }

        void Save();
    }
}
