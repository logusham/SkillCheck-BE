using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DTOs_Audits.AuditsDto;
using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck.Controllers
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


        [HttpGet("modules/users/{userId}/technologies/{technologyId}")]     
        public async Task<ActionResult<IEnumerable<ModuleDto>>> GetAllModuleByTechnologies(Guid userId, long technologyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{userId} is not found");
            }
            else
            {
                var result = await _auditCheckService.GetAllModuleByTechnologies(userId,technologyId);
                return Ok(result);
            }
        }


        [HttpGet("units/users/{userId}/modules/{moduleId}")]
        public async Task<ActionResult<IEnumerable<UnitDto>>> GetAllUnitByModules(Guid userId, long moduleId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{userId} is not found");
            }
            else
            {
                var result = await _auditCheckService.GetAllUnitByModules(userId, moduleId);
                return Ok(result);
            }
        }


        [HttpGet("units/users/{userId}/technologies/{technologyId}")]        
        public async Task<ActionResult<IEnumerable<UnitDto>>> GetAllUnitByTechnologies(Guid userId, long technologyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{userId} is not found");
            }
            else
            {
                var result = await _auditCheckService.GetAllUnitByTechnologies(userId, technologyId);
                return Ok(result);
            }
        }

        [HttpGet]
        [Route("userAuditCheck/users/{userId}/unit/{unitId}")]
        public async Task<ActionResult<IEnumerable<UserAuditCheckDto>>> GetAllUserAuditCheckByUnit(Guid userId, long unitId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{userId} is not found");
            }
            else
            {
                var result = await _auditCheckService.GetAllUserAuditCheckByUnit(userId, unitId);
                return Ok(result);
            }
        }

        [HttpGet]
        [Route("overallSummary/{userId}")]
        public async Task<IActionResult> GetUserQuestionCountByPriority(Guid userId)
        {
            var auditSummary = await _auditCheckService.GetOverallSummary(userId);
            return Ok(auditSummary);
        }
    }
}
