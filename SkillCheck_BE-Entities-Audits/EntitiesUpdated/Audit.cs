using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.EntitiesUpdated
{
    public class Audit
    {
        [Key]
        public Guid AuditID { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

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


        [Display(Name = "Audit Status")]
        public AuditStatus AuditStatus { get; set; }

        public ICollection<UserAuditCheck> UserAuditChecks { get; set; }


        [ForeignKey("ReviewForUser")]
        public Guid ReviewForUserId { get; set; }


        [Display(Name = "Review For User")]
        public User ReviewForUser { get; set; }

       
        [ForeignKey("ReviewByUser")]
        public Guid? ReviewByUserId { get; set; }


        [Display(Name = "Review By User")]
        public User? ReviewByUser { get; set; }


    }
}
