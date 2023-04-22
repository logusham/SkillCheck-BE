using SkillCheck_BE_DTOs_Audits.AuditsDto;
using SkillCheck_BE_DTOs_Audits.AuditSumary;
using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Interface
{
    public interface IAuditCheckService
    {
        Task<IEnumerable<ModuleDto>> GetAllModuleByTechnologies(Guid userId, long technologyId);
        Task<IEnumerable<UnitDto>> GetAllUnitByTechnologies(Guid userId, long technologyId);
        Task<IEnumerable<UnitDto>> GetAllUnitByModules(Guid userId, long moduleId);
        Task<IEnumerable<UserAuditCheckDto>> GetAllUserAuditCheckByUnit(Guid userId, long unitId);
       Task<AuditSummaryDto> GetOverallSummary(Guid userId);


    }
}
