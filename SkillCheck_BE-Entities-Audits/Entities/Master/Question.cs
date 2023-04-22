using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillCheck_BE_Entities_Audits.Entities.Master
{
    public class Question
    {
        [Key]
        public long QuestionID { get; set; }

        
        public string? Title { get; set; }

        [Display(Name = "Code")]
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

        [Display(Name = "Knowledge Area Tags")]
        public string? KnowledgeAreaTags { get; set; }

        [Display(Name = "Competency Tags")]
        public string? CompetencyTags { get; set; }

        [ForeignKey("Topic")]
        public long TopicId { get; set; }

        public Topic? Topic { get; set; }
    }
}
