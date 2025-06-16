using System;
using System.Linq;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace DataSeeder.Seeders
{
    public static class TalentPropertyLabelSeeder
    {
        public static async Task Seed(TalentDbContext dbContext)
        {
            var mainLabels = new[]
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

            foreach (var label in mainLabels)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == null))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = null
                    });
                }
            }
            await dbContext.SaveChangesAsync();
          
            var hcmChildren = new[]
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
                "Leiderschapskwaliteiten"
            };

            var hcmId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "HCM Competenties" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in hcmChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == hcmId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = hcmId
                    });
                }
            }

            var talenChildren = new[]
            {
                "Nederlands",
                "Engels",
                "Duits",
                "Frans",
                "Spaans",
                "Italiaans",
                "Portugees",
                "Russisch",
                "Pools",
                "Turks",
                "Arabisch",
                "Chinees",
                "Japans",
                "Koreaans",
                "Hindi",
                "Bengaals",
                "Roemeens",
                "Hongaars",
                "Grieks",
                "Zweeds",
            };

            var talenId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Talen" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in talenChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == talenId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = talenId
                    });
                }
            }
            
            var methodenChildren = new[]
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

            var methodenId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Methoden & technieken" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in methodenChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == methodenId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = methodenId
                    });
                }
            }

            var softwarePakkettenChildren = new[]
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

            var softwarePakkettenId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Softwarepakketten & -tools" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();


            foreach (var label in softwarePakkettenChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == softwarePakkettenId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = softwarePakkettenId
                    });
                }
            }

            var programmeerTalenChildren = new[]
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

            var programmeerTalenId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Programmeer- & scriptingtalen" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in programmeerTalenChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == programmeerTalenId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = programmeerTalenId
                    });
                }
            }

            var frameworksDatabasesChildren = new[]
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

            var frameworksDatabasesId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Frameworks & databases" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in frameworksDatabasesChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == frameworksDatabasesId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = frameworksDatabasesId
                    });
                }
            }

            var rijbewijsChildren = new[]
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

            var rijbewijsId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Rijbewijs" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in rijbewijsChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == rijbewijsId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = rijbewijsId
                    });
                }

            }

            var karakterkenmerkenChildren = new[]
            {
                "Creatief",
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

            var karakterkenmerkenId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Karakterkenmerken" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in karakterkenmerkenChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == karakterkenmerkenId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = karakterkenmerkenId
                    });
                }
            }

            var secundaireArbeidsvoorwaardenChildren = new[]
            {
                "Reiskostenvergoeding",
                "Pensioenregeling",
                "Opleidingsbudget",
                "Thuiswerkvergoeding",
                "Flexibele werktijden",
                "Gezondheidszorgverzekering",
                "Bonusregeling",
                "Vakantiedagen bovenwettelijk",
                "Bedrijfsauto",
                "Laptop/telefoon van de zaak"
            };

            var secundaireArbeidsvoorwaardenId = dbContext.TalentPropertyLabels
                .Where(l => l.Name == "Secundaire Arbeidsvoorwaarden" && l.ParentId == null)
                .Select(l => l.Id)
                .FirstOrDefault();

            foreach (var label in secundaireArbeidsvoorwaardenChildren)
            {
                if (!dbContext.TalentPropertyLabels.Any(l => l.Name == label && l.ParentId == secundaireArbeidsvoorwaardenId))
                {
                    dbContext.TalentPropertyLabels.Add(new TalentPropertyLabel
                    {
                        Name = label,
                        ParentId = secundaireArbeidsvoorwaardenId
                    });
                }
            }


            await dbContext.SaveChangesAsync();
        }
    }
}
