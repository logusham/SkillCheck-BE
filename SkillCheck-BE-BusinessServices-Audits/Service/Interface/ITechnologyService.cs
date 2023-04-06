using Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Interface
{
    public interface ITechnologyService
    {
        IEnumerable<Technology> GetTechnologies(Guid UserId);
        Technology GetTechnology(Guid BatchId, Guid UserId);
    }
}
