namespace TalentBackend.Models
{
    public class PdfBase64Model
    {

        public int Id { get; set; }

        public string Base64 { get; set; } = string.Empty;

        public string Extension { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;
        public bool HasErrors { get; set; } = false;

        public string ErrorMessage { get; set; } = string.Empty;

    }
}