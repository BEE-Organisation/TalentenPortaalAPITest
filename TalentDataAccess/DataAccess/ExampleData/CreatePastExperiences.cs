
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreatePastExperiences
    {

        public static List<PastExperience> Create()
        {
            List<PastExperience> list = new List<PastExperience>();

            DateOnly[] from = new DateOnly[] {
                new DateOnly(1990, 1, 15),
                new DateOnly(2000, 1, 10),
                new DateOnly(2018, 3, 5),
                new DateOnly(2017, 5, 20),
                new DateOnly(2016, 6, 8),
                new DateOnly(2015, 2, 12),
                new DateOnly(2014, 10, 3),
                new DateOnly(2018, 3, 18),
                new DateOnly(2017, 12, 7),
                new DateOnly(2017, 9, 22),
                new DateOnly(2001, 8, 14),
                new DateOnly(2016, 1, 9),
                new DateOnly(2015, 4, 25),
                new DateOnly(2014, 7, 2),
                new DateOnly(2013, 3, 11),
                new DateOnly(2018, 8, 6),
                new DateOnly(2018, 1, 17),
                new DateOnly(2017, 10, 28),
                new DateOnly(2018, 3, 13),
                new DateOnly(2010, 11, 19),
                new DateOnly(2005, 1, 4),
                new DateOnly(2003, 10, 23),
                new DateOnly(2018, 3, 2),
                new DateOnly(2017, 2, 15),
                new DateOnly(2010, 9, 30),
                new DateOnly(2018, 7, 13),
                new DateOnly(2017, 3, 12),
                new DateOnly(2010, 7, 5),
                new DateOnly(2018, 3, 1),
                new DateOnly(2017, 5, 1),
                new DateOnly(2013, 5, 1),
                new DateOnly(2012, 8, 1),
                new DateOnly(2010, 8, 1),
                new DateOnly(2009, 1, 26),
                new DateOnly(2007, 10, 1),
                new DateOnly(2003, 6, 1),
                new DateOnly(2001, 1, 16),
                new DateOnly(1998, 5, 1),
            };

            DateOnly[] to = new DateOnly[] {
                new DateOnly(1998, 12, 1),
                new DateOnly(2021, 11, 1),
                new DateOnly(2023, 1, 6),
                new DateOnly(2023, 3, 21),
                new DateOnly(2020, 7, 9),
                new DateOnly(2019, 9, 13),
                new DateOnly(2019, 10, 4),
                new DateOnly(2024, 1, 1),
                new DateOnly(2023, 2, 8),
                new DateOnly(2021, 11, 23),
                new DateOnly(2018, 8, 15),
                new DateOnly(2024, 1, 1),
                new DateOnly(2018, 12, 13),
                new DateOnly(2016, 9, 3),
                new DateOnly(2015, 8, 7),
                new DateOnly(2024, 1, 1),
                new DateOnly(2023, 6, 18),
                new DateOnly(2022, 5, 29),
                new DateOnly(2024, 1, 1),
                new DateOnly(2022, 1, 20),
                new DateOnly(2010, 10, 5),
                new DateOnly(2004, 12, 24),
                new DateOnly(2024, 1, 1),
                new DateOnly(2022, 10, 16),
                new DateOnly(2011, 1, 31),
                new DateOnly(2024, 1, 1),
                new DateOnly(2023, 7, 13),
                new DateOnly(2010, 8, 28),
                new DateOnly(2023, 9, 30),
                new DateOnly(2022, 11, 30),
                new DateOnly(2022, 3, 31),
                new DateOnly(2013, 4, 30),
                new DateOnly(2012, 7, 31),
                new DateOnly(2010, 7, 31),
                new DateOnly(2009, 1, 27),
                new DateOnly(2007, 11, 30),
                new DateOnly(2003, 5, 31),
                new DateOnly(2001, 1, 17),
            };


            string[] companies = new string[] {
                "Lachen, Gieren, Brullen Entertainment",
                "De Wolven van Wallstreet",
                "Drukkerij en Uitgeverij De inktvis.",
                "Bloempot BV",
                "Taxidienst Quick",
                "Mensen, potloden en stompies BV",
                "De Dozenschuivers BV",
                "BEE-Ideas",
                "Zelfstandig",
                "OCI",
                "Sabic",
                "BEE-Ideas",
                "EduCom",
                "VGI",
                "Stichting de Gemeenschap",
                "GPPS",
                "BEE-Ideas",
                "Applicatieontwikkelaar",
                "BEE-Ideas",
                "Track Software",
                "Technosoft",
                "Philadelphia zorg",
                "BEE-Ideas",
                "JSR IT",
                "Flowid",
                "BEE-Ideas Organisation",
                "Zelfstandig",
                "Kuehne+Nagel",
                "Bee Ideas",
                "Ida Gerhardt Academie",
                "Holland House",
                "Raayland College",
                "Udens College",
                "Rodenborch College",
                "Mapscape",
                "Planon",
                "Computron",
                "PTS Software",

            };

            string[] functions = new string[]
            {
                "Kwaliteits-entertainer",
                "Leidinggevend Boekhouder",
                "Redactrice",
                "Bloemenverkoopster",
                "Chauffeur",
                "Administratief medewerker",
                "Cassière en winkelmedewerker",
                "Product Owner/Scrum Master",       //dennnis. = 8 -> 4x
                "Webdevelopment",
                "Controlroom Operator/Projectleider",
                "Controlroom Operator/Projectleider",
                "Front end developer",              //michiel = 9 =-> 4x
                "Traineeship",
                "CAD Operator",
                "Anaylist",
                "Frontend developer",       //Kelvin = 10 -> 3x
                "Frontend developer",
                "The Challenge Zone",
                "Fullstack developer",      //John = 11 -> 4x
                "Fullstack developer",
                "Fullstack developer",
                "Software developer",
                "Fullstack Developer",       //Peter = 12 ->  3x
                "IT Medewerker",
                "Stagiair",
                "Software Engineer",        //Roel = 13 -> 3x
                "Software Engineer",
                "Administratief Medewerker",
                "Scrum Master",             //Jos = 14 -> 10x [4x with more details]
                "Docent Wiskunde",
                "Senior Software Engineer",
                "Docent Wiskunde",
                "Docent Wiskunde",
                "Docent Wiskunde",
                "Technical Writer",
                "ICT Consultant",
                "Senior Software Engineer",
                "Senior Software Engineer",



            };

            string[] descriptions = new string[]
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "In de rol van Product Owner vertaal ik de wensenvanuit de business naar werkbare items voor hetteam van ontwikkelaars. Oplossingen vanuit het teambespreek ik met de stakeholders en op deze manierverbind ik de stakeholders met het team vanontwikkelaars en wordt het beste product gemaaktvoor de stakeholder. Als Product Owner begeleid iktwee teams, met het eerste team wordt een nieuwCRM systeem gebouwd en met het tweede teamwordt er een NFT platform gebouwd. Als ScrumMaster heb ik voor een gestructureerde en openwerkomgeving gezorgd voor de ontwikkelaars. Ditheb ik gerealiseerd door regelmatig meetings tefaciliteren waarbij iedereen open, vrij en zonderrestricties kan communiceren. Om hier deel van tezijn en samen fijne, gebruikersvriendelijke productente maken geeft me elke dag veel voldoening.",
                "",
                "",
                "",
                "Als Product Owner ben ik verantwoordelijk om de lijm te zijn tussen de cliënt en het dev team. Het duidelijk in kaart brengen wat het team aan kan qua skills en workload (vooral hier belangrijk omdat de ervaring van teamleden uiteenlopen van medior IT-er tot iemand die net zijn eerste regel code heeft geschreven) en wat de verwachtingen/wensen van de cliënt zijn staan hier in centraal. Daarbij ben ik ook degene die de planning maakt en er voor zorgt dat iedereen weet wat de verwachtingen zijn. Dat houd soms dus ook in om onrealistische wensen aan te kaarten bij de cliënt.",
                "Het zijn van Scrum Master betekend dat ik het aanspreekpunt ben van het hele team en zorg dat iedereen zijn werk kan doen en ook met de juiste oplossingen kom wanneer we kuilen in de weg tegenkomen. Van coaching van teamleden tot het escaleren van issues naar hogerop mochten we er zelf niet uitkomen.",
                "Als sessiemuzikant ben ik kundig om in verschillende genres nieuw materiaal te componeren dan wel arrangementen op bestaande\r\nmuziek uit te denken en te perfectioneren. Als producer ben ik verantwoordelijkheid voor een opnamesessie. Tot de minimale taken\r\nvan het indelen van de opnametijd in de studio en het nemen van eindbeslissingen. Als Sound Engineer nam ik alle techische aspecten ook op zoals het mix- en masterwerk, plaatsen van apparatuur etc.",
                "In deze rol ben ik verantwoordelijk geweest om alle klantvragen in kaart te brengen en mensen te helpen bij hun vraag. Ook het\r\nmeedenken voor oplossingen van mensen met een betalingsachterstand hoorde hier bij.",
                "Binnen het project ben ik zowel developer als scrum master binnenhet team. Als developer ben ik voornamelijk betrokken bij het stukfrontend. Hierin werk ik met HTML, CSS, TS (JS) binnen het Angularframework.",
                "Binnen The Challenge Zone ben ik begonnen als stagiair developer. Inmijn tijd daar heb ik een goed contact opgebouwd met de managerMarc Huntjens en heb ik mij ook bewezen om twee projecten teoverzien als project manager. Deze werden gehanteerd met de scrummethode. Een van deze projecten was een webshop voor eenfi etswinkel. Het andere project was een datahygiëne project insamenwerking met 4 bouw gerelateerde bedrijven en Open University Maastricht.",
                "",
                "Developer in Srum-Team",
                "Analyseren, Ontwerpen, Ontwikkelen, Testen, Documenteren, Plannen.",
                "",
                "",
                "Werken in een Scrum team aan een project voor AZL.",
                "Ontwikkelen van PHP web applicaties - Maken en optimaliseren van SQL queries - Linux systeembeheer - Beheren van VM's via VMware vCenter en het maken van backups hiervan.",
                "Stage",
                "Als software engineer voor Bee Portal, richt ik me op het bouwen en onderhouden van de achterliggende systemen en API's. Ik werk nauw samen met een multidisciplinair team van ontwikkelaars om een vloeiende integratie tussen de frontend en backend te waarborgen. Mijn taken omvatten systeemintegratie, gegevensbeheer en het ondersteunen van de realisatie van Bee Portal's visie als een centrale informatiehub voor kandidaten, medewerkers en begeleiders. Dit is fulltime en remote.",
                "Eigen projecten uitvoeren om zo ervaring op te doen als software engineer. Deze projecten waren bijvoorbeeld een microcontroller\r\nprogrammeren zodat deze een sensor kan a􀀁ezen en via internet data op kon vragen en daarna deze data ook via websocket en http\r\nrequests beschikbaar worden gemaakt om op te vragen via een programma dat draait op een server. Dit programma slaat dit op in een database waarna deze data bekeken kan worden via een gemaakte website. Nog een project was een C++ programma om automatisch een nieuw C++ project te kunnen starten, dit hield in de  juiste folder structuur te maken en de juiste benodigde start bestanden te maken. Een derde project was Covid data van het RIVM ophalen, deze importeren in een database elke dag en deze lokaal te laten benaderen via een website. Hierdoor was te zien wat de situatie was in mijn eigen dorp en de trend.",
                "",
                "Tijdens een leer-werk traject wordt er projectmatig gewerkt aan eenportal. Ik heb gedurende een half jaar de rol van Scrum Master op megenomen. Tevens heb ik me hierbij steeds meer verdiept in defacetten van Scrum Master. Ik heb mijn PSM1 certifi caat gehaald enben momenteel bezig om het PSM2 certificaat te halen.",
                "Docent wiskunde onderbouw Havo / VWO",
                "Analist, developer, Software Tester, Support engineer",
                "Doceren wiskunde VMBO / HAVO / VWO klas 1, 2 en 3",
                "",
                "",
                "",
                "",
                "",
                "",
            };

            List<string>[] tasks = new List<string>[]
            {
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>() { "De wensen van de stakeholdervertalen naar werkbare items inde backlog.", "Oplossingen vanuit het teambespreken met de stakeholder", "Testen, debuggen en zoekennaar oplossingen voorproblemen binnen het project.", "Deelname aan het ontwerp ende structurering van hetproject.", "Deelname aan planningstakenen werkitems binnen hetscrum-framework.", "Presenteren en geven vandemo's van functies in deapplicatie aan zowel de interneteams als externe klanten.", "Zoeken naar nieuweoplossingen en best practices-", "scenario's om de kwaliteit vanhet product te verbeteren.", "Structuur geven aan het team" },
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>() { "Vertalen van de wensen van een klant aar een tastbaar product.","Ondersteuning van andere teamleden in en adviserende rol.","Deelname aan het ontwerp en de structurering van het project.","Deelname aan planningstaken en werkitems binnen het scrum-framework.","Presenteren en geven van demo's van functies in de applicatie aan zowel de interne teams als externe klanten.","Zoeken naar nieuwe oplossingen en best practices-scenario's om de kwaliteit van het product te verbeteren." },
                new List<string>() { "Coachende en begeleidende rol in het team","Aanpakken van issues op zowel teamverband als persoonlijke hindernissen","Motiveren en inspireren" },
                new List<string>() { "Ghostwriting van nummers","Arrangeren","Componeren","Partijen inspelen in de studio","Studioplanning","Mix- en masteringwerk","Publiceren van muziek","Meedenken aan het eindproduct van de artiest","Studioplanning maken en handhaven" },
                new List<string>() { "Mensen te woord staan om ze wegwijs te maken in de wereld van de energie","Technische ondersteuning bieden","Administratief alles op orde maken","Hulp en oplossingen bieden bij betalingsachterstanden" },
                new List<string>() { "Programmeren in de frontend van de applicatie.","Uitvoeren van scrum gerelateerde taken." },
                new List<string>() { "Programmeren in de frontend van de applicatie.","Ondersteuning van andere teamleden ineen adviserende rol.","Contactpersoon tussen verschillendestakeholders.","Deelname aan planningstaken enwerkitems binnen het scrum-framework.","Presenteren en geven van demo's vanfuncties in de applicatie aan zowel deinterne teams als externe klanten.","Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." },
                new List<string>(),
                new List<string>() { "Deelname aan het ontwerp en destructurering van het project.","Programmeren in de backend en front-end van de applicatie.","Testen, debuggen en zoeken naaroplossingen voor problemen binnen hetproject.","Ondersteuning van andere teamleden ineen adviserende rol.","Deelname aan planningstaken enwerkitems binnen het scrum-framework.","Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." },
                new List<string>() { "Maken en ontwikkeling vanbedrijfskritische verzuimsoftwarevoornamelijk voor arbodiensten maar ookvoor bedrijfsartsen en werkgevers.", "Betrokkenheid bij ISO certificatie.", "Waar ik trots op ben, CBBS.", "Een systeem waar:", "A. Beroepen met functies en takenworden gekoppeld aan de fysieke enpsychische belasting.", "B. De taken bij het beroep per belastingeen kleur van de stoplicht krijgen, rood isnoodzakelijk en groen is niet vantoepassing.", "C. Ziektes.gekoppeld worden aan defysieke en psychische belasting. (Taken)", "D. Met een druk op een knop bepaaldwordt of bijvoorbeeld iemand met eengebroken voet nog zijn beroep, taken kanuitvoeren", "Het mooie van het systeem is dat erfuncties groen kunnen zijn. Dat betekenddat de werknemers vaak deels nog aanhet werk kunnen." },
                new List<string>(),
                new List<string>(),
                new List<string>() { "Backend development" },
                new List<string>() { "Web applicatie voor nummerportering via de REST API van vereniging COIN","ERP Web applicatie voor een verloskundigepraktijk","Service voor het synchroniseren van facturen met een online boekhoudprogramma" },
                new List<string>() { "Maken van een LabVIEW applicatie voor het aansturen van een pomp","Optimalisatie van een hydrogenerigsreactie in een microreactor" },
                new List<string>() { "Ontwikkelde en onderhield de backendcomponenten van Bee Portal.","Testen, debuggen en zoeken naar oplossingen voor problemen binnen het project.","Deelname aan het ontwerp en de structurering van het project.","Deelname aan planningstaken en werkitems binnen het scrum-framework.","Ondersteuning van andere teamleden in een adviserende rol." },
                new List<string>(),
                new List<string>(),
                new List<string>() { "Groep geholpen met basic vaardighedenvan programmeren.","PO geholpen met het initieel vullen van deproduct backlog in Azure Devops.","Groep gemotiveerd, gestimuleerd engeënthousiasmeerd met workshops enverhalen","Zorgen dat alle vergaderingen goedingevuld en uitgevoerd worden." },
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),

            };

            int[] talentIds = new int[] {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                8,
                8,
                8,
                9,
                9,
                9,
                9,
                10,
                10,
                10,
                11,
                11,
                11,
                11,
                12,
                12,
                12,
                13,
                13,
                13,
                14,
                14,
                14,
                14,
                14,
                14,
                14,
                14,
                14,
                14,
            };

            for (int i = 0; i < from.Length; i++)
            {
                PastExperience data = new PastExperience();
                data.Id = i + 1;
                data.DateFrom = from[i];
                data.DateTill = to[i];
                data.Company = companies[i];
                data.Function = functions[i];
                data.Tasks = tasks[i];
                data.Description = descriptions[i];
                data.TalentId = talentIds[i];

                list.Add(data);
            }


            return list;
        }


    }
}
