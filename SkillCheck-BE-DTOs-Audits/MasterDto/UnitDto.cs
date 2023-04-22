namespace SkillCheck_BE_DTOs_Audits.MasterDto
{
    public class UnitDto
    {
        public long UnitId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<TopicDto> Topics { get; set; }
    }
}
