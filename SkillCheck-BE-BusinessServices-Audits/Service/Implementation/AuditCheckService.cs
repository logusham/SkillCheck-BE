using AutoMapper;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_DTOs_Audits.AuditsDto;
using SkillCheck_BE_DTOs_Audits.AuditSumary;
using SkillCheck_BE_DTOs_Audits.MasterDto;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Implementation
{
    public class AuditCheckService : IAuditCheckService
    {
        private readonly IAuditCheckRepository _auditCheckRepository;
        private readonly IMapper _mapper;

        public AuditCheckService(IAuditCheckRepository auditCheckRepository, IMapper mapper)
        {
            _auditCheckRepository = auditCheckRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ModuleDto>> GetAllModuleByTechnologies(Guid userId, long technologyId)
        {
            var moduleByTechnology = await _auditCheckRepository.GetAllModuleByTechnologies(userId, technologyId);
            var moduleByTechnologyDto = _mapper.Map<IEnumerable<ModuleDto>>(moduleByTechnology);
            return moduleByTechnologyDto;
        }

        public async Task<IEnumerable<UnitDto>> GetAllUnitByModules(Guid userId, long moduleId)
        {
            var unitByModule = await _auditCheckRepository.GetAllUnitByModules(userId, moduleId);
            var unitByModuleDto = _mapper.Map<IEnumerable<UnitDto>>(unitByModule);
            return unitByModuleDto;
        }

        public async Task<IEnumerable<UnitDto>> GetAllUnitByTechnologies(Guid userId, long technologyId)
        {
            var unitByTechnology = await _auditCheckRepository.GetAllUnitByTechnologies(userId, technologyId);
            var unitByTechnologyDto = _mapper.Map<IEnumerable<UnitDto>>(unitByTechnology);
            return unitByTechnologyDto;
        }

        public async Task<IEnumerable<UserAuditCheckDto>> GetAllUserAuditCheckByUnit(Guid userId, long unitId)
        {
            var allUserAuditCheck = await _auditCheckRepository.GetAllUserAuditCheckByUnit(userId, unitId);
            var allUserAuditCheckDto = _mapper.Map<IEnumerable<UserAuditCheckDto>>(allUserAuditCheck);
            return allUserAuditCheckDto;
        }

        public async Task<AuditSummaryDto> GetOverallSummary(Guid userId)
        {
            int totalMustHave = await _auditCheckRepository.GetQuestionCountByPriority(userId, Priority.MUST_HAVE);
            int totalGoodToHave = await _auditCheckRepository.GetQuestionCountByPriority(userId, Priority.GOOD_TO_HAVE);

            int totalMustHaveByUser = await _auditCheckRepository.GetUserQuestionCountByPriority(userId, Priority.MUST_HAVE);
            int totalGoodToHaveByUser = await _auditCheckRepository.GetUserQuestionCountByPriority(userId, Priority.GOOD_TO_HAVE);

            var auditSummary = new AuditSummaryDto
            {
                TotalMustHave = totalMustHave,
                TotalGoodToHave = totalGoodToHave,
                TotalOverall = totalMustHave + totalGoodToHave,
                UserMustHave = totalMustHaveByUser,
                UserGoodToHave = totalGoodToHaveByUser,
                UserOverall = totalGoodToHaveByUser + totalMustHaveByUser,
            };

            return auditSummary;
        }
    

    }
}

