using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud;

namespace TalentBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TalentPropertyController : ControllerBase
    {
        private readonly ITalentPropertyCrud _talentPropertyCrud;

        public TalentPropertyController(ITalentPropertyCrud talentPropertyCrud)
        {
            _talentPropertyCrud = talentPropertyCrud;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetAllByTalentId")]
        public async Task<IActionResult> GetAllByTalentId(int talentId)
        {
            try
            {
                var record = await _talentPropertyCrud.GetAllByTalentId(talentId);                
                return Ok(record);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("CreateTalentProperties")]
        public async Task<IActionResult> CreateTalentProperties([FromBody] List<BOTalentPropertyMainCategory> entities)
        {
            try
            {
                await _talentPropertyCrud.CreateTalentProperties(entities);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("CreateTalentProperty")]
        public async Task<IActionResult> CreateTalentProperty([FromBody] BOTalentPropertyMainCategory entity)
        {
            try
            {
                await _talentPropertyCrud.CreateTalentProperty(entity);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("UpdateTalentProperties")]
        public async Task<IActionResult> UpdateTalentProperties([FromBody] List<BOTalentPropertyMainCategory> entities)
        {
            try
            {
                await _talentPropertyCrud.UpdateTalentProperties(entities);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("UpdateTalentProperty")]
        public async Task<IActionResult> UpdateTalentProperty([FromBody] BOTalentPropertyMainCategory entity)
        {
            try
            {
                await _talentPropertyCrud.UpdateTalentProperty(entity);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

    }

}
