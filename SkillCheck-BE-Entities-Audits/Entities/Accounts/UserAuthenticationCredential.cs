using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.Accounts.Entities.Accounts
{
    public class UserAuthenticationCredential
    {
        [Key]
        public Guid AuthenticationId { get; set; }

        [Required]
        public string LoginId { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Locked Out")]
        public bool IsLockedOut { get; set; }

        [Required]
        public AuthenticationMode AuthenticationMode { get; set; }


        [Required]
        public AuthenticationSource AuthenticationSource { get; set; }
    }
}
