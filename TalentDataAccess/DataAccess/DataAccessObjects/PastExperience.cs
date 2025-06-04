using CrossCuttingConcerns.EntityFrameworkGenerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("PastExperience", Schema = "TalentenPortaal")]
    public class PastExperience : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateOnly? DateFrom { get; set; } = DateOnly.MinValue;
        public DateOnly? DateTill { get; set; } = DateOnly.MaxValue;
        public string Company { get; set; } = string.Empty;
        public string Function { get; set; } = string.Empty;

        //Note: Tasks & Description for more details about the PastExperience.
        public List<string> Tasks { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public int TalentId { get; set; }

    }
}
