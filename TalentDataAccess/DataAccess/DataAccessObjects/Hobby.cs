using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("Hobby", Schema = "TalentenPortaal")]
    public class Hobby
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Order { get; set; }
        public int TalentId { get; set; }
    }

}
