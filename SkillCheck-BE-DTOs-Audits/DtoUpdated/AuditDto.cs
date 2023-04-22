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
    public class AuditDto
    {
        [Key]
        public Guid AuditID { get; set; }

        public string Title { get; set; }
        public string Code { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }



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


        [Display(Name = "Audit Status")]
        public AuditStatusDto AuditStatus { get; set; }

        public ICollection<UserAuditCheckDto> UserAuditChecks { get; set; }


        [ForeignKey("ReviewForUser")]
        public Guid ReviewForUserId { get; set; }


        [Display(Name = "Review For User")]
        public UserDto ReviewForUser { get; set; }


        [ForeignKey("ReviewByUser")]
        public Guid? ReviewByUserId { get; set; }


        [Display(Name = "Review By User")]
        public UserDto? ReviewByUser { get; set; }

    }
}
