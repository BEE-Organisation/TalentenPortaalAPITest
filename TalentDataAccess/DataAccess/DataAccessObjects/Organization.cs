using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    public enum Theme
    {
        [EnumMember(Value = "default")]
        DEFAULT = 0,
        [EnumMember(Value = "leerwerkloket")]
        LEERWERKLOKET = 1,
        [EnumMember(Value = "auto")]
        AUTO = 100
    }

    [Table("Organization", Schema = "TalentenPortaal")]
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public Theme Theme { get; set; } = Theme.DEFAULT;

    }
}
