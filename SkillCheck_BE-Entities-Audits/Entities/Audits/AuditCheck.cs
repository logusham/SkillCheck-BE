using SkillCheck_BE_Entities_Audits.Entities.Master;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.Entities.Audits
{
    public class AuditCheck
    {
        public AuditCheck()
        {
            JobRoles = new List<JobRole>();
        }

        [Key]
        public Guid AuditCheckID { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Created Date")]
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        [Display(Name = "Modified Date")]
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? ModifiedDate { get; set; }

        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }

        [ForeignKey("CheckQuestion")]
        public long CheckQuestionId { get; set; }
        public CheckQuestion CheckQuestion { get; set; }
        [ForeignKey("AuditWeight")]
        public int AuditWeightId { get; set; }
        public AuditWeight AuditWeight { get; set; }
        [ForeignKey("ExpectedProficiency")]
        public short ExpectedProficiencyId { get; set; }
        public Proficiency ExpectedProficiency { get; set; }
        [ForeignKey("DefaultProficiency")]
        public short DefaultProficiencyId { get; set; }
        public Proficiency DefaultProficiency { get; set; }

        public ExperienceBand ExperienceBand { get; set; }

        public Priority Priority { get; set; }

        public Level Level { get; set; }

        public ICollection<JobRole> JobRoles { get; set; }

        [ForeignKey("Technology")]
        public long TechnologyId { get; set; }
        public Technology Technology { get; set; }

        public bool IsCheck { get; set; }
        
    }
}
