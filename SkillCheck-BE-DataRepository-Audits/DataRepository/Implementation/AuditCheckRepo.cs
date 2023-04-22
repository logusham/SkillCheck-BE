using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_Entities_Audits.Entities.Audits;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Implementation
{
    public class AuditCheckRepo : GenericRepository<AuditCheck>, IAuditCheckRepository
    {
        public AuditCheckRepo(SkillCheckDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Return the list of modules with the count of how many have been answered which will help UI indicate Red, Amber, Green.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="technologyId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Module>> GetAllModuleByTechnologies(Guid userId, long technologyId)
        {
            var auditChecks = await _dbContext.Audits
                .Where(x => x.ReviewForUserId.Equals(userId) && x.Technology.TechnologyId == technologyId)
                .SelectMany(x => x.UserAuditChecks.Select(y => y.AuditCheck))
                .ToListAsync();

            var auditCheckIds = auditChecks.Select(x => x.AuditCheckID);

            await _dbContext.AuditChecks.Where(x => auditCheckIds.Contains(x.AuditCheckID))
                .Include(x => x.CheckQuestion)
                .LoadAsync();

            var topicIds = auditChecks.Select(x => x.CheckQuestion).Select(cq => cq.TopicId).ToList();

            var modules = await _dbContext.Modules
                .Where(x => x.Units.Any(u => u.Topics.Any(t => topicIds.Contains(t.TopicID))))
                .ToListAsync();

            return modules;
        }

        /// <summary>
        /// Return the list of units for a given module with the count of how many have been answered which will help UI indicate Red, Amber, Green.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Unit>> GetAllUnitByModules(Guid userId, long moduleId)
        {
            var auditChecks = await _dbContext.Audits
                .Where(x => x.ReviewForUserId.Equals(userId))
                .SelectMany(x => x.UserAuditChecks.Select(y => y.AuditCheck))
                .ToListAsync();

            var auditCheckIds = auditChecks.Select(x => x.AuditCheckID);

            await _dbContext.AuditChecks.Where(x => auditCheckIds.Contains(x.AuditCheckID))
                .Include(x => x.CheckQuestion)
                .LoadAsync();

            var topicIds = auditChecks.Select(x => x.CheckQuestion).Select(cq => cq.TopicId).ToList();

            var units = await _dbContext.Modules
                .Where(x => x.ModuleID == moduleId)
                .SelectMany(x => x.Units.Where(x => x.Topics.Any(t => topicIds.Contains(t.TopicID))))
                .ToListAsync();

            return units;
        }

        /// <summary>
        /// Return the list of units with the count of how many have been answered which will help UI indicate Red, Amber, Green
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="technologyId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Unit>> GetAllUnitByTechnologies(Guid userId, long technologyId)
        {
            var auditChecks = await _dbContext.Audits
                .Where(x => x.ReviewForUserId.Equals(userId) && x.Technology.TechnologyId == technologyId)
                .SelectMany(x => x.UserAuditChecks.Select(y => y.AuditCheck))
                .ToListAsync();

            var auditCheckIds = auditChecks.Select(x => x.AuditCheckID);

            await _dbContext.AuditChecks.Where(x => auditCheckIds.Contains(x.AuditCheckID))
                .Include(x => x.CheckQuestion)
                .LoadAsync();

            var topicIds = auditChecks.Select(x => x.CheckQuestion).Select(cq => cq.TopicId).ToList();

            var units = await _dbContext.Units
                .Where(u => u.Topics.Any(t => topicIds.Contains(t.TopicID)))
                .ToListAsync();

            return units;
        }

        /// <summary>
        /// Return the list of user audit check dto for a given unit and the responses given by the user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<UserAuditCheck>> GetAllUserAuditCheckByUnit(Guid userId, long unitId)
        {
            var topicIds = await _dbContext.Units
                .Where(x => x.UnitId == unitId)
                .SelectMany(x => x.Topics.Select(t => t.TopicID)).ToListAsync();

            var userAuditChecks = await _dbContext.Audits
                .Where(x => x.ReviewForUserId.Equals(topicIds))
                .SelectMany(x => x.UserAuditChecks).ToListAsync();

            return userAuditChecks;
        }

        public async Task<int> GetQuestionCountByPriority(Guid userId, Priority priority)
        {
            var technologyId = _dbContext.Users
                              .Where(a => a.UserID.Equals(userId))
                              .Select(b => b.Batch)
                              .SelectMany(c => c.Technologies.Select(d => d.TechnologyId));

            int totalQuestion = await _dbContext.AuditChecks
                          .Where(a => technologyId.Contains(a.Technology.TechnologyId) && a.Priority.Equals(priority)).CountAsync();

            return totalQuestion;
        }

        public async Task<int> GetUserQuestionCountByPriority(Guid userId, Priority priority)
        {
            int totalQuestionAnswered = await _dbContext.Users
                                       .Where(a => a.UserID.Equals(userId))
                                       .SelectMany(b => b.Audits)
                                       .SelectMany(c => c.UserAuditChecks
                                       .Where(d => d.AuditCheck.Priority.Equals(priority)))
                                       .CountAsync();

            return totalQuestionAnswered;
        }
    }
}
