using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.EntitiesUpdated
{
    public class Customer
    {
      

        [Key]
        public Guid CustomerId { get; set; }

        public CustomerType CustomerType { get; set; }

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


        public ICollection<Batch> Batches { get; set; }


    }
}
