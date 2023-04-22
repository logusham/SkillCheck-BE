using SkillCheck.MasterData.Entities.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.Audits.Entities.Audits
{
    public class CheckQuestion
    {
        [Key]
        public long CheckId { get; set; }

        [Required]
        public Question Question { get; set; }

        [Required]
        public Topic Topic { get; set; }

        [StringLength(maximumLength: 500)]
        public string Tags { get; set; }

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
        public long TopicId { get; set; }
    }
}
