using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateCompanies
    {

        public static List<Company> Create()
        {
            return new List<Company>
            {
                new Company()
                {
                    Id = 1,
                    Name = "Gemeente Dinodrecht",
                    Description = "De gemeente Dinodrecht is altijd op zoek naar nieuwe IT'ers.",
                    CompanyLogoUrl = "https://beeideasstorage.blob.core.windows.net/talentenportaal/company-logos/gemeente_dinodrecht.png",
                    Creator = "", //ADMIN,
                    Email = "gemeente@dinodrecht.nl",
                },
                new Company()
                {
                    Id = 2,
                    Name = "White Seal IT Detachering",
                    Description = "Regelmatig is White Seal IT Detachering op zoek naar nieuwe IT talenten.",
                    CompanyLogoUrl = "https://beeideasstorage.blob.core.windows.net/talentenportaal/company-logos/white_seal_it_detachering.jpg",
                    Creator = "", //ADMIN
                    Email = "algemeen@white-seals.nl",
                },
                new Company()
                {
                    Id = 3,
                    Name = "WVU Werkbedrijf",
                    Description = "Het WVU Werkbedrijf is een organisatie die personen zal begeleiden naar een werkplaats binnen de IT-wereld.",
                    CompanyLogoUrl = "https://beeideasstorage.blob.core.windows.net/talentenportaal/company-logos/vwu_werkbedrijf.png",
                    Creator = "", //ADMIN
                    Email = "contact@wvu-werkbedrijf.nl",
                },

            };
        }

    }

}
