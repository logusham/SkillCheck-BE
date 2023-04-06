using SkillCheck.Audits.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.DataAccess.IRepository
{
    public interface IUnitOfWork
    {
        IAuditRepository Audit { get;  }
        IUserRepository User { get; }
        IBatchRepository Batch { get; }
        void Save();
    }
}
