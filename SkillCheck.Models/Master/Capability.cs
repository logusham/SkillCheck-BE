using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Audits.Master
{
    public class Capability
    {
        public Capability()
        {
            Competencies = new List<Competency>();
        }
       
        public long CapabilityId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public IEnumerable<Competency> Competencies { get; set; }
    }
}
