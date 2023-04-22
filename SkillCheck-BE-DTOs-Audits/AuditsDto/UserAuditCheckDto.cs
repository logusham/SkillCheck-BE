using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_DTOs_Audits.AuditsDto
{
    public class UserAuditCheckDto
    { 
        public Guid UserAuditCheckID { get; set; }
        public bool IsActive { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Guid AuditCheckID { get; set; }
        public ProficiencyDto UserProficiency { get; set; }
    }
}
