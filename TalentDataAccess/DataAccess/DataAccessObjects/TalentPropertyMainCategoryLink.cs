using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("TalentPropertyMainCategoryLink", Schema = "TalentenPortaal")]
    public class TalentPropertyMainCategoryLink
    {
        [Key]
        public int Id { get; set; }
        public int TalentPropertyLabelId { get; set; }
        public ICollection<TalentPropertySubCategoryLink> TalentPropertySubCategoryLinks { get; set; } 
        public int TalentId { get; set; }

    }

}
