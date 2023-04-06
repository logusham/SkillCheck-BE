using SkillCheck.Models.Accounts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Models.Accounts
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public CustomerType CustomerType { get; set; }
        public IEnumerable<Batch> Batches { get; set; }
    }
}
