using SkillCheck_BE_Entities_Audits.Entities.Audits;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Interface
{
    public interface IAuditCheckRepository: IGenericRepository<AuditCheck>
    {
        Task<IEnumerable<Module>> GetAllModuleByTechnologies(Guid userId, long technologyId);
        Task<IEnumerable<Unit>> GetAllUnitByTechnologies(Guid userId, long technologyId);
        Task<IEnumerable<Unit>> GetAllUnitByModules(Guid userId, long moduleId);
        Task<IEnumerable<UserAuditCheck>> GetAllUserAuditCheckByUnit(Guid userId, long unitId);
        Task<int> GetQuestionCountByPriority(Guid userId, Priority priority);
        Task<int> GetUserQuestionCountByPriority(Guid userId, Priority priority);




    }
}
