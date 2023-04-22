using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Audits.Entities.Audits 
{ 
    public class AuditWeight
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Code { get; set; }

        [Range(0, float.MaxValue)]
        public float Weight { get; set; }
    }
}
