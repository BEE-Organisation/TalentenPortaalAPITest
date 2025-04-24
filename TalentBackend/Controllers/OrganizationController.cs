using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using TalentLogic.Logic.BusinessObjects;
using TalentLogic.Logic.Crud.ReadOnly;

namespace TalentBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationCrud _organizationCrud;
        
        public OrganizationController(IOrganizationCrud organizationCrud)
        {
            _organizationCrud = organizationCrud;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetAllOrganizations")]
        public async Task<IActionResult> GetAllOrganizations()
        {
            try
            {
                var records = await _organizationCrud.GetAllOrganizations();
                return Ok(records);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetOrganizationById")]
        public async Task<IActionResult> GetOrganizationById(int id)
        {
            try
            {
                var record = await _organizationCrud.GetOrganizationById(id);
                return Ok(record);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("CreateOrganization")]
        public async Task<IActionResult> CreateOrganization([FromBody] BOOrganization bo)
        {
            try
            {
                await _organizationCrud.CreateOrganization(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPut("UpdateOrganization")]
        public async Task<IActionResult> UpdateOrganization([FromBody] BOOrganization bo)
        {
            try
            {
                await _organizationCrud.UpdateOrganization(bo);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete("DeleteOrganization")]
        public async Task<IActionResult> DeleteOrganization(int id)
        {
            try
            {
                await _organizationCrud.DeleteOrganization(id);
                return Ok();
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        [AllowAnonymous]
        [HttpGet("GetOrganizationStyle")]
        public async Task<IActionResult> GetOrganizationStyle()
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

                var records = await _organizationCrud.GetOrganizationStyle(organization);
                return Ok(records);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }


    }
}
