using SkillCheck.Audits.Master;
using System.ComponentModel.DataAnnotations;

namespace Master
{
    public class Topic
    {
        public Topic()
        {
            Questions = new List<Question>();
        }
        
        public long TopicId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
