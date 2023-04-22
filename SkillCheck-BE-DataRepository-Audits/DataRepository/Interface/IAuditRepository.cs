using SkillCheck_BE_Entities_Audits.Entities.Audits;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Interface
{
    public interface IAuditRepository: IGenericRepository<Audit>
    {
        Task<IEnumerable<Audit>> GetAuditByTechnology(Guid userId, long technologyId);
        Task<IEnumerable<Audit>> GetAuditByAuditId(Guid id);

    }
}

