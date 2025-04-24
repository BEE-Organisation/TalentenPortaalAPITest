using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("TalentPropertyLabel", Schema = "TalentenPortaal")]
    public class TalentPropertyLabel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? ParentId { get; set; } = null;

    }
}
