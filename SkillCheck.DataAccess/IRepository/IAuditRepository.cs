using SkillCheck.Models.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.DataAccess.IRepository
{
    public interface IAuditRepository : IRepository<Audit>
    {
        void Update(Audit obj);
    }
}
