using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOOrganization
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public Theme Theme { get; set; } = Theme.DEFAULT;
        public string? StyleSheet { get; set; }

    }
}
