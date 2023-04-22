using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.IntefaceUpdated;
using SkillCheck_BE_DTOs_Audits.DtoUpdated;

namespace SkillCheck.ControllersUpdated
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditCheckController : ControllerBase
    {
        private readonly IAuditCheckService _auditCheckService;

        public AuditCheckController(IAuditCheckService auditCheckService)
        {
            _auditCheckService = auditCheckService;
        }

        [HttpGet("auditcheck/technologies/{technologyId}")]
        public async Task<ActionResult<IEnumerable<AuditCheckDto>>> Get(long technologyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{technologyId} is not found");
            }
            else
            {
                var result = await _auditCheckService.GetAllModuleByTechnologies(technologyId);
                return Ok(result);
            }
        }
        [HttpGet("auditcheck/module/{moduleName}")]
        public async Task<ActionResult<IEnumerable<AuditCheckDto>>> Get(string moduleName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{moduleName} is not found");
            }
            else
            {
                var result = await _auditCheckService.GetAllUnitByModuleName(moduleName);
                return Ok(result);
            }
        }
    }
}
