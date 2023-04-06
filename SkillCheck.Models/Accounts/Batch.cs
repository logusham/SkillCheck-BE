using Master;
using SkillCheck.Models.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Models.Accounts
{
    public class Batch
    {
        public Batch()
        {
            Technologies = new List<Technology>();
            Users = new List<User>();
        }
        public Guid BatchId { get; set; }
        public string Code { get; set; }
        public string  Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Technology> Technologies { get; set; }
    }
}
