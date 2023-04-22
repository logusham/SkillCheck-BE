using SkillCheck.Audits.Entities.Audits;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.Accounts.Entities.Accounts
{
    public class User
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public User()
        {
            UserAuthenticationCredentials = new List<UserAuthenticationCredential>();
            //Audits = new List<Audit>();
        }

        [Key]
        public Guid UserID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobileNo { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Created Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        
        [Display(Name = "Modified Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }


        //public List<Audit> Audits { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }



        public List<UserAuthenticationCredential> UserAuthenticationCredentials { get; set; }


        
      
        public Batch Batch { get; set; }
    }
}
