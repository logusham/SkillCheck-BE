using Microsoft.AspNetCore.Mvc;
using SkillCheck_BE_BusinessServices_Audits.Service.Interface;
using SkillCheck_BE_DTOs_Audits.MasterDto;

namespace SkillCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyService _technologyService;

        public TechnologyController(ITechnologyService technologyService)
        {
            _technologyService = technologyService;
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
                var result = await _technologyService.GetAllTechnologiesByUserService(userId);
                return Ok(result);
            }
        }


        [HttpGet("getAll")]        
        public async Task<IActionResult> Get()
        {
            try
            {
                var technologies = await _technologyService.GetAllTechnologiesSevice();
                return Ok(technologies);
            }
            catch (Exception ex)
            {
                // Handle the exception here and return an appropriate response
                return StatusCode(500, $"An error occurred while retrieving technologies: {ex.Message}");
            }
        }
    }
}
