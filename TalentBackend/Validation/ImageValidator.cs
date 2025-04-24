using System.Text.RegularExpressions;
using Path = System.IO.Path;

namespace TalentBackend.Validation
{
    public class ImageValidator
    {
        private const int MaxByteSize = 1024;

        public static bool IsCorrectImage(IFormFile formFile)
        {
            //  Check the image mime types
            //-------------------------------------------
            if (formFile.ContentType.ToLower() != "image/jpg" &&
                        formFile.ContentType.ToLower() != "image/jpeg" &&
                        formFile.ContentType.ToLower() != "image/pjpeg" &&
                        formFile.ContentType.ToLower() != "image/gif" &&
                        formFile.ContentType.ToLower() != "image/x-png" &&
                        formFile.ContentType.ToLower() != "image/png")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the image extension
            //-------------------------------------------
            if (Path.GetExtension(formFile.FileName).ToLower() != ".jpg"
                && Path.GetExtension(formFile.FileName).ToLower() != ".png"
                && Path.GetExtension(formFile.FileName).ToLower() != ".gif"
                && Path.GetExtension(formFile.FileName).ToLower() != ".jpeg")
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
                //------------------------------------------
                //check whether the image size exceeding the limit or not
                //------------------------------------------ 
                if (formFile.Length < MaxByteSize)
                {
                    return false;
                }

                byte[] buffer = new byte[MaxByteSize];
                formFile.OpenReadStream().Read(buffer, 0, MaxByteSize);
                string content = System.Text.Encoding.UTF8.GetString(buffer);
                if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                    RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}