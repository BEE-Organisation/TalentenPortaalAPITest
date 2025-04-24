using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("VacancyText", Schema = "TalentenPortaal")]
    public class VacancyText
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; } = string.Empty;

        public bool ShowCompanyInfo { get; set; }

    }

}
