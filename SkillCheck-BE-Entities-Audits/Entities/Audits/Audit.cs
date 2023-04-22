using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SkillCheck.Accounts.Entities.Accounts;
using SkillCheck.MasterData.Entities.Master;

namespace SkillCheck.Audits.Entities.Audits 
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
            AuditChecks = new List<AuditCheck>();
        }

        #endregion

        #region Properties of Audit

        [Key]
        public Guid AuditID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Code { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Created Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; }
        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }
        
/*        public Guid UserId { get; set; }
        [ForeignKey("UserId")]*/
         
        //public User User { get; set; }

        /// <summary>
        /// Represents the type of audit that is peformed. Can be self or other kind of audits
        /// </summary>
        [Required]
        [Display(Name = "Audit Type")]
        public AuditType AuditType { get; set; }

        /// <summary>
        /// Represents the category of competency that is being audited or reviewed
        /// </summary>
        [Required]
        [Display(Name = "Competency Category")]
        public CompetencyCategory CompetencyCategory { get; set; }

        /// <summary>
        /// Represents the technology chosen by the user during the time of audit
        /// </summary>
        [Required]
        [Display(Name = "Technology")]
        public Technology Technology { get; set; }

        /// <summary>
        /// This property represents the user for whom the audit or review is performed
        /// </summary>
       /* public Guid ReviewForUserId { get; set; }
        [ForeignKey("ReviewForUserId")]*/

        public Guid ReviewForUserId { get; set; }
        [Required]
        [Display(Name = "Review For User")]
        public User ReviewForUser { get; set; }

        /// <summary>
        /// This property represents the user who is performing the audit or review
        /// Can be one of the Audit Types in the domain. Can also be self review
        /// </summary>

        /*  public Guid ReviewByUserId { get; set; }
          [ForeignKey("ReviewByUserId")]*/

        [Required]
        [Display(Name = "Review By User")]
        public User ReviewByUser { get; set; }



        /// <summary>
        /// This property represetnts the list of checks the user has answered for the audit
        /// The list of audit checks that are applicable for the profile of the user is
        /// copied and then proficiency is selected by the reviewer
        /// </summary>
        [Required]
        [Display(Name = "Audit Checks")]
        public List<AuditCheck> AuditChecks { get; set; }

        /// <summary>
        /// This property represents the status of the audit. Once it is published, then
        /// it's visible for others
        /// </summary>
        [Required]
        [Display(Name = "Audit Status")]
        public AuditStatus AuditStatus { get; set; }

        #endregion
    }
}

