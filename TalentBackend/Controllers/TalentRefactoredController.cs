using TalentLogic.Logic.Crud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Primitives;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;

namespace TalentBackend.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TalentRefactoredController : ControllerBase
    {

        private readonly ITalentRefactoredCrud _talentRefactoredCrud;

        public TalentRefactoredController(ITalentRefactoredCrud talentRefactoredCrud)
        {
            _talentRefactoredCrud = talentRefactoredCrud;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetById")]        
        public async Task<IActionResult> GetById(int id)
        {
            try
                {
                var record = await _talentRefactoredCrud.GetById(id);
                return Ok(record);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [AllowAnonymous]
        [HttpGet("GetByIdAndOrganization")]
        public async Task<IActionResult> GetByIdAndOrganization(int id)
        {
            try
            {
                StringValues result = "";
                bool getHeader = Request.Headers.TryGetValue("organization", out result);
                int organization = 0;

                if (getHeader)
                {
                    int.TryParse(result.ToString(), out organization);
                }

                var record = await _talentRefactoredCrud.GetByIdAndOrganization(id, organization);
                return Ok(record);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var records = await _talentRefactoredCrud.GetAll();
                return Ok(records);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR, USER, REGISTERED")]
        [HttpGet("GetAllFavourites")]
        public async Task<IActionResult> GetAllFavourites([FromQuery(Name = "favourites")] int[] favourites)
        {
            try
            {
                StringValues result = "";
                bool getHeader = Request.Headers.TryGetValue("organization", out result);
                int organization = 0;

                if (getHeader)
                {
                    int.TryParse(result.ToString(), out organization);
                }

                var records = await _talentRefactoredCrud.GetAllFavourites(favourites, organization);
                return Ok(records);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [AllowAnonymous]
        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList(int? pageNumber, string sortField, string sortOrder, int? pageSize)
        {
            try
            {
                StringValues result = "";
                bool getHeader = Request.Headers.TryGetValue("organization", out result);
                int organization = 0;

                if (getHeader)
                {
                   int.TryParse(result.ToString(), out organization);
                }

                var records = await _talentRefactoredCrud.GetPagedList(pageNumber, sortField, sortOrder, pageSize, organization);
                return Ok(records);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }
        
        [AllowAnonymous]
        [HttpGet("GetFilteredList")]
        public async Task<IActionResult> GetFilteredList(int? pageNumber, string sortField, string sortOrder, int? pageSize, [FromQuery] BOActiveSearchFilter filters)
        {
            try
            {
                StringValues result = "";
                bool getHeader = Request.Headers.TryGetValue("organization", out result);
                int organization = 0;

                if (getHeader)
                {
                    int.TryParse(result.ToString(), out organization);
                }

                var records = await _talentRefactoredCrud.GetFilteredList(pageNumber, sortField, sortOrder, pageSize, filters, organization);
                return Ok(records);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


        [Authorize(Roles = "ADMIN")]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] BOTalentRefactored bo)
        {
            try
            {
                await _talentRefactoredCrud.CreateTalent(bo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong." + ex.Message);
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] BOTalentRefactored bo)
        {
            try
            {
                await _talentRefactoredCrud.UpdateTalent(bo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong." + ex.Message);
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _talentRefactoredCrud.DeleteTalent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong." + ex.Message);
            }
        }

    }

}
