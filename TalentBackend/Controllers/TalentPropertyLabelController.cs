using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud.ReadOnly;

namespace TalentBackend.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TalentPropertyLabelController : ControllerBase
    {
        private readonly ITalentPropertyLabelCrud _talentPropertyLabelCrud;


        public TalentPropertyLabelController(ITalentPropertyLabelCrud talentPropertyLabelCrud)
        {
            _talentPropertyLabelCrud = talentPropertyLabelCrud;
        }


        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpGet("GetAllLabels")]
        public async Task<IActionResult> GetAllLabels()
        {
            try
            {
                var record = await _talentPropertyLabelCrud.GetAllLabels();
                return Ok(record);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


        [Authorize(Roles = "ADMIN")]
        [HttpPost("CreateLabel")]
        public async Task<IActionResult> CreateLabel(BOTalentPropertyLabel bo)
        {
            try
            {
                await _talentPropertyLabelCrud.CreateLabel(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


        [Authorize(Roles = "ADMIN")]
        [HttpPut("UpdateLabel")]
        public async Task<IActionResult> UpdateLabel(BOTalentPropertyLabel bo)
        {
            try
            {
                await _talentPropertyLabelCrud.UpdateLabel(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("DeleteLabel")]
        public async Task<IActionResult> DeleteLabel(int id)
        {
            try
            {
                await _talentPropertyLabelCrud.DeleteLabel(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


    }

}
