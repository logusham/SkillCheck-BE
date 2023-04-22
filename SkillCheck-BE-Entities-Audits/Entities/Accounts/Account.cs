using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Accounts.Entities.Accounts
{
    public class Account
    {
        [Key]
        public Guid AccountID { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(60,ErrorMessage="Name can't be longer than 60 character")]
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage="Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

        public List<User> Users { get; set; }
        [Required(ErrorMessage = "Account type is required")]

        public AccountType AccountType { get; set; }
    }
}
