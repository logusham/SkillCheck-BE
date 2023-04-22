
using SkillCheck_BE_Entities_Audits.Entities.Master;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.Entities.Audits
{
    public class CheckQuestion
    {
        [Key]
        public long CheckId { get; set; }
        [ForeignKey("Question")]
        public long QuestionId { get; set; }
        public Question? Question { get; set; }
        public Topic? Topic { get; set; }

        [StringLength(maximumLength: 500)]
        public string? Tags { get; set; }

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
        public long TopicId { get; set; }
        

    }
}
