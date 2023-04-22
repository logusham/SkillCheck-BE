using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_DTOs_Audits.AuditsDto
{
    public class AuditCheckDto
    {
        public Guid AuditCheckID { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public CheckQuestionDto CheckQuestion { get; set; }
        public AuditWeightDto AuditWeight { get; set; }
        public short ExpectedProficiencyId { get; set; }
        public ProficiencyDto ExpectedProficiency { get; set; }
        public short DefaultProficiencyId { get; set; }
        public ProficiencyDto DefaultProficiency { get; set; }
        public ExperienceBandDto ExperienceBand { get; set; }
        public PriorityDto Priority { get; set; }
        public LevelDto Level { get; set; }
        public ICollection<JobRoleDto> JobRoles { get; set; }
        public long TechnologyId { get; set; }
    }
}
