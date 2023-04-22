using SkillCheck.MasterData.Entities.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.Audits.Entities.Audits
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

        [Required]
        public CheckQuestion CheckQuestion { get; set; }

        [Required]
        public AuditWeight AuditWeight { get; set; }

        [Required]
        public Proficiency ExpectedProficiency { get; set; }

        [Required]
        public Proficiency DefaultProficiency { get; set; }

        [Required]
        public ExperienceBand ExperienceBand { get; set; }

        [Required]
        public Priority Priority { get; set; }

        [Required]
        public Level Level { get; set; }

        [Required]
        public List<JobRole> JobRoles { get; set; }



        public Technology Technology { get; set; }
        public short ProficiencyID { get; set; }
    }
}
