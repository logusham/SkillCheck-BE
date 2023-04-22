using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Interface
{
    public interface ITechnologyService
    {
        Task<IEnumerable<TechnologyDto>> GetAllTechnologiesSevice();
        Task<IEnumerable<TechnologyDto>> GetAllTechnologiesByUserService(Guid userId);
    }
}
