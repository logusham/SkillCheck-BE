using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Implementation
{
    public class TechnologyRepo : GenericRepository<Technology>, ITechnologyRepository
    {
        public TechnologyRepo(SkillCheckDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Return list of all active technologies.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Technology>> GetAllTechnologiesAsync()
        {
            return await _dbContext.Technologies.ToListAsync();
        }

        /// <summary>
        /// Return list of all active technologies for the user and the batch user belongs to.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Technology>> GetAllTechnologiesByUserAsync(Guid userId)
        {
            return await _dbContext.Batches.Where(x => x.Users.Any(u => u.UserID.Equals(userId)))
                .SelectMany(x => x.Technologies)
                .ToListAsync();
        }
    }
}
