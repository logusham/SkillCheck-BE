using Master;
using Master.Enums;
using SkillCheck.Audits.Audits.Enums;
using SkillCheck.Models.Audits.Enums;
using SkillCheck.Models.Entitys;
using System.ComponentModel.DataAnnotations;

namespace SkillCheck.Models.Audits
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
        public Guid AuditID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        /// <summary>
        /// This property represents the user for whom the audit or review is performed
        /// </summary>
        //public User ReviewForUser { get; set; }
        /// <summary>
        /// This property represents the user who is performing the audit or review
        /// Can be one of the Audit Types in the domain. Can also be self review
        /// </summary>
        //public User ReviewByUser { get; set; }
        public User Review { get; set; }
        /// <summary>
        /// Represents the category of competency that is being audited or reviewed
        /// </summary>
        public CompetencyCategory CompetencyCategory { get; set; }
        /// <summary>
        /// This property represetnts the list of checks the user has answered for the audit
        /// The list of User audit checks that are applicable for the profile of the user is
        /// copied and then proficiency is selected by the reviewer
        /// </summary>
        public IEnumerable<UserAuditCheck> UserAuditChecks { get; set; }
        /// <summary>
        /// Represents the technology chosen by the user during the time of audit
        /// </summary>
        public Technology Technology { get; set; }
        /// <summary>
        /// Represents the type of audit that is peformed. Can be self or other kind of audits
        /// </summary>
        public AuditType AuditType { get; set; }
        /// <summary>
        /// This property represents the status of the audit. Once it is published, then
        /// it's visible for others
        /// </summary>
        public AuditStatus AuditStatus { get; set; }
        #endregion
    }
}
