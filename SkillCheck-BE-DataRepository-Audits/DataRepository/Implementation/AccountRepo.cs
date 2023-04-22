using Microsoft.EntityFrameworkCore;
using SkillCheck_BE_DataRepository_Audits.DataAccess;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_Entities_Audits.Entities.Accounts;

namespace SkillCheck_BE_DataRepository_Audits.DataRepository.Implementation
{
    public class AccountRepo : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepo(SkillCheckDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Batch>> GetAllBatchesByCustomerId(Guid customerId)
        {
            var batches = await  _dbContext.Batches.Where(a => a.CustomerId.Equals(customerId) && a.IsActive.Equals(true)).ToListAsync();

            return batches;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {

            return await _dbContext.Customers.Where(a => a.IsActive.Equals(true))
                .Select(x => x).ToListAsync();


            return await _dbContext.Customers.Where(a => a.IsActive.Equals(true)).Select(x => x).ToListAsync();
        }
    }
}
