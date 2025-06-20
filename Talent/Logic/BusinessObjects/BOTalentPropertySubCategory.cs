using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOTalentPropertySubCategory
    {
        public int? Id { get; set; }
        public int? TalentPropertyLabelId { get; set; }
        public string TalentPropertyLabelName { get; set; }

        [Range(-1, 5)]
        public int SkillLevel { get; set; }
        public int Order { get; set; }
        public int? MainCategoryId { get; set; }
        public int SkillTypeId { get; set; }
        public string SkillTypeName { get; set; }

    }
}
