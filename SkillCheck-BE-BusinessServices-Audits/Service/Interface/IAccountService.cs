using SkillCheck_BE_DTOs_Audits.AccountsDto;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Interface
{
    public interface IAccountService
    {
        Task<IEnumerable<CustomerDto>> GetCustomers();
        Task<IEnumerable<BatchDto>> GetAllBatchesForCustomer(Guid customerId);
    }
}
