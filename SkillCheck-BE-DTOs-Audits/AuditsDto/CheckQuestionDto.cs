using SkillCheck_BE_DTOs_Audits.MasterDto;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_DTOs_Audits.AuditsDto
{
    public class CheckQuestionDto
    {
        public long CheckId { get; set; }
        public QuestionDto Question { get; set; }
        public Topic Topic { get; set; }
        public string Tags { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        //For AuditSummary We Implementing this
       // public bool IsCheck { get; set; }

    }
}
