using System.Text.RegularExpressions;
using Path = System.IO.Path;

namespace TalentBackend.Validation
{
    public class VideoValidator
    {

        public static bool IsCorrectVideo(IFormFile formFile)
        {
            //  Check the Video mime types
            //-------------------------------------------
            if (formFile.ContentType.ToLower() != "video/mp4")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the Video extension
            //-------------------------------------------

            if (Path.GetExtension(formFile.FileName).ToLower() != ".mp4")
            {
                return false;
            }

            //-------------------------------------------
            //  Attempt to read the file and check the first bytes
            //-------------------------------------------

            try
            {
                if (!formFile.OpenReadStream().CanRead)
                {
                    return false;
                }

                int sizeOfFile = (int)formFile.Length;
                byte[] buffer = new byte[sizeOfFile];
                formFile.OpenReadStream().Read(buffer, 0, sizeOfFile);

                string content = System.Text.Encoding.UTF8.GetString(buffer);

                if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                    RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

    }
}
