using SkillCheck_BE_Entities_Audits.Entities.Accounts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.EntitiesUpdated
{
    public class User
    {
       
        public User()
        {
            UserAuthenticationCredentials = new List<UserAuthenticationCredential>();
            Audits = new List<Audit>();
        }

        [Key]
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public string LogIn { get; set; }
        public string Password { get; set; }



        [Display(Name = "Created Date")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? CreatedDate { get; set; }



        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }



        [Display(Name = "Modified Date")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? ModifiedDate { get; set; }



        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }


        public ICollection<Audit> Audits { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<UserAuthenticationCredential> UserAuthenticationCredentials { get; set; }

        //Seeding purpose

        public Batch? Batch { get; set; }
        [ForeignKey("Batch")]
        public Guid? BatchId { get; set; }
        public UserType UserType { get; set; }
    }
}
