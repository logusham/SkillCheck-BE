using AutoMapper;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DataRepository_Audits.DataRepository.Interface;
using SkillCheck_BE_DTOs_Audits.AccountsDto;

namespace SkillCheck_BE_BusinessServices_Audits.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public AccountService(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BatchDto>> GetAllBatchesForCustomer(Guid customerId)
        {
            var batches = await _accountRepository.GetAllBatchesByCustomerId(customerId);
            var batchesdto = _mapper.Map<IEnumerable<BatchDto>>(batches);
            return batchesdto;
        }

        public async Task<IEnumerable<CustomerDto>> GetCustomers()
        {
            var customers = await _accountRepository.GetCustomers();
            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
            return customersDto;
        }
    }
}
