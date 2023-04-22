using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.MasterData.Entities.Master 
{ 
    public class Unit
    {
        public Unit()
        {
            Topics = new List<Topic>();
        }

        [Key]
        public long UnitID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Code { get; set; }

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

        [Required]
        public long TopicID { get; set; }
        [ForeignKey("TopicId")]
        public List<Topic> Topics { get; set; }
    }
}
