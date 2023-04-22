
using SkillCheck_BE_Entities_Audits.Entities.Master;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.Entities.Audits
{
    public class UserAuditCheck
    {
        [Key]
        public Guid UserAuditCheckID { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Updated")]
        public bool IsUpdated { get; set; }

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

        [ForeignKey("AuditCheck")]
        public Guid AuditCheckID { get; set; }
        public AuditCheck? AuditCheck { get; set; }

        [ForeignKey("UserProficiency")]
        public short UserProficiencyId { get; set; }

        public Proficiency? UserProficiency { get; set; }
    }
}
