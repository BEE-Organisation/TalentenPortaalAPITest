using BlobStorage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TalentBackend.Models;
using TalentBackend.Validation;
using TalentLogic.Logic.BusinessObjects;

namespace TalentBackend.Controllers
{
    //[Authorize(Roles = "ADMIN")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json", "application/json-patch+json","multipart/form-data")]
    public class FileController : ControllerBase
    {
        private readonly IAzureBlobStorage _blobStorage;

        public FileController(IAzureBlobStorage blobStorage)
        {
            _blobStorage = blobStorage;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("UploadImageFile")]
        public async Task<IActionResult> UploadImageFile([FromForm]IFormFile file)
        {
            if (file == null)
                return Content("Argument null");

            if (file.Length == 0)
                return Content("File not selected!");

            if (!ImageValidator.IsCorrectImage(file))
            {
                return Content("File not image or too large!");
            }

            var blobName = file.GetFilename();
            var fileStream = await file.GetFileStream();


            blobName = $@"{"images"}\{blobName}";

            await _blobStorage.UploadAsync(blobName, fileStream);

            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("ImportImageFiles")]
        public async Task<IActionResult> ImportImageFiles([FromForm] List<IFormFile> files)
        {
            foreach (var file in files)
            {
                if (file == null)
                    return Content("Argument null");

                if (file.Length == 0)
                    return Content("File not selected!");

                if (!ImageValidator.IsCorrectImage(file))
                {
                    return Content("File not image or too large!");
                }

                var blobName = file.GetFilename();
                var fileStream = await file.GetFileStream();

                blobName = $@"{"images"}\{blobName}";

                await _blobStorage.UploadAsync(blobName, fileStream);
            }

            return Ok();
        }

