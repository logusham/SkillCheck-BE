using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.ImplementaionUpdated;
using SkillCheck_BE_DTOs_Audits.DtoUpdated;

namespace SkillCheck.ControllersUpdated
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly TechnologyService _technologyService;

        public TechnologyController(TechnologyService technologyService)
        {
            _technologyService = technologyService;
        }
        [HttpGet("getAll")]
        public async Task<ActionResult<IEnumerable<TechnologyDto>>> Get()
        {
            try
            {
                var technologies = await _technologyService.GetAllTechnologies();
                return Ok(technologies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving technologies: {ex.Message}");
            }
        }
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<TechnologyDto>>> Get(Guid userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest($"{userId} is not found");
            }
            else
            {
                var result = await _technologyService.GetAllTechnologyByUserId(userId);
                return Ok(result);
            }
        }
    }
}
