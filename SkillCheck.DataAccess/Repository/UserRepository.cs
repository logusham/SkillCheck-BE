using Master;
using SkillCheck.Audits.IRepository;
using SkillCheck.DataAccess.Data;
using SkillCheck.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Audits.Repository
{
    public class UserRepository : Repository<Technology>,IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
