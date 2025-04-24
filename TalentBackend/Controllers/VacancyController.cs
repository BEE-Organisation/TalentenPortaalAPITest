using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using TalentDataAccess.DataAccess.Repositories;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud;

namespace TalentBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        private readonly IVacancyCompleteCrud _vacancyCompleteCrud;

        public VacancyController(IVacancyCompleteCrud vacancyCompleteCrud)
        {
            _vacancyCompleteCrud = vacancyCompleteCrud;
        }

        [AllowAnonymous]
        [HttpGet("GetAllVacancies")]
        public async Task<IActionResult> GetAllVacancies()
        {
            try
            {
                var items = await _vacancyCompleteCrud.GetAllVacancies();
                return Ok(items);
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
                var items = await _vacancyCompleteCrud.GetList(pageNumber, sortField, sortOrder, pageSize);
                return Ok(items);
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
                var items = await _vacancyCompleteCrud.GetFilteredList(pageNumber, sortField, sortOrder, pageSize, filters);
                return Ok(items);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpGet("GetAllVacanciesByCompany")]
        public async Task<IActionResult> GetAllVacanciesByCompany([FromQuery] int[] organizationIds)
        {
            try
            {
                var items = await _vacancyCompleteCrud.GetAllVacanciesByCompany(organizationIds);
                return Ok(items);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [AllowAnonymous]
        [HttpGet("GetVacancybyId")]
        public async Task<IActionResult> GetVacancybyId(int id)
        {
            try
            {
                var item = await _vacancyCompleteCrud.GetVacancyCompleteById(id);
                return Ok(item);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpPost("CreateVacancy")]
        public async Task<IActionResult> CreateVacancy(BOVacancyComplete bo)
        {
            try
            {
                await _vacancyCompleteCrud.CreateVacancyComplete(bo);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest("Something went wrong." + ex.Message);
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpPut("UpdateVacancy")]
        public async Task<IActionResult> UpdateVacancy(BOVacancyComplete bo)
        {
            try
            {
                await _vacancyCompleteCrud.UpdateVacancyComplete(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpDelete("DeleteVacancy")]
        public async Task<IActionResult> DeleteVacancy(int id)
        {
            try
            {
                await _vacancyCompleteCrud.DeleteVacancyComplete(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

    }


}
