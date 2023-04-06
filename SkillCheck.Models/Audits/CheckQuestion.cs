using Master;
using SkillCheck.Audits.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audits
{
    public class CheckQuestion
    {
        public long CheckId { get; set; }
        public string Tags { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Topic Topic { get; set; }
        public Question Question { get; set; }

    }
}
