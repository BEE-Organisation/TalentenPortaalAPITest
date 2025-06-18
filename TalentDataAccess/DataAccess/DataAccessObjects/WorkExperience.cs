using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CrossCuttingConcerns.EntityFrameworkGenerics;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{
    [Table("WorkExperience", Schema = "TalentenPortaal")]
    public class WorkExperience : IEntity
    {
        [Key]
        public int Id { get; set; }
        // Is this correct?
        public int TalentCVId { get; set; }
        public string FromDate { get; set; } = string.Empty;
        public string UntilDate { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string FunctionName { get; set; } = string.Empty;
    }
}
