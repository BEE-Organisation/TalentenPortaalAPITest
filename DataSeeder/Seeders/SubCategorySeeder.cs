using DataSeeder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace DataSeeder.Seeders
{
    public class SubCategorySeeder
    {

        //NOTE: Make sure that the values of the labels exist in the Database.
        private static List<TalentPropertiesModel> _data = new List<TalentPropertiesModel>()
        {

            //TalentId = 8 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 1,
                SubCategoryLabel = "Proactiviteit",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 8 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 4,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 2,
                SubCategoryLabel = "Duits",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 8 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 3,
                SubCategoryLabel = "Agile/Scrum",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 3,
                SubCategoryLabel = "Stakeholdermanagement",
                SkillLevel = 4,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 3,
                SubCategoryLabel = "Projectmanagement",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 3,
                SubCategoryLabel = "Software Development",
                SkillLevel = 3,
                Order = 3,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 3,
                SubCategoryLabel = "Productmanagement",
                SkillLevel = 3,
                Order = 4,
            },
            //TalentId = 8 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 4,
                SubCategoryLabel = "IntelliJ IDEA",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 4,
                SubCategoryLabel = "JetBrains",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 4,
                SubCategoryLabel = "VS Code",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 4,
                SubCategoryLabel = "Webstorm",
                SkillLevel = 3,
                Order = 3,
            },
            //TalentId = 8 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 5,
                SubCategoryLabel = "C#",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 5,
                SubCategoryLabel = "Java",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 5,
                SubCategoryLabel = "Javascript",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 5,
                SubCategoryLabel = "Typescript",
                SkillLevel = 3,
                Order = 3,
            },
            //TalentId = 8 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 6,
                SubCategoryLabel = "Angular",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 6,
                SubCategoryLabel = "MySQL",
                SkillLevel = 5,
                Order = 1,
            },
            //TalentId = 8 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 8 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 8,
                SubCategoryLabel = "Kritisch denken, beoordelingsvermogen",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 8,
                SubCategoryLabel = "Doorzettingsvermogen",
                SkillLevel = -1,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 8,
                MainLabelId = 8,
                SubCategoryLabel = "Waardering van schoonheid en excellentie",
                SkillLevel = -1,
                Order = 2,
            },

            //TalentId = 9 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 1,
                SubCategoryLabel = "Communicatieve vaardigheden",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 9 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 4,
                Order = 1,
            },

            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 2,
                SubCategoryLabel = "Duits",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 9 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 3,
                SubCategoryLabel = "SCRUM",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 3,
                SubCategoryLabel = "TDD",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 3,
                SubCategoryLabel = "OOP",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 3,
                SubCategoryLabel = "Agile",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 9 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 4,
                SubCategoryLabel = "Visual Studio 2019",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 4,
                SubCategoryLabel = "Adobe CC",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 4,
                SubCategoryLabel = "Npm",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 4,
                SubCategoryLabel = "Git",
                SkillLevel = 3,
                Order = 3,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 4,
                SubCategoryLabel = "Microsoft Office",
                SkillLevel = 3,
                Order = 4,
            },
            //TalentId = 9 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 5,
                SubCategoryLabel = "HTML 5",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 5,
                SubCategoryLabel = "CSS",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 5,
                SubCategoryLabel = "SCSS/SASS",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 5,
                SubCategoryLabel = "JavaScript",
                SkillLevel = 3,
                Order = 3,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 5,
                SubCategoryLabel = "PHP",
                SkillLevel = 3,
                Order = 4,
            },
            //TalentId = 9 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 6,
                SubCategoryLabel = "MySQL",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 6,
                SubCategoryLabel = "Mongo DB",
                SkillLevel = 5,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 6,
                SubCategoryLabel = "Angular",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 6,
                SubCategoryLabel = "VueJS",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 6,
                SubCategoryLabel = "NodeJS",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 9 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 9 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 8,
                SubCategoryLabel = "Creatief",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 8,
                SubCategoryLabel = "Leergierigheid",
                SkillLevel = -1,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 9,
                MainLabelId = 8,
                SubCategoryLabel = "Nieuwsgierigheid",
                SkillLevel = -1,
                Order = 2,
            },

            //TalentId = 10 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 1,
                SubCategoryLabel = "Discipline",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 10 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 4,
                Order = 1,
            },
            //TalentId = 10 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 3,
                SubCategoryLabel = "SCRUM",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 3,
                SubCategoryLabel = "Agile",
                SkillLevel = 3,
                Order = 1,
            },
            //TalentId = 10 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 4,
                SubCategoryLabel = "Godot",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 4,
                SubCategoryLabel = "Gdscript",
                SkillLevel = 3,
                Order = 1,
            },
            //TalentId = 10 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 5,
                SubCategoryLabel = "HTML",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 5,
                SubCategoryLabel = "CSS",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 5,
                SubCategoryLabel = "Javascript",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 5,
                SubCategoryLabel = "PHP",
                SkillLevel = 3,
                Order = 3,
            },
            //TalentId = 10 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 6,
                SubCategoryLabel = "React.js",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 6,
                SubCategoryLabel = "SQL",
                SkillLevel = 5,
                Order = 1,
            },
            //TalentId = 10 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 10 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 8,
                SubCategoryLabel = "Enthousiast/levenslustig",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 8,
                SubCategoryLabel = "Creatief",
                SkillLevel = -1,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 10,
                MainLabelId = 8,
                SubCategoryLabel = "Nieuwsgierigheid",
                SkillLevel = -1,
                Order = 2,
            },

            //TalentId = 11 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 1,
                SubCategoryLabel = "Emotionele stabiliteit",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 11 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 4,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 2,
                SubCategoryLabel = "Spaans",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 11 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 3,
                SubCategoryLabel = "OOP",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 3,
                SubCategoryLabel = "Agile",
                SkillLevel = 4,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 3,
                SubCategoryLabel = "Scrum",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 11 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 4,
                SubCategoryLabel = "Azure DevOps",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 4,
                SubCategoryLabel = "VS Code",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 4,
                SubCategoryLabel = "Visual studio",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 4,
                SubCategoryLabel = "GIT",
                SkillLevel = 3,
                Order = 3,
            },
            //TalentId = 11 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = "C#",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = "ASP.Net MVC",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = ".Net core",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = "Typescript",
                SkillLevel = 3,
                Order = 3,
            }
            ,
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = "Javascript",
                SkillLevel = 3,
                Order = 4,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = "Visual basic",
                SkillLevel = 3,
                Order = 5,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 5,
                SubCategoryLabel = "Java",
                SkillLevel = 3,
                Order = 6,
            },
            //TalentId = 11 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 6,
                SubCategoryLabel = "Angular",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 6,
                SubCategoryLabel = "Bootstrap",
                SkillLevel = 5,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 6,
                SubCategoryLabel = "Entity Framework",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 6,
                SubCategoryLabel = "SQL",
                SkillLevel = 3,
                Order = 3,
            },
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 6,
                SubCategoryLabel = "Notes-Domino",
                SkillLevel = 3,
                Order = 4,
            },
            //TalentId = 11 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 11 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 11,
                MainLabelId = 8,
                SubCategoryLabel = "Kritisch denken, beoordelingsvermogen",
                SkillLevel = -1,
                Order = 0,
            },

            //TalentId = 12 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 1,
                SubCategoryLabel = "Integriteit",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 1,
                SubCategoryLabel = "Analytische kwaliteiten",
                SkillLevel = -1,
                Order = 1,
            },
            //TalentId = 12 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 4,
                Order = 1,
            },
            //TalentId = 12 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 3,
                SubCategoryLabel = "VM Mangement",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 3,
                SubCategoryLabel = "Scrum",
                SkillLevel = 4,
                Order = 1,
            },
            //TalentId = 12 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 4,
                SubCategoryLabel = "Visual studio",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 4,
                SubCategoryLabel = "VS Code",
                SkillLevel = 3,
                Order = 1,
            },
            //TalentId = 12 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 5,
                SubCategoryLabel = "C#",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 5,
                SubCategoryLabel = "PHP",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 5,
                SubCategoryLabel = "C",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 12 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 6,
                SubCategoryLabel = "MariaDB",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 6,
                SubCategoryLabel = "SQLite",
                SkillLevel = 5,
                Order = 1,
            },
            //TalentId = 12 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 12 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 8,
                SubCategoryLabel = "Kritisch denken, beoordelingsvermogen",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 12,
                MainLabelId = 8,
                SubCategoryLabel = "Doorzettingsvermogen",
                SkillLevel = -1,
                Order = 0,
            },

            //TalentId = 13 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 1,
                SubCategoryLabel = "Creativiteit",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 13 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 4,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 4,
                Order = 1,
            },
            //TalentId = 13 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 3,
                SubCategoryLabel = "Scrum",
                SkillLevel = 4,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 3,
                SubCategoryLabel = "Agile",
                SkillLevel = 4,
                Order = 1,
            },
            //TalentId = 13 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 4,
                SubCategoryLabel = "Visual studio 2022",
                SkillLevel = 4,
                Order = 0,
            },
            //TalentId = 13 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 5,
                SubCategoryLabel = "C#",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 5,
                SubCategoryLabel = "C",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 5,
                SubCategoryLabel = "C++",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 5,
                SubCategoryLabel = "Python",
                SkillLevel = 3,
                Order = 3,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 5,
                SubCategoryLabel = "JavaScript",
                SkillLevel = 3,
                Order = 4,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 5,
                SubCategoryLabel = "HTML",
                SkillLevel = 3,
                Order = 5,
            },
            //TalentId = 13 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 6,
                SubCategoryLabel = "MongoDB",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 6,
                SubCategoryLabel = "SQL Server",
                SkillLevel = 5,
                Order = 1,
            },
             //TalentId = 13 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 13 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 8,
                SubCategoryLabel = "Leergierigheid",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 8,
                SubCategoryLabel = "Nieuwsgierigheid",
                SkillLevel = -1,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 13,
                MainLabelId = 8,
                SubCategoryLabel = "Creatief",
                SkillLevel = -1,
                Order = 2,
            },
            
            //TalentId = 14 - Hcm Competences = MainLabelId = 1
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 1,
                SubCategoryLabel = "Beïnvloedende kwaliteiten",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 14 - Talen = MainLabelId = 2
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 2,
                SubCategoryLabel = "Nederlands",
                SkillLevel = 5,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 2,
                SubCategoryLabel = "Engels",
                SkillLevel = 5,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 2,
                SubCategoryLabel = "Duits",
                SkillLevel = 3,
                Order = 2,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 2,
                SubCategoryLabel = "Frans",
                SkillLevel = 2,
                Order = 3,
            },
            //TalentId = 14 - Methoden & technieken = MainLabelId = 3
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 3,
                SubCategoryLabel = "Scrum",
                SkillLevel = 5,
                Order = 0,
            },
            //TalentId = 14 - Softwarepakketten & -tools = MainLabelId = 4
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 4,
                SubCategoryLabel = "VS Code",
                SkillLevel = 3,
                Order = 0,
            },
            //TalentId = 14 - Programmeer- & scriptingtalen = MainLabelId = 5
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 5,
                SubCategoryLabel = "C",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 5,
                SubCategoryLabel = "Java",
                SkillLevel = 3,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 5,
                SubCategoryLabel = "Python",
                SkillLevel = 3,
                Order = 2,
            },
            //TalentId = 14 - Frameworks & databases = MainLabelId = 6
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 6,
                SubCategoryLabel = "Angular",
                SkillLevel = 3,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 6,
                SubCategoryLabel = "MySQL",
                SkillLevel = 5,
                Order = 1,
            },
            //TalentId = 14 - Rijbewijs = MainLabelId = 7
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 7,
                SubCategoryLabel = "B - Personenauto",
                SkillLevel = -1,
                Order = 0,
            },
            //TalentId = 14 - Karakterkenmerken = MainLabelId = 8
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 8,
                SubCategoryLabel = "Sociale intelligentie",
                SkillLevel = -1,
                Order = 0,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 8,
                SubCategoryLabel = "Vriendelijkheid",
                SkillLevel = -1,
                Order = 1,
            },
            new TalentPropertiesModel()
            {
                TalentId = 14,
                MainLabelId = 8,
                SubCategoryLabel = "Doorzettingsvermogen",
                SkillLevel = -1,
                Order = 1,
            },

        };

        public static async Task Seed(TalentDbContext mainDbContext) 
        {
            List<TalentPropertySubCategoryLink> gatheredData = new List<TalentPropertySubCategoryLink>();

            List<TalentPropertyLabel> allLables = await mainDbContext.TalentPropertyLabels.ToListAsync();

            //Random generate data for TalentId's 1 to 7.
            for (int talentId = 1; talentId <= 7; talentId++)
            {
                string[][] categories = new string[][]
                {
                    new string[] { "Proactiviteit","Communicatieve vaardigheden","Discipline","Emotionele stabiliteit","Integriteit","Analytische kwaliteiten","Creativiteit","Beïnvloedende kwaliteiten","Organisatorische kwaliteiten","Leiderschapskwaliteiten" },
                    new string[] { "Nederlands", "Engels", "Duits" },
                    new string[] { "Scrum", "OOP" },
                    new string[] { "Visual Studio 2022", "VS Code", "Azure DevOps" },
                    new string[] { "HTML 5", "CSS", "JavaScript", "PHP" },
                    new string[] { "SQL Server", "MySQL", "Angular" },
                    new string[] { "B - Personenauto" },
                    new string[] { "Creativiteit","Nieuwsgierigheid","Kritisch denken, beoordelingsvermogen","Leergierigheid","Levenswijs","Moed","Doorzettingsvermogen","Oprechtheid","Enthousiast/levenslustig","Liefde","Vriendelijkheid","Sociale intelligentie","Samenwerking","Rechtvaardigheid","Leiderschap","Vergevingsgezindheid","Bescheidenheid","Bedachtzaam","Zelfregulatie","Waardering van schoonheid en excellentie","Dankbaarheid","Hoopvol","Humor","Spiritualiteit" },
                };

                for (int i = 0; i < categories.GetLength(0); i++)
                {
                    string[] currentCategories = new string[] { };

                    if(i > 0 && i < 7)
                    {
                        currentCategories = categories[i];
                    }
                    else
                    {
                        if(i == 0)
                        {
                            int[] random3 = GetRandomNumbers(0, categories[i].Length, 3);
                            currentCategories = GetStringArr(categories[i], random3);
                        }

                        if(i == 7)
                        {
                            //Pick random 5.
                            int[] random5 = GetRandomNumbers(0, categories[i].Length, 5);
                            currentCategories = GetStringArr(categories[i], random5);
                        }
                    }                    

                    for (int j = 0; j < currentCategories.Length; j++)
                    {
                        int propertyLabel = SearchAppropriateLabel(allLables, currentCategories[j]);

                        if (propertyLabel > -1)
                        {
                            TalentPropertyMainCategoryLink mainCategory = await mainDbContext.TalentPropertyMainCategoryLinks.SingleOrDefaultAsync(x => x.TalentPropertyLabelId == (i + 1) && x.TalentId == talentId);

                            if(mainCategory != null)
                            {
                                Random rnd = new Random();
                                TalentPropertySubCategoryLink subCategory = new TalentPropertySubCategoryLink();
                                subCategory.TalentPropertyLabelId = propertyLabel;
                               
                                if(i < 5 && i > 0)
                                {
                                    subCategory.SkillLevel = rnd.Next(1, 6); //Generate random number from 1 to 5.
                                }
                                else
                                {
                                    subCategory.SkillLevel = -1; //for DriverLicenses. Hcm Competences, Character-traits.
                                }
                                
                                subCategory.Order = j;
                                subCategory.TalentPropertyMainCategoryLink = mainCategory;

                                gatheredData.Add(subCategory);
                            }
                            else
                            {
                                Console.WriteLine("No Main Category for: " + (i + 1) + " and TalentId: " + talentId);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Label not found: " + _data[i].SubCategoryLabel);
                        }
                    }
                }
            }

            //Populate other data.
            for (int i = 0; i < _data.Count(); i++)
            {
                int propertyLabel = SearchAppropriateLabel(allLables, _data[i].SubCategoryLabel);

                if(propertyLabel > -1)
                {
                    TalentPropertyMainCategoryLink mainCategory = await mainDbContext.TalentPropertyMainCategoryLinks.SingleOrDefaultAsync(x => x.TalentPropertyLabelId == _data[i].MainLabelId && x.TalentId == _data[i].TalentId);

                    if (mainCategory != null)
                    {
                        TalentPropertySubCategoryLink subCategory = new TalentPropertySubCategoryLink();
                        subCategory.TalentPropertyLabelId = propertyLabel;
                        subCategory.SkillLevel = _data[i].SkillLevel;
                        subCategory.Order = _data[i].Order;
                        subCategory.TalentPropertyMainCategoryLink = mainCategory;

                        gatheredData.Add(subCategory);
                    }
                    else
                    {
                        Console.WriteLine("No Main Category for: " + _data[i].MainLabelId + " and TalentId: " + _data[i].TalentId);
                    }
                } 
                else
                {
                    Console.WriteLine("Label not found: " + _data[i].SubCategoryLabel);
                }
            }

            try
            {
                await mainDbContext.TalentPropertySubCategoryLinks.AddRangeAsync(gatheredData);
                await mainDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static int SearchAppropriateLabel(List<TalentPropertyLabel> allLables, string search)
        {
            foreach(var label in allLables)
            {
                if(label.Name.ToLower().Equals(search.ToLower()))
                {
                    return label.Id;
                }
            }


            return -1;
        }

        public static int[] GetRandomNumbers(int min, int max, int amount)
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                Random r = new Random();
                int number = r.Next(min, max);

                if (!randomNumbers.Contains(number))
                {
                    randomNumbers.Add(number);
                }
                else
                {
                    while (randomNumbers.Contains(number))
                    {
                        number = r.Next(min, max);
                    }

                    randomNumbers.Add(number);
                }
            }

            return randomNumbers.ToArray();
        }

        private static string[] GetStringArr(string[] haystack, int[] indexes)
        {
            string[] arr = new string[indexes.Length];

            for (int i = 0; i < indexes.Length; i++)
            {
                int currentIndex = indexes[i];
                arr[i] = haystack[currentIndex];
            }

            return arr;
        }

    }
}
