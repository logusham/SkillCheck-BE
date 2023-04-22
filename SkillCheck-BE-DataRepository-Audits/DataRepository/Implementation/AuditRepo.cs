using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_Entities_Audits.Entities.Audits;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Implementation
{
    public class AuditRepo : GenericRepository<Audit>, IAuditRepository
    {
        public AuditRepo(SkillCheckDbContext context) : base(context)
        {
        }
       

        public async Task<IEnumerable<Audit>> GetAuditByAuditId(Guid userId)
        {
            return await _dbContext.Audits.Where(a => a.AuditID == userId).ToListAsync();
        }

      



        /// <summary>
        /// Return the Audit, UserAuditChecks that has been answered already by the user for a given technology.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="technologyId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Audit>> GetAuditByTechnology(Guid userId, long technologyId)
        {
            var audits = await _dbContext.Audits
                .Include(x => x.UserAuditChecks)
                .Where(x => x.ReviewForUserId.Equals(userId) && x.Technology.TechnologyId == technologyId)
                .ToListAsync();
            return audits;
        }

    
    }
}
