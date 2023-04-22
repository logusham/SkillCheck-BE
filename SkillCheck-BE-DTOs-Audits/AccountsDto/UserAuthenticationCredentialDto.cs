namespace SkillCheck_BE_DTOs_Audits.AccountsDto
{
    public class UserAuthenticationCredentialDto
    {
        public Guid AuthenticationId { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }//Change the type to password
        public bool IsActive { get; set; }
        public bool IsLockedOut { get; set; }
        public AuthenticationModeDto AuthenticationMode { get; set; }
        public AuthenticationSourceDto AuthenticationSource { get; set; }
    }
}
