using Master;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillCheck.DataAccess.IRepository;
using SkillCheck.DataAccess.Repository;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;

namespace SkillCheck.Audits.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class TechnologiesController : ControllerBase
    {
        private readonly ITechnologyService _service;

        public TechnologiesController(ITechnologyService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Guid UserId)
        {
            IEnumerable<Technology> technologies = _service.GetTechnologies(UserId);
            return Ok(technologies);
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Guid BatchId, [FromQuery] Guid UserId)
        {
            var technology = _service.GetTechnology(BatchId, UserId);
            return Ok(technology);
        }
    }
}
