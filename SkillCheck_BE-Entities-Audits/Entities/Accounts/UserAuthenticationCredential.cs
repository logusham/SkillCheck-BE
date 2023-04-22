using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.Entities.Accounts
{
    public class UserAuthenticationCredential
    {
        [Key]
        public Guid AuthenticationId { get; set; }

        
        public string? LoginId { get; set; }

        
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Locked Out")]
        public bool IsLockedOut { get; set; }
        public AuthenticationMode AuthenticationMode { get; set; }
        public AuthenticationSource AuthenticationSource { get; set; }
    }
}
