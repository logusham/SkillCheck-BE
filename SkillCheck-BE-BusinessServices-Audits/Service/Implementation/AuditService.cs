using AutoMapper;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_DTOs_Audits.AuditsDto;
using SkillCheck_BE_Entities_Audits.Entities.Audits;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Implementation
{
    public class AuditService : IAuditService
    {
        private readonly IAuditRepository _auditRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;   

        public AuditService(IAuditRepository auditRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _auditRepository = auditRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAuditAsync(AuditDto auditDto)
        {
            Audit audit = this._mapper.Map<Audit>(auditDto);
            await _unitOfWork.Audit.Add(audit);
            _unitOfWork.Save();
        }

        public async Task<IEnumerable<AuditDto>> GetAuditByAuditId(Guid id)
        {
            var audit = await _auditRepository.GetAuditByAuditId(id);
            var auditDto = _mapper.Map<IEnumerable<AuditDto>>(audit);
            return auditDto;

        }

        public async Task<IEnumerable<AuditDto>> GetAuditByTechnology(Guid userId, long technologyId)
        {
            var audit = await _auditRepository.GetAuditByTechnology(userId,technologyId);
            var auditDto = _mapper.Map<IEnumerable<AuditDto>>(audit);
            return auditDto;
        }

        public Task UpdateAuditAsync(AuditDto auditDto)
        {
            Audit audit =  this._mapper.Map<Audit>(auditDto);
            _unitOfWork.Audit.Update(audit);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }
    }
}
