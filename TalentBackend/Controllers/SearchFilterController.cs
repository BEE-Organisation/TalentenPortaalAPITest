using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentLogic.Logic.Crud;

namespace TalentBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SearchFilterController : ControllerBase
    {
        private readonly ISearchFilterCrud _searchFilterCrud;
        private readonly IVacancyCompleteCrud _vacancyCompleteCrud;

        public SearchFilterController(ISearchFilterCrud searchFilterCrud, IVacancyCompleteCrud vacancyCompleteCrud)
        {
            _searchFilterCrud = searchFilterCrud;
            _vacancyCompleteCrud = vacancyCompleteCrud;
        }

        [AllowAnonymous]
        [HttpGet("GetAllFiltersTalents")]
        public async Task<IActionResult> GetAllFiltersTalents()
        {
            try
            {
                var data = await _searchFilterCrud.GetSearchFiltersTalents();
                return Ok(data);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }            
        }

        [AllowAnonymous]
        [HttpGet("GetAllFiltersVacancies")]
        public async Task<IActionResult> GetAllFiltersVacancies()
        {
            try
            {
                var data = await _searchFilterCrud.GetSearchFiltersVacancies();
                return Ok(data);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }


    }
}
