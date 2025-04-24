using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOTalentPropertyMainCategory
    {
        public int? Id { get; set; }
        public int? TalentPropertyLabelId { get; set; }
        public string TalentPropertyLabelName { get; set; } 
        public List<BOTalentPropertySubCategory> TalentPropertySubCategoryLinks { get; set; }
        public int TalentId { get; set; }

    }

}
