using SkillCheck_BE_DTOs_Audits.DtoUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_BusinessServices_Audits.Service.IntefaceUpdated
{
    public interface IAuditService
    {
        Task UpdateAuditByAuditId(int ausitId,AuditDto audit);
        Task AddAudit(AuditDto audit);
    }
}
