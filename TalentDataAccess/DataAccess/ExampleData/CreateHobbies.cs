using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.ExampleData
{
    public class CreateHobbies
    {

        private static string[] _randomHobbies = new string[]
        {
            "Yoga",
            "Wandelen",
            "Lezen",
            "Tuinieren",
            "Breien of haken",
            "Koken",
            "Borduren",
            "Mediteren",
            "Taarten bakken",
            "Muziek luisteren",
            "Sterrenkijken",
            "Schaken",
            "Puzzelen",
            "Naar de film gaan",
            "Netflixen",
            "Dansen",
            "Hardlopen",
            "Klimmen of boulderen",
            "Fietsen",
            "Zwemmen",
            "Padellen",
            "Surfen",
            "Basketbal",
            "Skateboarden",
            "Pilates",
            "Tennis",
            "Boksen",
            "Volleybal",
            "Bootcamp",
            "Hiken",
            "Schilderen",
            "Tekenen",
            "Fotografie",
            "Schrijven",
            "Een instrument spelen",
            "Zingen",
            "Acteren",
            "Kalligrafie",
            "Sieraden maken",
            "Houtbewerken",
            "Beeldhouwen",
            "Grafisch ontwerpen",
            "Meubelmaken",
            "Pottenbakken",
            "Een podcast maken",
            "Gamen",
            "Lezen",
            "Naaien of quilten",
            "Een taal leren",
            "Plantjes kweken",
            "Programmeren",
            "Origami",
            "Puzzelen",
            "Zeep maken",
            "Cocktails maken",
            "Latte-art",
            "Vogelspotten",
            "Doe-het-zelven",
            "Een YouTube-kanaal beginnen",
            "Films kijken",
            "Robots bouwen",
            "3D-printen",
            "Modelbouw",
            "Drones bouwen/besturen",
            "Je eigen bier brouwen",
            "Podcast maken",
            "Apps ontwikkelen",
            "Websites bouwen",
            "Computers bouwen",
            "Video’s bewerken (TikTokken!)",
            "Photoshoppen",
            "Een radiozender beginnen",
            "Auto’s restaureren",
            "Domotica",
            "Sleutelen aan fietsen",
            "Kaarten maken",
            "Scrapbooking",
            "Mozaïek",
            "Keramiek",
            "Kleding maken",
            "Kaarsen maken",
            "Papier-maché",
            "Zeefdrukken maken",
            "Glas-in-lood maken",
            "Boetseren"
        };

        public static List<Hobby> Create()
        {
            List<Hobby> list = new List<Hobby>();

            int id = 1;

            //Random generate data for first 7 persons.
            for(int i = 0; i < 7; i++)
            {
                List<int> randomNumbers = GenerateRandomNumbers(5, 0, _randomHobbies.Length - 1);

                int order = 0;

                foreach(int randomNumber in randomNumbers)
                {
                    Hobby hobby = new Hobby();
                    hobby.Id = id;
                    hobby.Name = _randomHobbies[randomNumber];
                    hobby.Order = order;
                    hobby.TalentId = i + 1;

                    id++;
                    order++;

                    list.Add(hobby);
                }
            }

            //Add other data.
            int[] talentIds = new int[] { 8, 9, 10, 11, 12, 13, 14 };
            List<string>[] hobbies = new List<string>[]
            {
                new List<string>() { "Koken", "Reizen", "Wandelen", "Fietsen" },
                new List<string>() { "Muziek maken", "Gamen", "Hardlopen", "Film liefhebber", "Festivallen" },
                new List<string>() { "Video Games", "Schrijven", "Rollenspel (DnD)" },
                new List<string>() { "Wandelen",  "De natuur" },
                new List<string>() { "Gewichtheffen", "Gamen" },
                new List<string>() { "Mountainbiken", "Microcontrollers Programmeren", "Fietsen onderhouden", "Films/Series kijken", "Computer spellen", "Wandelen met hond" },
                new List<string>() { "Hockey", "Wandelen", "Musea en theaters bezoeken" }
            };

            for(int i = 0; i < talentIds.Length; i++)
            {
                int order = 0;

                List<string> hobbiesParticipants = hobbies[i];

                foreach(string hobbiesParticipant in hobbiesParticipants)
                {
                    Hobby hobby = new Hobby();
                    hobby.Id = id;
                    hobby.Name = hobbiesParticipant;
                    hobby.Order = order;
                    hobby.TalentId = talentIds[i];

                    id++;
                    order++;

                    list.Add(hobby);
                }                
            }         

            return list;
        }


        private static List<int> GenerateRandomNumbers(int amount, int min, int max)
        {
            List<int> randomNumbers = new List<int>();

            while(randomNumbers.Count() < amount)
            {
                Random r = new Random();
                int number = r.Next(min, max);

                if(!randomNumbers.Contains(number))
                {
                    randomNumbers.Add(number);
                }
            }

            return randomNumbers;
        }


    }
}
