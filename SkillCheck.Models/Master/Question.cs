
using System.ComponentModel.DataAnnotations;

namespace SkillCheck.Audits.Master
{
    public class Question
    {
        
        public long QuestionId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string KnowledgeAreas { get; set; }
        public string Competencies { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
