using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOFileBase64
    {
        public string Base64 { get; set; }

        public string Extension { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;
        public bool HasErrors { get; set; } = false;
        public string ErrorMessage { get; set; } = string.Empty;

    }

}
