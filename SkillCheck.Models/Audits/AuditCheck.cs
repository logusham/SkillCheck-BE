using Audits;
using Master;
using Master.Enums;
using System.ComponentModel.DataAnnotations;

namespace SkillCheck.Models.Audits
{
    public class AuditCheck
    {
        public AuditCheck()
        {
            Role = new List<JobRole>();
        }
        public Guid AuditCheckId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public CheckQuestion CheckQuestion { get; set; }
        public IEnumerable<JobRole> Role { get; set; }
        public Technology Technology { get; set; }
        public ExperienceBand ExperienceBand { get; set; }
        public Priority Priority { get; set; }
        public Level Level { get; set; }
        public AuditWeight AuditWeight { get; set; }
        public Proficiency ExpectedProficiency { get; set; }
        public Proficiency DefaultProficiency { get; set; }
    }
}
