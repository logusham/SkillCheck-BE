using SkillCheck_BE_Entities_Audits.Entities.Accounts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.Entities.Master
{
    public class Technology
    {

        [Key]
        public long TechnologyId { get; set; }

        public string? Title { get; set; }
        public string? Code { get; set; }

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

        [ForeignKey("Batch")]
        public Guid BatchId { get; set; }
        public Batch? Batch { get; set; }
        public ICollection<Module> Modules { get; set; } = new List<Module>();  
    }
}
