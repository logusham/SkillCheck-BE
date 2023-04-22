using SkillCheck_BE_Entities_Audits.Entities.Accounts;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Interface
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task <IEnumerable<Customer>> GetCustomers();
        Task<IEnumerable<Batch>> GetAllBatchesByCustomerId(Guid customerId);
    }
}
