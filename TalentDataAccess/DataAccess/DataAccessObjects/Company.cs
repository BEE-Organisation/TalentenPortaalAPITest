using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{
    [Table("Company", Schema = "TalentenPortaal")]
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string CompanyLogoUrl { get; set; }

        public string Creator { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

    }

}
