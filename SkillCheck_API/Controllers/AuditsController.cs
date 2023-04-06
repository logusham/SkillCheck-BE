using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;

namespace SkillCheck_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditsController : ControllerBase
    {
        private readonly IAuditService _service;

        public AuditsController(IAuditService service)
        {
            _service = service;
        }

    }
}
