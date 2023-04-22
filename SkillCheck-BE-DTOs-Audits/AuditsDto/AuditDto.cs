using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_DTOs_Audits.AuditsDto
{
    public class AuditDto
    {
        public Guid AuditID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public AuditTypeDto AuditType { get; set; }

        public CompetencyCategoryDto CompetencyCategory { get; set; }

        public long TechnologyId { get; set; }

        public Guid ReviewForUserId { get; set; }

        public Guid ReviewByUserId { get; set; }
        public ICollection<UserAuditCheckDto> UserAuditChecks { get; set; }

        public AuditStatusDto AuditStatus { get; set; }
    }
}