        [Authorize(Roles = "ADMIN, VACANCY_CREATOR")]
        [HttpPost("UploadCompanyLogo")]
        public async Task<IActionResult> UploadCompanyLogo([FromForm] IFormFile file)
        {
            if (file == null)
                return Content("Argument null");

            if (file.Length == 0)
                return Content("File not selected!");

            if (!ImageValidator.IsCorrectImage(file))
            {
                return Content("File not image or too large!");
            }

            var blobName = file.GetFilename();
            var fileStream = await file.GetFileStream();

            blobName = $@"{"company-logos"}\{blobName}";

            await _blobStorage.UploadAsync(blobName, fileStream);

            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("UploadCvFile")]
        public async Task<IActionResult> UploadCvFile([FromForm]IFormFile file)
        {
            if (file == null)
                return Content("Argument null");

            if (file.Length == 0)
                return Content("file not selected");


            if (!PdfValidator.IsCorrectPdf(file))
            {
                return Content("File not PDF or too large!");
            }

            var blobName = file.GetFilename();
            var fileStream = await file.GetFileStream();


            blobName = $@"{"cvitems"}\{blobName}";

            await _blobStorage.UploadAsync(blobName, fileStream);

            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("ImportCvFiles")]
        public async Task<IActionResult> ImportCvFiles([FromForm] IList<IFormFile> files)
        {
            foreach (var file in files)
            {
                if (file == null)
                    return Content("Argument null");

                if (file.Length == 0)
                    return Content("file not selected");

                if (!PdfValidator.IsCorrectPdf(file))
                {
                    return Content("File not PDF or too large!");
                }

                var blobName = file.GetFilename();
                var fileStream = await file.GetFileStream();

                blobName = $@"{"cvitems"}\{blobName}";

                await _blobStorage.UploadAsync(blobName, fileStream);
            }

            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("UploadVideoFile")]
        public async Task<IActionResult> UploadVideoFile([FromForm] IFormFile file)
        {
            if (file == null)
                return Content("Argument null");

            if (file.Length == 0)
                return Content("File not selected!");

            if (!VideoValidator.IsCorrectVideo(file))
            {
                return Content("File not video or too large!");
            }

            var blobName = file.GetFilename();
            var fileStream = await file.GetFileStream();

            blobName = $@"{"temp-videos"}\{blobName}";

            await _blobStorage.UploadAsync(blobName, fileStream);

            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("ImportVideoFiles")]
        public async Task<IActionResult> ImportVideoFiles([FromForm] IList<IFormFile> files)
        {
            foreach (var file in files)
            {
                if (file == null)
                    return Content("Argument null");

                if (file.Length == 0)
                    return Content("file not selected");

                if (!VideoValidator.IsCorrectVideo(file))
                {
                    return Content("File not Video or too large!");
                }

                var blobName = file.GetFilename();
                var fileStream = await file.GetFileStream();

                blobName = $@"{"cvitems"}\{blobName}";

                await _blobStorage.UploadAsync(blobName, fileStream);
            }

            return Ok();
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("UploadVideoChunk")]
        //public async Task<IActionResult> UploadVideoChunk([FromBody] ChunkData data)
        public async Task<IActionResult> UploadVideoChunk([FromForm] IFormFile file)
        {
            ChunkDataStatus status = new();

            try
            {
                var blobName = file.GetFilename();
                var fileStream = await file.GetFileStream();

                blobName = $@"{"chunks"}\{blobName}";

                await _blobStorage.UploadAsync(blobName, fileStream);
                status.IsUploaded = true;
            }
            catch
            {
                status.IsUploaded = false;
            }

            return Ok(status);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("ConcatenateVideoChunks")]
        public async Task<IActionResult> ConcatenateVideoChunks([FromBody] ChunkData data)
        {
            ChunkDataStatus status = new();

            try
            {
                List<string> chunks = data.AllChunkIds;

                MemoryStream ms = new MemoryStream();

                foreach (string chunkId in chunks)
                {
                    var chunkName = $@"{"chunks"}\{chunkId}";
                    //await here.
                    var stream = await _blobStorage.DownloadAsync(chunkName);

                    if (stream != null)
                    {
                        stream.Position = 0;
                        //stream.CopyTo(ms, 2097152);

                        //TODO: This is not working yet ....
                        ms.Write(stream.GetBuffer(), 0, (int)stream.Length);
                    }
                }

                var blobName = $@"{"videos"}\{data.FileName}";

                //await here
                await _blobStorage.UploadAsync(blobName, ms);
                status.IsUploaded = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status.IsUploaded = false;
            }

            return Ok(status);
        }


        [Authorize(Roles = "ADMIN")]
        [HttpGet("DownloadImage")]
        public async Task<IActionResult> DownloadImage(string blobName, string name)
        {
            if (string.IsNullOrEmpty(blobName))
                return Content("Blob DisplayName not present");

            var stream = await _blobStorage.DownloadAsync(blobName);
            return File(stream.ToArray(), "application/octet-stream", name);
        }


        [Authorize(Roles = "ADMIN, VACANCY_CREATOR, USER")]
        [HttpGet("DownloadFile")]
        public async Task<BOFileBase64> DownloadFile(string blobName)
        {
            BOFileBase64 bo = new BOFileBase64();

            try
            {
                if (string.IsNullOrEmpty(blobName))
                {
                    throw new Exception("Filename is null or empty.");
                }

                MemoryStream ms = await _blobStorage.DownloadAsync(blobName);
                string base64 = Convert.ToBase64String(ms.ToArray());

                bo.Base64 = base64;
                bo.FileName = HelpersBase64.GetFileNameFromPath(blobName);
                bo.Extension = HelpersBase64.GetFileExtension(blobName);
                bo.HasErrors = false;
            }
            catch
            {
                bo.HasErrors = true;
                bo.ErrorMessage = "Unable to fetch file.";
            }

            return bo;
        }


        [Authorize(Roles = "ADMIN")]
        [HttpDelete("DeleteImage")]
        public async Task<IActionResult> DeleteImage(string blobName)
        {
            if (string.IsNullOrEmpty(blobName))
                return Content("Blob DisplayName not present");

            await _blobStorage.DeleteAsync(blobName);

            return Ok();
        }

    }
}