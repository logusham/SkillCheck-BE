using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.Entities.Accounts
{
    public class Account
    {
        [Key]
        public Guid AccountID { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 character")]
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

        public ICollection<User>? Users { get; set; }
        
        [Required(ErrorMessage = "Account type is required")]
        public AccountType AccountType { get; set; }
    }
}
