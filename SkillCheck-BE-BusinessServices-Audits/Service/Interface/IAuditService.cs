using SkillCheck_BE_DTOs_Audits.AuditsDto;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Interface
{
    public interface IAuditService
    {
        Task CreateAuditAsync(AuditDto auditDto);
        Task<IEnumerable<AuditDto>> GetAuditByTechnology(Guid userId, long technologyId);
        Task<IEnumerable<AuditDto>> GetAuditByAuditId(Guid id);
        Task UpdateAuditAsync(AuditDto auditDto);
    }
}
