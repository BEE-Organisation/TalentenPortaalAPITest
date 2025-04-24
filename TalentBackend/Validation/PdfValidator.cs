using System.Text.RegularExpressions;
using TalentLogic.Logic.BusinessObjects;
using Path = System.IO.Path;

namespace TalentBackend.Validation
{
    public class PdfValidator
    {

        private static int MAX_SIZE = 10 * (1024 * 1024);

        public static bool IsCorrectPdf(string base64)
        {
            int position001 = base64.IndexOf(";base64,");
            string part = base64.Substring(0, position001);
            part = part.Replace("data:" ,"").Trim();

            if(part.ToLower().Equals("application/pdf"))                
            {
                return true;
            }

            return false;;
        }

        public static bool IsCorrectPdf(byte[] bytes)
        {
            if(bytes.Length < 4)
            {
                return false;
            }
            int stopBefore = Math.Min(bytes.Length, 1024) - 3;

            for (var i = 0; i < stopBefore; i++)
            {
                if (bytes[i] == '%' && bytes[i + 1] == 'P' && bytes[i + 2] == 'D' && bytes[i + 3] == 'F')
                {
                    if(bytes.Length < MAX_SIZE)
                    {
                        return true;
                    }                    
                }
            }

            return false;
        }

        public static bool IsCorrectPdf(IFormFile formFile)
        {
            //  Check the PDF mime types
            //-------------------------------------------
            if (formFile.ContentType.ToLower() != "application/pdf")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the PDF extension
            //-------------------------------------------

            if (Path.GetExtension(formFile.FileName).ToLower() != ".pdf")
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

                int sizeOfFile = (int) formFile.Length;
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
