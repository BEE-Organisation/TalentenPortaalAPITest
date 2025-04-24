using Microsoft.Net.Http.Headers;

namespace TalentBackend.Models
{
    public static class IFormFileExtensions
    {
        public static string GetFilename(this IFormFile file)
        {
            return ContentDispositionHeaderValue.Parse(
                file.ContentDisposition).FileName.ToString().Trim('"');
        }

        public static async Task<MemoryStream> GetFileStream(this IFormFile file)
        {
            var fileStream = new MemoryStream();
            await file.CopyToAsync(fileStream);
            return fileStream;
        }

        public static async Task<byte[]> GetFileArray(this IFormFile file)
        {
            var fileStream = new MemoryStream();
            await file.CopyToAsync(fileStream);
            return fileStream.ToArray();
        }
    }
}
