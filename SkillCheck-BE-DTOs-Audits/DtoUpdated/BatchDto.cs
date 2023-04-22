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
    public class BatchDto
    {
        [Key]
        public Guid BatchId { get; set; }

        public string Code { get; set; }


        public string Title { get; set; }


        [Display(Name = "Start Date")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset StartDate { get; set; }


        [Display(Name = "Expected End Date")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset ExpectedEndDate { get; set; }


        [Display(Name = "Actual End Date")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset ActualEndDate { get; set; }


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

        public ICollection<UserDto> Users { get; set; }

        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; }

        public ICollection<TechnologyDto> Technologies { get; set; }
    }
}
