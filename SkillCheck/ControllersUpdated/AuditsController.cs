using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.ImplementaionUpdated;
using SkillCheck_BE_DTOs_Audits.DtoUpdated;

namespace SkillCheck.ControllersUpdated
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditsController : ControllerBase
    {
        private readonly AuditService _auditService;

        public AuditsController(AuditService auditService)
        {
            _auditService = auditService;
        }
        [HttpPost("audit")]
        public async Task<IActionResult> Push([FromBody] AuditDto audit)
        {
            try
            {
                await _auditService.AddAudit(audit);
                return Ok("Audit Created Successfully..");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while audit : {ex.Message}");
            }
        }
        [HttpPut("update")]
        public async Task<IActionResult> Updare([FromQuery] int auditId, [FromBody] AuditDto audit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{auditId} is not found");
            }
            else
            {       
                try
                {
                    await _auditService.UpdateAuditByAuditId(auditId, audit);
                    return Ok("Audit Update Successfully..");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"An error occurred while audit : {ex.Message}");
                }
            }
        }
    }
}
