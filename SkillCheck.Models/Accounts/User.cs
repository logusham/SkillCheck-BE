using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillCheck.Models.Accounts;
using SkillCheck.Models.Accounts.Enums;
using SkillCheck.Models.Audits;

namespace SkillCheck.Models.Entitys
{
    public class User
    {
        public User()
        {
            Audits = new List<Audit>();
            AuthenticationCredentials = new List<UserAuthenticationCredentials>();
        }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public EmailAddressAttribute Email { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public IEnumerable<Audit> Audits { get; set; }
        public IEnumerable<UserAuthenticationCredentials> AuthenticationCredentials { get; set; }
        public Customer Customer { get; set; }
        public Batch Batch { get; set; }
        public UserType UserType { get; set; }
    }
}
