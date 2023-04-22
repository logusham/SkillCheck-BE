namespace SkillCheck_BE_DTOs_Audits.MasterDto
{
    public class ModuleDto
    {

        public long ModuleID { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        public bool IsActive { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }
        public TechnologyDto Technology { get; set; }

        public ICollection<UnitDto> Units { get; set; }
    }
}
