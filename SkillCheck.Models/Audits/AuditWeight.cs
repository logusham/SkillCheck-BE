using System.ComponentModel.DataAnnotations;

namespace Audits
{
    public class AuditWeight
    {
        public short AuditWeightID { get; set; }
        public float Weight { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
