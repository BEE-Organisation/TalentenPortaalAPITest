using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("TalentPropertySubCategoryLink", Schema = "TalentenPortaal")]
    public class TalentPropertySubCategoryLink
    {
        [Key]
        public int Id { get; set; }
        public int TalentPropertyLabelId { get; set; }

        [Range(-1, 5)]
        public int SkillLevel { get; set; }
        public int Order { get; set; }

        //[ForeignKey("TalentPropertyMainCategoryLink")]
        //public int TalentPropertyMainCategoryLinkId { get; set; }
        
        public TalentPropertyMainCategoryLink TalentPropertyMainCategoryLink { get; set; }

    }
}
