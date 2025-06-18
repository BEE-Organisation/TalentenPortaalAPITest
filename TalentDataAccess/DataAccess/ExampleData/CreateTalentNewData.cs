using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateTalentNewData
    {

        public static List<Talent> Create()
        {
            List<Talent> list = new List<Talent>();

            string[] names = new string[]
            {
                "Mister Bean",
                "Christian",
                "Carolien",
                "Saskia",
                "Matilda",
                "Jane",
                "Judith",
                "Dennis",
                "Michiel",
                "Kelvin",
                "John",
                "Peter",
                "Roel",
                "Jos",
            };

            string[] jobTitles = new string[]
            {
                "Product Owner",
                "Scrum Master",
                "Senior Developer",
                "Junior Frontend Developer",
                "Frontend Developer",
                "Backend Developer",
                "Fullstack Developer",
                "Product Owner",
                "Front End Developer",
                "Applicatie- en Mediaontwikkelaar",
                "Fullstack Software Engineer",
                "Fullstack Software Engineer",
                "Software Engineer",
                "Scrum Master / Product Owner",
            };

            string[] educationLevel = new string[]
            {
                "WO",
                "HBO",
                "MBO",
                "MBO",
                "MBO",
                "MBO",
                "MBO",
                "HBO",
                "WO",
                "MBO",
                "WO",
                "HBO",
                "HBO",
                "HBO",
            };

            string[] descriptions = new string[] {
                "Maakt mensen graag aan het lachen.",
                "Debiteuren en crediteuren is echt zijn ding.",
                "Een echte kei in Desktop Publishing.",
                "Verkoopt graag in een winkel.",
                "Brengt graag mensen naar een bestemming.",
                "Administratie is haar lust en haar leven.",
                "Maakt ook graag een praatje met de mensen.",
                "Mijn passie is om mensen behulpzaam te zijn door producten te maken die mensen helpen in hun dagelijkse werkzaamheden. Als Product Owner/ (Scrum Master/Projectleider) ben ik de bruggenbouwer die hier dagelijks voor zorgt en hier haal ik elke dag veel voldoening uit. In de toekomst wil ik meer complexere vraagstukken vanuit de business kunnen vertalen naar goede software matige oplossingen. Bij BEE-Ideas heb ik beide aspecten van het SCRUM proces leren kennen doordat ik zowel de rol van Product Owner als de rol van Scrum Master heb bekleed.",
                "Websites maken, gamen, het web afstruinen, computers bouwen - van kinds af aan fascineerde de IT mij al.  Tijdens mijn carriere in de ruimtelijke ordening heb ik veel vaardigheid ontwikkeld in projectmatig werken - zowel zelfstandig als in teamverband. Ik kreeg echter te weinig uitdaging en mijn interesse in het vak ebde weg .  Nadat ik in 2017 door een operatie van epilepsie ben genezen, heb ik besloten om van mijn liefde voor de IT - en met name front-end development - mijn beroep te gaan maken. Met cursussen, een IT-traineeship en zelfstandige projecten heb ik een professioneel niveau bereikt.",
                "Ik omschrijf mijzelf als een positief persoon die altijd direct op zoek gaat naar de juiste oplossing voor een probleem. Over de jaren ben ik erg gegroeid in het herkennen van mijn goede kwaliteiten maar zo ook mijn valkuilen. Communicatie vind ik zeer belangrijk.  Op een technisch niveau heb ik interesse in front-end development en wil mij daar ook graag verder in ontwikkelen. Tijdens mijn opleiding heb ik grotendeels met PHP gewerkt met de OOP methode. SQL kwam ook te pas. In mijn zelfstudie heb ik mij verdiept in React.js.",
                "Als werknemer wens ik als loyale teamplayer intellectueel uitgedaagd te worden. Het geeft mij voldoening tegenslagen te overwinnen en samen fantastische prestaties te behalen. Ik vind het heerlijk om gezamenlijk (maar soms ook zelfstandig) een zowel technisch als functioneel kwalitatief hoogstaand product op te leveren.",
                "Ik vind het leuk om te programmeren, ben  hier ook in mijn vrije tijd veel mee bezig. Zo heb ik bijvoorbeeld een berechtingssyteem gemaakt voor gewichthefwedstrijden op basis van een arduino. Ik kan goed zelfstandig werken. Ook doe ik mijn werk secuur en met veel aandacht voor details.",
                "Ik ben een gedreven software-ontwikkelaar met een sterke technische achtergrond en een passie voor innovatie. Mijn\r\nvoortdurende zoektocht naar uitdagingen stelt me in staat om op de hoogte te blijven van de nieuwste technologische trends en\r\ndeze toe te passen om bestaande projecten te versterken en nieuwe te initiëren. Mijn ambitie is om samen met getalenteerde\r\nteams hoogwaardige producten te creëren waar we allemaal trots op zijn. Mijn focus ligt op het leveren van kwaliteit en het\r\nontwikkelen van innovatieve, probleemoplossende oplossingen.",
                "Technisch onderlegde en didactisch vaardige scrum master.Door diverse functies in software engineering ben ik technischonderlegd in allerlei takken van software ontwikkeling. Tevensheb ik jarenlang als docent wiskunde voor de klas gestaanwaarbij diverse sturende en motiverende vaardigheden belangrijkzijn. Tot mijn verrassing komen vele onderdelen uit deze functiesheel mooi samen in de rol van een scrum master. Ik wil nu graagalles combineren en inzetten om tot een mooi mogelijk resultaatte komen met een scrum team.",

            };

            //string[] characterTraits = new string[]
            //{
            //    "Humor, Vriendelijkheid, Introvert",
            //    "Doorzetter, Geen 9-tot-5-mentaliteit, Ondernemend",
            //    "Creatief, Ondernemend, Vriendelijk",
            //    "Doorzetter, Klantvriendelijk, Sociaal",
            //    "Stressbestendig, Geen 9-5 mentaliteit, Houd van de linkerrijbaan",
            //    "Doorzetter, weet van aanpakken, wel een 9-tot-5 mentailteit",
            //    "Sociaal, Extravert, Houd van feestjes",
            //    "Verbinder,Analytisch,Kwaliteitsgericht,Oplossingsgericht",
            //    "Creatief, Leergierig, Teamplayer, Rustig",
            //    "Optimistisch,Creatief,Flexibel,Nieuwsgierig",
            //    "Constructief,Onafhankelijk,Flexibel,Analytisch",
            //    "Analytisch,Zelfstandig,Detaillistisch",
            //    "Leergierig, Nieuwsgierig, Vindingrijk, Vooruitdenkend, Doelgericht",
            //    "Teamplayer, Sociaal, vriendelijk, Kennis delend, Doorzetter",
            //};

            DateOnly[] dob = new DateOnly[]
            {
                new DateOnly(1955, 1, 6),
                new DateOnly(1974, 1, 30),
                new DateOnly(1989, 5, 29),
                new DateOnly(1988, 3, 21),
                new DateOnly(1987, 9, 30),
                new DateOnly(1990, 8, 31),
                new DateOnly(1991, 7, 30),
                new DateOnly(1972, 6, 12),
                new DateOnly(1994, 5, 2),
                new DateOnly(1992, 12, 1),
                new DateOnly(1960, 4, 12),
                new DateOnly(1986, 11, 22),
                new DateOnly(1988, 4, 27),
                new DateOnly(1960, 3, 17)
            };

            string[] municipalities = new string[]
            {
                "Eindhoven",
                "Den Bosch",
                "Breda",
                "Tilburg",
                "Goirle",
                "Waalwijk",
                "Dongen",
                "Maastricht",
                "Nijmegen",
                "Heerlen",
                "Nijmegen",
                "Valkenswaard",
                "Someren",
                "Grave",
            };

            string[] provinces = new string[]
            {
                "Noord-Brabant",
                "Noord-Brabant",
                "Noord-Brabant",
                "Noord-Brabant",
                "Noord-Brabant",
                "Noord-Brabant",
                "Noord-Brabant",
                "Limburg",
                "Gelderland",
                "Limburg",
                "Gelderland",
                "Noord-Brabant",
                "Noord-Brabant",
                "Noord-Brabant",
            };

            string[] images = new string[]
            {
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/michiel.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/kelvin.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/john.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/peter.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/roel.jpg",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/jos.jpg",
            };

            string[] pitchUrls = new string[]
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV DENNIS.mp4",
                "",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV KELVIN.mp4",
                "",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV PETER.mp4",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV ROEL.mp4",
                "",
            };

            string[] loopUrls = new string[]
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "https://beeideasstorage.blob.core.windows.net/talentenportaal/video_loops/DENNIS_2_THUMBNAIL-853_480.mp4",
                "",
                "",
                "",
                "",
                "",
                "",
            };

            string[] linkedInUrls = new string[]
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "https://www.linkedin.com/in/dennis-olislagers-442b3a68",
                "",
                "https://www.linkedin.com/in/kelvinkohl",
                "",
                "",
                "https://www.linkedin.com/in/roel-van-deursen-851058231",
                "https://www.linkedin.com/in/jos-broeren4918833",
            };

            string[] contactOptions = new string[]
            {
                "email, telefonisch",
                "email, telefonisch",
                "email, telefonisch",
                "email, telefonisch",
                "email, telefonisch",
                "email, telefonisch",
                "email, telefonisch",
                "email, telefonisch, LinkedIn",
                "email",
                "email, telefonisch, LinkedIn",
                "email, telefonisch",
                "email",
                "email, telefonisch, LinkedIn",
                "email, telefonisch, LinkedIn",
            };

            decimal[] availableHours = new decimal[]
            {
                20.00M,
                40.00M,
                32.00M,
                32.00M,
                36.00M,
                40.00M,
                28.00M,
                40.00M,
                40.00M,
                32.00M,
                40.00M,
                36.00M,
                36.00M,
                36.00M,
            };

            int[] travelDistances = new int[]
            {
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                50,
                60,
                100,
                40,
                40,
                50,
                40,
            };

            string[] desiredWorkLocations = new string[]
            {
                "Remote",
                "Thuis/Kantoor",
                "Remote",
                "Remote/Kantoor",
                "Remote",
                "Remote/Kantoor",
                "Remote",
                "Hybride - Thuis/Kantoor",
                "Remote",
                "Hybride - Remote/Kantoor",
                "Remote",
                "Hybride - Remote/Kantoor",
                "Remote",
                "Hybride - Remote/Kantoor",
            };

            for (int i = 0; i < names.Length; i++)
            {
                Talent talent = new Talent();
                talent.Id = i + 1;
                talent.Name = names[i];
                talent.OrganisationId = null;
                talent.JobTitle = jobTitles[i];
                talent.Description = descriptions[i];
                //talent.CharacterTraits = characterTraits[i];
                talent.DateOfBirth = dob[i];
                talent.Education = educationLevel[i];
                talent.Municipality = municipalities[i];
                talent.Province = provinces[i];
                talent.ProfilePhotoRef = images[i];
                talent.PitchUrl = pitchUrls[i];
                talent.LoopUrl = loopUrls[i];
                talent.CvUrl = "";
                talent.LinkedInUrl = linkedInUrls[i];
                talent.ContactOptions = contactOptions[i];
                talent.AvailableHours = availableHours[i];
                talent.TravelDistance = travelDistances[i];
                talent.DesiredWorkLocation = desiredWorkLocations[i];
                talent.IsProfileVisible = true; //All visibile.
                talent.FoundJob = false; //All: no job yet.
                talent.WorksAtCompany = ""; //All: no company yet.

                list.Add(talent);
            }

            return list;
        }

    }

}
