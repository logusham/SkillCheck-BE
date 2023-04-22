using SkillCheck_BE_DTOs_Audits.AuditsDto;

namespace SkillCheck_BE_DTOs_Audits.AccountsDto
{
    public class UserDto
    {
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public ICollection<AuditDto> Audits { get; set; }
        public CustomerDto Customer { get; set; }
        public ICollection<UserAuthenticationCredentialDto> UserAuthenticationCredentials { get; set; }
        public BatchDto Batch { get; set; }
    }
}
