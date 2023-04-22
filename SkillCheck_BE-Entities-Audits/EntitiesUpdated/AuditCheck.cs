using System.ComponentModel.DataAnnotations;

namespace SkillCheck_BE_Entities_Audits.EntitiesUpdated
{
    public class AuditCheck
    {
        
        [Key]
        public Guid AuditCheckId { get; set; }

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




        public string TechnologyCode { get; set; }
        public string TechnologyName { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string TopicCode { get; set; }
        public string TopicName { get; set; }
        public string QuestionCode { get; set; }
        public string QuestionName { get; set; }
        public string PriorityCode { get; set; }
        public string PriorityName { get; set; }
        public string LevelCode { get; set; }
        public string LevelName { get; set; }
        public string DefaultProficiencyCode { get; set; }
        public string DefaultProficiencyName { get; set; } 
        public string ExpectedProficiencyCode { get; set; }
        public string ExpectedProficiencyName { get; set; }


        public Technology Technology { get; set; }
    }
}
