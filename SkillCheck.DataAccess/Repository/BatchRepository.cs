using SkillCheck.Audits.IRepository;
using SkillCheck.DataAccess.Data;
using SkillCheck.DataAccess.Repository;
using SkillCheck.Models.Accounts;

namespace SkillCheck.Audits.Repository
{
    public class BatchRepository : Repository<Batch>,IBatchRepository
    {
        private readonly ApplicationDbContext _db;
        public BatchRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
    }
}
