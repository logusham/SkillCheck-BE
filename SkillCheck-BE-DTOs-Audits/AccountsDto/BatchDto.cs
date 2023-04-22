using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck_BE_DTOs_Audits.AccountsDto
{
    public class BatchDto
    {
        public Guid BatchId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<UserDto> Users { get; set; }
        public CustomerDto Customer { get; set; }
        public ICollection<TechnologyDto> Technologies { get; set; }
    }
}
