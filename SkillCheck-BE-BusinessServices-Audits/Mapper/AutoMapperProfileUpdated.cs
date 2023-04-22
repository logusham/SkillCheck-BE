using AutoMapper;
using SkillCheck_BE_DTOs_Audits.DtoUpdated;
using SkillCheck_BE_Entities_Audits.EntitiesUpdated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck_BE_BusinessServices_Audits.Mapper
{
    public class AutoMapperProfileUpdated : Profile
    {
        public AutoMapperProfileUpdated()
        {
            CreateMap<Audit, AuditDto>();
            CreateMap<AuditCheck, AuditCheckDto>();
            CreateMap<Batch, BatchDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Technology, TechnologyDto>();
            CreateMap<User, UserDto>();
            CreateMap<UserAuditCheck, UserAuditCheckDto>();
        }
    }
}
