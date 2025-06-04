using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CrossCuttingConcerns.EntityFrameworkGenerics;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{
    [Table("EducationDetail", Schema = "TalentenPortaal")]
    public class EducationDetail : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateOnly? DateFrom { get; set; } = DateOnly.MinValue;
        public DateOnly? DateTill { get; set; } = DateOnly.MaxValue;
        public string Name { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public int TalentId { get; set; }

    }
}
