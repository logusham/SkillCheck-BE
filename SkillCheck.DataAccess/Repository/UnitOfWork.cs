using SkillCheck.Audits.IRepository;
using SkillCheck.Audits.Repository;
using SkillCheck.DataAccess.Data;
using SkillCheck.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Audit = new AuditRepository(_db);
            User = new UserRepository(_db);
            Batch = new BatchRepository(_db);
        }
        public IAuditRepository Audit { get; private set; }

        public IUserRepository User { get; private set; }
        public IBatchRepository Batch { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
