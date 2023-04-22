using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck_BE_DTOs_Audits.DtoUpdated
{
    public class CustomerDto
    {
        [Key]
        public Guid CustomerId { get; set; }

        public CustomerTypeDto CustomerType { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }


        [Display(Name = "Active")]
        public bool IsActive { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Created Date")]
        public DateTimeOffset? CreatedDate { get; set; }


        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Modified Date")]
        public DateTimeOffset? ModifiedDate { get; set; }


        [Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; }


        public ICollection<BatchDto> Batches { get; set; }
    }
}
