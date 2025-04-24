using BlobStorage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentBackend.Models;
using TalentBackend.Validation;
using TalentLogic.Logic;

namespace TalentBackend.Controllers
{
    //[Authorize(Roles = "ADMIN")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContentDeliveryNetworkController : ControllerBase
    {

        private readonly ICVService _cvService;
        private readonly IAzureBlobStorage _azureBlobStorage;

        public ContentDeliveryNetworkController(ICVService cvService, IAzureBlobStorage azureBlobStorage)
        {
            _cvService = cvService;
            _azureBlobStorage = azureBlobStorage;
        }

        [AllowAnonymous]
        [HttpGet("GetImagesAsBase64")]
        public async Task<IActionResult> GetImagesAsBase64()
        {
            List<ImageBase64model> list = new List<ImageBase64model>();

            var activeCvItems = await _cvService.GetAll().ConfigureAwait(false);

            foreach (var item in activeCvItems)
            {
                if (item.ProfilePhotoRef != null)
                {
                    try
                    {
                        string target = "images/" + HelpersBase64.GetFileNameFromPath(item.ProfilePhotoRef);
                        string extension = HelpersBase64.GetFileExtension(item.ProfilePhotoRef);
                        string base64 = "";

                        using (MemoryStream ms = await _azureBlobStorage.DownloadAsync(target))
                        {
                            base64 = Convert.ToBase64String(ms.ToArray());
                        }

                        list.Add(new ImageBase64model
                        {
                            Id = item.Id ?? 0,
                            Base64 = base64,
                            Extension = extension
                        });
                    }
                    catch {}
                }
            }

            return Ok(list);
        }

        [HttpGet("GetImageAsBase64ById")]
        public async Task<IActionResult> GetImageAsBase64ById(int id)
        {
            ImageBase64model imageBase64 = new ImageBase64model();

            try
            {
                var item = await _cvService.GetById(id).ConfigureAwait(false);

                if (item != null)
                {
                    string target = "images/" + HelpersBase64.GetFileNameFromPath(item.ProfilePhotoRef);
                    string extension = HelpersBase64.GetFileExtension(item.ProfilePhotoRef);
                    string base64 = "";

                    using (MemoryStream ms = await _azureBlobStorage.DownloadAsync(target))
                    {
                        base64 = Convert.ToBase64String(ms.ToArray());
                    }

                    imageBase64.Id = id;
                    imageBase64.Base64 = base64;
                    imageBase64.Extension = extension;
                }
            }
            catch
            {

            }

            return Ok(imageBase64);
        }

        //[HttpGet("GetPdfAsBase64")]
        //public async Task<IActionResult> GetPdfAsBase64(int id)
        //{
        //    PdfBase64Model data = new PdfBase64Model();

        //    var cvItem = await _cvService.GetById(id).ConfigureAwait(false);

        //    if (cvItem == null)
        //    {
        //        data.HasErrors = true;
        //        data.ErrorMessage = "Id doesn't exist.";

        //        return Ok(data);
        //    }

        //    try
        //    {
        //        string filename = HelpersBase64.GetFileNameFromPath(cvItem.CVDocumentRef);
        //        string target = "cvitems/" + HelpersBase64.GetFileNameFromPath(cvItem.CVDocumentRef);

        //        string extension = HelpersBase64.GetFileExtension(cvItem.CVDocumentRef);

        //        MemoryStream ms = await _azureBlobStorage.DownloadAsync(target);

        //        string base64 = Convert.ToBase64String(ms.ToArray());
        //        data.Id = cvItem.Id ?? 0;
        //        data.Base64 = base64;
        //        data.Extension = extension;
        //        data.FileName = filename;
        //        data.HasErrors = false;
        //    }
        //    catch
        //    {
        //        data.HasErrors = true;
        //        data.ErrorMessage = "Unable to fetch PDF.";
        //    }

        //    return Ok(data);
        //}

    }
}
