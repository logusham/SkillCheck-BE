namespace SkillCheck_BE_DTOs_Audits.MasterDto
{
    public class TopicDto
    {
        public long TopicID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public UnitDto Unit { get; set; }
        public ICollection<QuestionDto> Questions { get; set; }
    }
}
