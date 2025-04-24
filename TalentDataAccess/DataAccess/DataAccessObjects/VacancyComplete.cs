using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentDataAccess.DataAccess.DataAccessObjects
{

    [Table("VacancyComplete", Schema = "TalentenPortaal")]
    public class VacancyComplete
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Region { get; set; }

        [ForeignKey("VacancyOffer")]
        public int? VacancyOfferId { get; set; }
        public VacancyOffer VacancyOffer { get; set; }

        [ForeignKey("VacancyDemand")]
        public int? VacancyDemandId { get; set; }
        public VacancyDemand VacancyDemand { get; set; }

        [ForeignKey("VacancyDemandDetail")]
        public int? VacancyDemandDetailId { get; set; }
        public VacancyDemandDetail VacancyDemandDetail { get; set; }

        [ForeignKey("VacancyText")]
        public int? VacancyTextId { get; set; }
        public VacancyText VacancyText { get; set; }

        [ForeignKey("Company")]
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime Created { get; set; }

    }
}
