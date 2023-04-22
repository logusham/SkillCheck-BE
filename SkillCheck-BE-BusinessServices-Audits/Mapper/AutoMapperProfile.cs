using AutoMapper;
using SkillCheck_BE_DTOs_Audits.AccountsDto;
using SkillCheck_BE_DTOs_Audits.AuditsDto;
using SkillCheck_BE_DTOs_Audits.MasterDto;
using SkillCheck_BE_Entities_Audits.Entities.Accounts;
using SkillCheck_BE_Entities_Audits.Entities.Audits;
using SkillCheck_BE_Entities_Audits.Entities.Master;

namespace SkillCheck_BE_BusinessServices_Audits.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Technology,TechnologyDto>();
            CreateMap<TechnologyDto, Technology>();

            CreateMap<Audit,AuditDto>();
            CreateMap<AuditDto, Audit>();

            CreateMap<Module,ModuleDto>();
            CreateMap<ModuleDto, Module>();

            CreateMap<Unit,UnitDto>();
            CreateMap<UnitDto, Unit>();

            CreateMap<UserAuditCheck,UserAuditCheckDto>();
            CreateMap<UserAuditCheckDto, UserAuditCheck>();

            CreateMap<Proficiency, ProficiencyDto>();
            CreateMap<ProficiencyDto, Proficiency >();

            CreateMap<AccountDto, Account>();
            CreateMap<Account, AccountDto>();

            CreateMap<AccountTypeDto, AccountType>();
            CreateMap<AccountType, AccountTypeDto>();

            CreateMap<AuthenticationMode, AuthenticationModeDto>();
            CreateMap<AuthenticationModeDto, AuthenticationMode>();

            CreateMap<AuthenticationSourceDto, AuthenticationSource>();
            CreateMap<AuthenticationSource, AuthenticationSourceDto>();

            CreateMap<Batch, BatchDto>();
            CreateMap<Batch, BatchDto>();

            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();

            CreateMap<CustomerType, CustomerTypeDto>();
            CreateMap<CustomerTypeDto, CustomerType>();

            CreateMap<UserAuthenticationCredential, UserAuthenticationCredentialDto>();
            CreateMap<UserAuthenticationCredentialDto, UserAuthenticationCredential>();

            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

            CreateMap<UserType, UserTypeDto>();
            CreateMap<UserTypeDto, UserType>();

            CreateMap<AuditCheckDto, AuditCheck>();
            CreateMap<AuditCheck, AuditCheckDto>();

            CreateMap<AuditStatus, AuditStatusDto>();
            CreateMap<AuditStatusDto, AuditStatus>();

            CreateMap<AuditType, AuditTypeDto>();
            CreateMap<AuditTypeDto, AuditType>();

            CreateMap<AuditWeight, AuditWeightDto>();
            CreateMap<AuditWeightDto, AuditWeight>();

            CreateMap<CheckQuestion, CheckQuestionDto>();
            CreateMap<CheckQuestionDto, CheckQuestionDto>();

            CreateMap<Capability, CapabilityDto>();
            CreateMap<CapabilityDto, Capability>();

            CreateMap<CompetencyCategory, CompetencyCategoryDto>();
            CreateMap<CompetencyCategoryDto, CompetencyCategory>();

            CreateMap<ExperienceBand, ExperienceBandDto>();
            CreateMap<ExperienceBandDto, ExperienceBand>();

            CreateMap<JobRole, JobRoleDto>();
            CreateMap<JobRoleDto, JobRole>();

            CreateMap<Level, LevelDto>();
            CreateMap<LevelDto, Level>();

            CreateMap<Priority, PriorityDto>();
            CreateMap<PriorityDto, Priority>();

            CreateMap<ProficiencyType, ProficiencyTypeDto>();
            CreateMap<ProficiencyTypeDto, ProficiencyType>();

            CreateMap<Question, QuestionDto>();
            CreateMap<QuestionDto, Question>();

            CreateMap<TopicDto, Topic>();
            CreateMap<Topic, TopicDto>();

            CreateMap<Competency, CompetencyDto>();
            CreateMap<CompetencyDto, Competency>();
        }
    }
}
