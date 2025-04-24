using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentLogic.Logic;

namespace TalentBackend.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ICVService _cvService;

        public DashboardController(
            ICVService cvService)
        {
            _cvService = cvService;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetDashBoardInfo")]
        public async Task<IActionResult> GetDashBoardInfo()
        {
            try
            {
                var dashBoardInfo = await _cvService.GetDashBoardInfo().ConfigureAwait(false);
                return Ok(dashBoardInfo);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }            
        }

    }
}