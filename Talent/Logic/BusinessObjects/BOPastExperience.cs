using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOPastExperience
    {
        public int? Id { get; set; }
        public string DateFrom { get; set; } = string.Empty;
        public string DateTill { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Function { get; set; } = string.Empty;
        public List<string> Tasks { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public int TalentId { get; set; }

    }
}
