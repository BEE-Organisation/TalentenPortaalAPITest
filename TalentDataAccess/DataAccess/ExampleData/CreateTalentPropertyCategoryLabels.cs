using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateTalentPropertyCategoryLabels
    {

        public static List<TalentPropertyLabel> Create()
        {
            List<TalentPropertyLabel> list = new List<TalentPropertyLabel>();

            int index = 1;

            string[] mainProperties = new string[]
            {
                "HCM Competenties",
                "Talen",
                "Methoden & technieken",
                "Softwarepakketten & -tools",
                "Programmeer- & scriptingtalen",
                "Frameworks & databases",
                "Rijbewijs",
                "Karakterkenmerken",
                "Secundaire Arbeidsvoorwaarden"
            };

            string[] hcmCompetences = new string[]
            {
                "Proactiviteit",
                "Communicatieve vaardigheden",
                "Discipline",
                "Emotionele stabiliteit",
                "Integriteit",
                "Analytische kwaliteiten",
                "Creativiteit",
                "Beïnvloedende kwaliteiten",
                "Organisatorische kwaliteiten",
                "Leiderschapskwaliteiten",
            };

            string[] languages = new string[]
            {
                "Nederlands",
                "Engels",
                "Duits",
                "Frans",
                "Spaans"
            };     

            string[] methods = new string[]
            {
                "Agile",
                "Agile/Scrum",
                "Scrum",
                "OOP",
                "TDD",
                "VM Mangement",
                "Stakeholdermanagement",
                "Projectmanagement",
                "Software Development",
                "Productmanagement",
            };

            string[] tools = new string[]
            {
                "IntelliJ IDEA",
                "JetBrains",
                "VS Code",
                "Azure DevOps",
                "Visual Studio",
                "Visual Studio 2019",
                "Visual Studio 2022",
                "Godot",
                "Gdscript",
                "Adobe CC",
                "Npm",
                "Git",
                "Microsoft Office",
                "Webstorm",
            };

            string[] programmingLanguages = new string[] 
            {
                "C#",
                "C",
                "C++",
                "ASP.Net MVC",
                ".NET Core",
                "Java",
                "JavaScript",
                "TypeScript",
                "HTML 5",
                "HTML",
                "CSS",
                "CSS3",
                "SCSS/SASS",
                "PHP",
                "Visual Basic",
                "Python",
                "Delphi"
            };

            string[] frameworksAndDatabases = new string[]
            {
                "Angular",
                "MySQL",
                "SQL Server",
                "Mongo DB",
                "MongoDB",
                "VueJS",
                "NodeJS",
                "SQL",
                "MariaDB",
                "SQLite",
                "React.js",
                "Bootstrap",
                "Entity Framework",
                "Notes-Domino",
            };

            string[] driverLicences = new string[] 
            {
                "geen",
                "AM - Brommer",
                "A - Motor",
                "B - Personenauto",
                "BE - Auto met aanhanger",
                "C - Vrachtwagen",
                "CE - Vrachtwagen met aanhanger",
                "Code 95 - Heftruck"
            };

            string[] characterTraits = new string[]
            {
                "Creatief", //Changed this or leads to duplicate Names!
                "Nieuwsgierigheid",
                "Kritisch denken, beoordelingsvermogen",
                "Leergierigheid",
                "Levenswijs",
                "Moed",
                "Doorzettingsvermogen",
                "Oprechtheid",
                "Enthousiast/levenslustig",
                "Liefde",
                "Vriendelijkheid",
                "Sociale intelligentie",
                "Samenwerking",
                "Rechtvaardigheid",
                "Leiderschap",
                "Vergevingsgezindheid",
                "Bescheidenheid",
                "Bedachtzaam",
                "Zelfregulatie",
                "Waardering van schoonheid en excellentie",
                "Dankbaarheid",
                "Hoopvol",
                "Humor",
                "Spiritualiteit"
            };

            string[] jobConditions = new string[]
            {
                "Auto van de zaak",
                "Lease-auto",
                "Telefoon",
                "Mobiele telefoon",
                "Pensioenopbouw",
                "Leuke uitjes",
                "Vrijdagmiddagborrels",
                "Dertiende maand",
                "Flexibele uren"
            };

            int? parentOfMain = null;
            int parentOfHcmCompetences = 1;
            int parentOfLanguages = 2;
            int parentOfMethods = 3;
            int parentOfTools = 4;
            int parentOfProgrammingLanguages = 5;
            int parentOfFrameworksAndDatabases = 6;
            int parentOfDriverLicences = 7;
            int parentOfCharacterTraits = 8;
            int parentJobConditions = 9;

            foreach (var mainProperty in mainProperties)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = mainProperty,
                      ParentId = parentOfMain
                  }
                );

                index++;
            }

            foreach (var hcmCompetence in hcmCompetences)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = hcmCompetence,
                      ParentId = parentOfHcmCompetences
                  }
                );

                index++;
            }

            foreach (var language in languages)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = language,
                      ParentId = parentOfLanguages
                  }
                );

                index++;
            }

            foreach (var method in methods)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = method,
                      ParentId = parentOfMethods
                  }
                );

                index++;
            }

            foreach (var tool in tools)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = tool,
                      ParentId = parentOfTools
                  }
                );

                index++;
            }

            foreach (var programmingLanguage in programmingLanguages)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = programmingLanguage,
                      ParentId = parentOfProgrammingLanguages
                  }
                );

                index++;
            }

            foreach (var frameworksAndDatabase in frameworksAndDatabases)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = frameworksAndDatabase,
                      ParentId = parentOfFrameworksAndDatabases
                  }
                );

                index++;
            }

            foreach (var driverLicence in driverLicences)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = driverLicence,
                      ParentId = parentOfDriverLicences
                  }
                );

                index++;
            }

            foreach(var characterTrait in characterTraits)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = characterTrait,
                      ParentId = parentOfCharacterTraits
                  }
                );

                index++;
            }

            foreach (var jobCondition in jobConditions)
            {
                list.Add(
                  new TalentPropertyLabel()
                  {
                      Id = index,
                      Name = jobCondition,
                      ParentId = parentJobConditions
                  }
                );

                index++;
            }

            return list;
        }

    }
}
