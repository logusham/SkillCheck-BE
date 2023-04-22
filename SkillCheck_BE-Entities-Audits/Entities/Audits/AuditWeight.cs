using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.Entities.Audits
{
    public class AuditWeight
    {
        [Key]
        public int ID { get; set; }

        
        public string? Code { get; set; }

        [Range(0, float.MaxValue)]
        public float Weight { get; set; }
    }
}

