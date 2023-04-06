using SkillCheck.Models.Accounts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Models.Entitys
{
    public class Account
    {
        public Account()
        {
            Users = new List<User>();
        }
        public Guid AccountID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public IEnumerable<User> Users { get; set; }
        public AccountType AccountType { get; set; }
    }
}
