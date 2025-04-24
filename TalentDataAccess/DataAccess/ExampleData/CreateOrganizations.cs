using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateOrganizations
    {

        public static List<Organization> Create()
        {
            List<Organization> list = new List<Organization>();

            string[] names = new string[] 
            {
                "Talenten-Portaal",
                "Leer/Werk Loket",
                "UWV",
                "WSP",
                "Bee",
            };

            string[] descriptions = new string[]
            {
                "Talenten-Portaal zorgt voor begeleiding naar werk in de IT-Sector.",
                "Het Leer/Werk Loket zorgt voor begeleiding naar werk in de IT-Sector.",
                "Het UWV (Uitvoeringsinstituut Werknemersverzekeringen) is een betrokken partij die kandidaten ondersteunen in het vinden van werk.",
                "WSP staat beter bekend als het WerkgeversServicepunt en geeft werkgevers advies en ondersteuning bij de werving en selectie van personeel.",
                "De Bee-Organisatie leidt IT-professionals op. Ook is er begeleiding naar werk.",
            };

            Theme[] themes = new Theme[] 
            {
                Theme.DEFAULT,
                Theme.LEERWERKLOKET,
                Theme.DEFAULT,
                Theme.DEFAULT,
                Theme.DEFAULT
            };

            for (int i = 0; i < names.Length; i++)
            {
                Organization organization = new Organization();
                organization.Id = i + 1;
                organization.Name = names[i];
                organization.Description = descriptions[i];
                organization.Theme = themes[i];

                list.Add(organization);
            }

            return list;
        }

    }
}
