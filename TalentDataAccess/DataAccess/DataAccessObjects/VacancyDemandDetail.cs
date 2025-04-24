using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("VacancyDemandDetail", Schema = "TalentenPortaal")]
    public class VacancyDemandDetail
    {
        [Key]
        public int Id { get; set; }

        public int[] ParentProperties { get; set; } = new int[] { };

        public int[] ChildProperties { get; set; } = new int[] { };

    }

}
