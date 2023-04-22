using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.Entities.Master
{
    public class Module
    {

        public Module()
        {
            Units = new List<Unit>();
        }
        [Key]
        public long ModuleID { get; set; }

        
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
  


        //Seeding purpose

        public long TechnologyId { get; set; }
        [ForeignKey("Technology")]

        public ICollection<Unit> Units { get; set; }
    }
}
