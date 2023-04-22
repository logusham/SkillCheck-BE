using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.EntitiesUpdated
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

        public string UserProficiencyCode { get; set; }
        public string UserProficiencyName { get; set; }

        public ICollection<AuditCheck> AuditChecks { get; set; }


    }
}
