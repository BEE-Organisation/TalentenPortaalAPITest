using BlobStorage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentBackend.Models;
using TalentBackend.Validation;

namespace TalentBackend.Controllers
{

    //[Authorize(Roles = "ADMIN")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FileManagementController : ControllerBase
    {
        private readonly IAzureBlobStorage _azureBlobStorage;

        public FileManagementController(IAzureBlobStorage azureBlobStorage)
        {
            _azureBlobStorage = azureBlobStorage;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("GetAllFileNames")]
        public async Task<IActionResult> GetAllFileNames()
        {
            try
            {
                List<CloudFiles> list = new List<CloudFiles>();

                List<AzureBlobItem> allBlobs = await _azureBlobStorage.ListAsync();

                foreach (var item in allBlobs)
                {
                    CloudFiles cf = new CloudFiles();
                    cf.Filename = item.BlobName;
                    cf.Directory = item.Folder;
                    cf.Extension = HelpersBase64.GetFileExtension(item.BlobName).ToLower();

                    list.Add(cf);
                }

                return Ok(list);
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

    }

}