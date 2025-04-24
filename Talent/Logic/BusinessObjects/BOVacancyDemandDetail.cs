using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentLogic.Logic.BusinessObjects
{
    public class BOVacancyDemandDetail
    {

        public int? Id { get; set; }

        //Contains properties.
        public List<BOTalentPropertyLabel> Properties { get; set; }

    }
}
