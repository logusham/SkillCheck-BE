using SkillCheck.Models.Accounts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Models.Accounts
{
    public class UserAuthenticationCredentials
    {
        [Key]
        public Guid AuthenticationID { get; set; }
        public string LoginId { get; set; }
        public PasswordPropertyTextAttribute Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsLockedOut { get; set; }
        public AuthenticationSource AuthenticationSource { get; set; }
        public AuthenticationMode AuthenticationMode { get; set; }
    }
}
