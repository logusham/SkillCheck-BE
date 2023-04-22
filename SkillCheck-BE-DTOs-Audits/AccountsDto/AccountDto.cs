namespace SkillCheck_BE_DTOs_Audits.AccountsDto
{
    public class AccountDto
    {
        public Guid AccountID { get; set; }
    
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }

        public ICollection<UserDto> Users { get; set; }

        public AccountTypeDto AccountType { get; set; }
    }
}
