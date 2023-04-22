using SkillCheck_BE_Entities_Audits.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck_BE_DTOs_Audits.DtoUpdated
{
    public class UserDto
    {
       

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


        public ICollection<AuditDto> Audits { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }


        public BatchDto? Batch { get; set; }
        [ForeignKey("Batch")]
        public Guid? BatchId { get; set; }
        public UserTypeDto UserType { get; set; }
    }
}
