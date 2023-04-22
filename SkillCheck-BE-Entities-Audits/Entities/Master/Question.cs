using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.MasterData.Entities.Master
{
    public class Question
    {
        [Key]
        public long QuestionID { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Code")]
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

        [Display(Name = "Knowledge Area Tags")]
        public string KnowledgeAreaTags { get; set; }

        [Display(Name = "Competency Tags")]
        public string CompetencyTags { get; set; }
    }
}
