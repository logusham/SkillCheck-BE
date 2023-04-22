using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DTOs_Audits.AccountsDto;

namespace SkillCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpGet("getAllCustomers")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var organizations = await _accountService.GetCustomers();
                return Ok(organizations);
            }
            catch (Exception ex)
            {
                // Handle the exception here and return an appropriate response
                return StatusCode(500, $"An error occurred while retrieving technologies: {ex.Message}");
            }
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<IEnumerable<BatchDto>>> Get(Guid customerId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{customerId} is not found");
            }
            else
            {
                var batches = await _accountService.GetAllBatchesForCustomer(customerId);
                return Ok(batches);
            }
        }
    }
}
