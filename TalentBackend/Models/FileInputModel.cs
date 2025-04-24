namespace TalentBackend.Models
{
    public class FileInputModel
    {
        public string Folder { get; set; } = string.Empty;
        public IFormFile File { get; set; }
    }
}
