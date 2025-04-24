using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud;

namespace TalentBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CompanyController : ControllerBase
    {
        private readonly ICompanyCrud _companyCrud;

        public CompanyController(ICompanyCrud companyCrud)
        {
            _companyCrud = companyCrud;
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpGet("GetCompanyById")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            try
            {
                var item = await _companyCrud.GetCompanyById(id);
                return Ok(item);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetAllCompanies")]
        public async Task<IActionResult> GetAllCompanies()
        {
            try
            {
                var items = await _companyCrud.GetAllCompanies();
                return Ok(items);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "VACANCY_CREATOR")]
        [HttpGet("GetAllCompaniesById")]
        public async Task<IActionResult> GetAllCompaniesById(string keycloakId)
        {
            try
            {
                var items = await _companyCrud.GetAllCompaniesById(keycloakId);
                return Ok(items);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpPost("CreateCompany")]
        public async Task<IActionResult> CreateCompany(BOCompany bo)
        {
            try
            {
                await _companyCrud.CreateCompany(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpPut("UpdateCompany")]
        public async Task<IActionResult> UpdateCompany(BOCompany bo)
        {
            try
            {
                await _companyCrud.UpdateCompany(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpDelete("DeleteCompany")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            try
            {
                var result = await _companyCrud.DeleteCompany(id);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


    }
}
