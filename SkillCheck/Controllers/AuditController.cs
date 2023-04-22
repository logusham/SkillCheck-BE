using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DTOs_Audits.AuditsDto;

namespace SkillCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditController : ControllerBase
    {
        private readonly IAuditService _auditService;

        public AuditController(IAuditService auditService)
        {
            _auditService = auditService;
        }

        [HttpPost("audit")]
        public async Task<IActionResult> Post([FromBody]AuditDto auditDto)
        {
            await _auditService.CreateAuditAsync(auditDto);
            return Ok("Audit Created Successfully..");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuditDto>> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{id} is not found");
            }
            else
            {
                var result = await _auditService.GetAuditByAuditId(id);
                return Ok(result);
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateJobApplication([FromBody]AuditDto auditDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");

            }
            await _auditService.UpdateAuditAsync(auditDto);
            return Ok("Audit Update Successfully..");
        }

        [HttpGet("user/{userId}/technolgy/{technologyId}")]
        public async Task<ActionResult<IEnumerable<AuditDto>>> Get(Guid userId, long technologyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{userId} is not found");
            }
            else
            {
                var result = await _auditService.GetAuditByTechnology(userId, technologyId);
                return Ok(result);
            }
        }









    }
}
