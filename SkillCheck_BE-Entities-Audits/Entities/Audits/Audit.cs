
using SkillCheck_BE_Entities_Audits.Entities.Accounts;
using SkillCheck_BE_Entities_Audits.Entities.Master;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.Entities.Audits
{
    /// <summary>
    /// Represents an audit that is performed by the user. The Audit will belong to one
    /// of the types. Each time a user initiates a review, an audit object is created
    /// </summary>
    public class Audit
    {

        #region Constructor
        /// <summary>
        /// Constructor - Instantiating the Audit Object
        /// </summary>
        public Audit()
        {
            UserAuditChecks = new List<UserAuditCheck>();
        }

        #endregion

        #region Properties of Audit

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

        /// <summary>
        /// Represents the type of audit that is peformed. Can be self or other kind of audits
        /// </summary>
        [Display(Name = "Audit Type")]
        public AuditType AuditType { get; set; }

        /// <summary>
        /// Represents the category of competency that is being audited or reviewed
        /// </summary>
        
        [Display(Name = "Competency Category")]
        public CompetencyCategory CompetencyCategory { get; set; }

        /// <summary>
        /// Represents the technology chosen by the user during the time of audit
        /// </summary>
        
        [Display(Name = "Technology")]
        public Technology Technology { get; set; }
        [ForeignKey("Technology")]
        public long TechnologyId { get; set; }

        /// <summary>
        /// This property represents the user for whom the audit or review is performed
        /// </summary>

        [ForeignKey("ReviewForUser")]
        public Guid ReviewForUserId { get; set; }
        
        
        [Display(Name = "Review For User")]
        public User ReviewForUser { get; set; }

        /// <summary>   
        /// This property represents the user who is performing the audit or review
        /// Can be one of the Audit Types in the domain. Can also be self review
        /// </summary>

        [ForeignKey("ReviewByUser")]
        public Guid? ReviewByUserId { get; set; }

          
        [Display(Name = "Review By User")]
        public User? ReviewByUser { get; set; }

        /// <summary>
        /// This property represetnts the list of checks the user has answered for the audit
        /// The list of audit checks that are applicable for the profile of the user is
        /// copied and then proficiency is selected by the reviewer
        /// </summary>

        [Display(Name = "Audit Checks")]
        public ICollection<UserAuditCheck> UserAuditChecks { get; set; }

        /// <summary>
        /// This property represents the status of the audit. Once it is published, then
        /// it's visible for others
        /// </summary>
        
        [Display(Name = "Audit Status")]
        public AuditStatus AuditStatus { get; set; }

        #endregion
    }
}
