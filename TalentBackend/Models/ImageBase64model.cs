namespace TalentBackend.Models
{
    public class ImageBase64model
    {

        public int Id { get; set; }

        public string Base64 { get; set; } = string.Empty;

        public string Extension { get; set; } = string.Empty;

    }
}
