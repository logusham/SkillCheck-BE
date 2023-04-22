using SkillCheck.MasterData.Entities.Master;
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
    public class Batch
    {

        public Batch()
        {
            Technologies = new List<Technology>();
            Users = new List<User>();
        }

        [Key]
        public Guid BatchId { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Expected End Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExpectedEndDate { get; set; }

        [Display(Name = "Actual End Date")]
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ActualEndDate { get; set; }

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
        public List<User> Users { get; set; }




        [Required]
        public Customer Customer { get; set; }


        [Display(Name = "Technologies")]
        public List<Technology> Technologies { get; set; }

    }
}
