using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.Entities.Master
{
    public class Topic
    {
        public Topic()
        {
            Questions = new List<Question>();
        }
        [Key]
        public long TopicID { get; set; }  
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
        [ForeignKey("Unit")]
        public long UnitId { get; set; }
        public Unit Unit { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
