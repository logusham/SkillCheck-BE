using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillCheck.Accounts.Entities.Accounts
{
    public class Customer
    {
        public Customer()
        {
            //Instantiating the batches collection
            Batches = new List<Batch>();
        }
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        public CustomerType CustomerType { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Code { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Required(ErrorMessage = "Date created is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Required]
        public List<Batch> Batches { get; set; }


    }
}
