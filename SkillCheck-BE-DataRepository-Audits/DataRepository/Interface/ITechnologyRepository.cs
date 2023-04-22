using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Interface
{
    public interface ITechnologyRepository: IGenericRepository<Technology>
    {
        Task<IEnumerable<Technology>> GetAllTechnologiesAsync();
        Task<IEnumerable<Technology>> GetAllTechnologiesByUserAsync(Guid userId);
    }
}
