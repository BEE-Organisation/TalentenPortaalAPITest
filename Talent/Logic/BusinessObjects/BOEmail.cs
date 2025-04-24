using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOEmail
    {

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public int TargetCompanyId { get; set; }

        public int VacancyId { get; set; }

        public string? Attachment { get; set; }

    }

}
