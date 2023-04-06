using SkillCheck.DataAccess.Data;
using SkillCheck.DataAccess.IRepository;
using SkillCheck.Models.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.DataAccess.Repository
{
    public class AuditRepository : Repository<Audit>, IAuditRepository
    {
        private readonly ApplicationDbContext _db;
        public AuditRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(Audit obj)
        {
            _db.Audit.Update(obj);
        }
    }
}
