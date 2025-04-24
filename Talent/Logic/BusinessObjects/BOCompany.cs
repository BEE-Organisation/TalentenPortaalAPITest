using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOCompany
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string CompanyLogoUrl { get; set; }

        public string? Creator { get; set; } = string.Empty;

        public string? Email { get; set; } = string.Empty;
    }

}
