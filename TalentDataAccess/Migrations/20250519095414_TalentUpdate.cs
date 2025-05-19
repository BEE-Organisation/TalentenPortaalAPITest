using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TalentUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Initials",
                schema: "TalentenPortaal",
                table: "Talent",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bootcamp");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sleutelen aan fietsen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Grafisch ontwerpen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Hardlopen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Schrijven");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Breien of haken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Een podcast maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Sterrenkijken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Kaarten maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Een taal leren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Bootcamp");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Een podcast maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Vogelspotten");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Robots bouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Puzzelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Een radiozender beginnen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Fotografie");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Pilates");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Basketbal");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Pottenbakken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Robots bouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Je eigen bier brouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Koken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Modelbouw");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Kaarsen maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Sterrenkijken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Gamen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Papier-maché");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Hardlopen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Een radiozender beginnen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Vogelspotten");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Podcast maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Tekenen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Kaarsen maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Papier-maché");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tasks",
                value: new List<string> { "De wensen van de stakeholdervertalen naar werkbare items inde backlog.", "Oplossingen vanuit het teambespreken met de stakeholder", "Testen, debuggen en zoekennaar oplossingen voorproblemen binnen het project.", "Deelname aan het ontwerp ende structurering van hetproject.", "Deelname aan planningstakenen werkitems binnen hetscrum-framework.", "Presenteren en geven vandemo's van functies in deapplicatie aan zowel de interneteams als externe klanten.", "Zoeken naar nieuweoplossingen en best practices-", "scenario's om de kwaliteit vanhet product te verbeteren.", "Structuur geven aan het team" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 9,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 10,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 11,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 12,
                column: "Tasks",
                value: new List<string> { "Vertalen van de wensen van een klant aar een tastbaar product.", "Ondersteuning van andere teamleden in en adviserende rol.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Presenteren en geven van demo's van functies in de applicatie aan zowel de interne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en best practices-scenario's om de kwaliteit van het product te verbeteren." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 13,
                column: "Tasks",
                value: new List<string> { "Coachende en begeleidende rol in het team", "Aanpakken van issues op zowel teamverband als persoonlijke hindernissen", "Motiveren en inspireren" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 14,
                column: "Tasks",
                value: new List<string> { "Ghostwriting van nummers", "Arrangeren", "Componeren", "Partijen inspelen in de studio", "Studioplanning", "Mix- en masteringwerk", "Publiceren van muziek", "Meedenken aan het eindproduct van de artiest", "Studioplanning maken en handhaven" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 15,
                column: "Tasks",
                value: new List<string> { "Mensen te woord staan om ze wegwijs te maken in de wereld van de energie", "Technische ondersteuning bieden", "Administratief alles op orde maken", "Hulp en oplossingen bieden bij betalingsachterstanden" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 16,
                column: "Tasks",
                value: new List<string> { "Programmeren in de frontend van de applicatie.", "Uitvoeren van scrum gerelateerde taken." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 17,
                column: "Tasks",
                value: new List<string> { "Programmeren in de frontend van de applicatie.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Contactpersoon tussen verschillendestakeholders.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Presenteren en geven van demo's vanfuncties in de applicatie aan zowel deinterne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 18,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 19,
                column: "Tasks",
                value: new List<string> { "Deelname aan het ontwerp en destructurering van het project.", "Programmeren in de backend en front-end van de applicatie.", "Testen, debuggen en zoeken naaroplossingen voor problemen binnen hetproject.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 20,
                column: "Tasks",
                value: new List<string> { "Maken en ontwikkeling vanbedrijfskritische verzuimsoftwarevoornamelijk voor arbodiensten maar ookvoor bedrijfsartsen en werkgevers.", "Betrokkenheid bij ISO certificatie.", "Waar ik trots op ben, CBBS.", "Een systeem waar:", "A. Beroepen met functies en takenworden gekoppeld aan de fysieke enpsychische belasting.", "B. De taken bij het beroep per belastingeen kleur van de stoplicht krijgen, rood isnoodzakelijk en groen is niet vantoepassing.", "C. Ziektes.gekoppeld worden aan defysieke en psychische belasting. (Taken)", "D. Met een druk op een knop bepaaldwordt of bijvoorbeeld iemand met eengebroken voet nog zijn beroep, taken kanuitvoeren", "Het mooie van het systeem is dat erfuncties groen kunnen zijn. Dat betekenddat de werknemers vaak deels nog aanhet werk kunnen." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 21,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 22,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 23,
                column: "Tasks",
                value: new List<string> { "Backend development" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 24,
                column: "Tasks",
                value: new List<string> { "Web applicatie voor nummerportering via de REST API van vereniging COIN", "ERP Web applicatie voor een verloskundigepraktijk", "Service voor het synchroniseren van facturen met een online boekhoudprogramma" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 25,
                column: "Tasks",
                value: new List<string> { "Maken van een LabVIEW applicatie voor het aansturen van een pomp", "Optimalisatie van een hydrogenerigsreactie in een microreactor" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 26,
                column: "Tasks",
                value: new List<string> { "Ontwikkelde en onderhield de backendcomponenten van Bee Portal.", "Testen, debuggen en zoeken naar oplossingen voor problemen binnen het project.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Ondersteuning van andere teamleden in een adviserende rol." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 27,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 28,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 29,
                column: "Tasks",
                value: new List<string> { "Groep geholpen met basic vaardighedenvan programmeren.", "PO geholpen met het initieel vullen van deproduct backlog in Azure Devops.", "Groep gemotiveerd, gestimuleerd engeënthousiasmeerd met workshops enverhalen", "Zorgen dat alle vergaderingen goedingevuld en uitgevoerd worden." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 30,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 31,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 32,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 33,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 34,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 35,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 36,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 37,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 38,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 1,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 2,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 3,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 4,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 5,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 6,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 7,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 8,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 9,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 10,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 11,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 12,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 13,
                column: "Initials",
                value: "");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Talent",
                keyColumn: "Id",
                keyValue: 14,
                column: "Initials",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Initials",
                schema: "TalentenPortaal",
                table: "Talent");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Video’s bewerken (TikTokken!)");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Papier-maché");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Lezen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Photoshoppen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Hiken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Programmeren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Kaarten maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Auto’s restaureren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Schilderen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Tuinieren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Zeefdrukken maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Fotografie");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Sleutelen aan fietsen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Dansen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Kaarsen maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Bootcamp");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Apps ontwikkelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Kaarten maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Domotica");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Je eigen bier brouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Plantjes kweken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Origami");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Een podcast maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Apps ontwikkelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Films kijken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Naar de film gaan");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Websites bouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Podcast maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Gamen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Acteren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Plantjes kweken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Breien of haken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Naar de film gaan");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Taarten bakken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Houtbewerken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tasks",
                value: new List<string> { "De wensen van de stakeholdervertalen naar werkbare items inde backlog.", "Oplossingen vanuit het teambespreken met de stakeholder", "Testen, debuggen en zoekennaar oplossingen voorproblemen binnen het project.", "Deelname aan het ontwerp ende structurering van hetproject.", "Deelname aan planningstakenen werkitems binnen hetscrum-framework.", "Presenteren en geven vandemo's van functies in deapplicatie aan zowel de interneteams als externe klanten.", "Zoeken naar nieuweoplossingen en best practices-", "scenario's om de kwaliteit vanhet product te verbeteren.", "Structuur geven aan het team" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 9,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 10,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 11,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 12,
                column: "Tasks",
                value: new List<string> { "Vertalen van de wensen van een klant aar een tastbaar product.", "Ondersteuning van andere teamleden in en adviserende rol.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Presenteren en geven van demo's van functies in de applicatie aan zowel de interne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en best practices-scenario's om de kwaliteit van het product te verbeteren." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 13,
                column: "Tasks",
                value: new List<string> { "Coachende en begeleidende rol in het team", "Aanpakken van issues op zowel teamverband als persoonlijke hindernissen", "Motiveren en inspireren" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 14,
                column: "Tasks",
                value: new List<string> { "Ghostwriting van nummers", "Arrangeren", "Componeren", "Partijen inspelen in de studio", "Studioplanning", "Mix- en masteringwerk", "Publiceren van muziek", "Meedenken aan het eindproduct van de artiest", "Studioplanning maken en handhaven" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 15,
                column: "Tasks",
                value: new List<string> { "Mensen te woord staan om ze wegwijs te maken in de wereld van de energie", "Technische ondersteuning bieden", "Administratief alles op orde maken", "Hulp en oplossingen bieden bij betalingsachterstanden" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 16,
                column: "Tasks",
                value: new List<string> { "Programmeren in de frontend van de applicatie.", "Uitvoeren van scrum gerelateerde taken." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 17,
                column: "Tasks",
                value: new List<string> { "Programmeren in de frontend van de applicatie.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Contactpersoon tussen verschillendestakeholders.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Presenteren en geven van demo's vanfuncties in de applicatie aan zowel deinterne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 18,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 19,
                column: "Tasks",
                value: new List<string> { "Deelname aan het ontwerp en destructurering van het project.", "Programmeren in de backend en front-end van de applicatie.", "Testen, debuggen en zoeken naaroplossingen voor problemen binnen hetproject.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 20,
                column: "Tasks",
                value: new List<string> { "Maken en ontwikkeling vanbedrijfskritische verzuimsoftwarevoornamelijk voor arbodiensten maar ookvoor bedrijfsartsen en werkgevers.", "Betrokkenheid bij ISO certificatie.", "Waar ik trots op ben, CBBS.", "Een systeem waar:", "A. Beroepen met functies en takenworden gekoppeld aan de fysieke enpsychische belasting.", "B. De taken bij het beroep per belastingeen kleur van de stoplicht krijgen, rood isnoodzakelijk en groen is niet vantoepassing.", "C. Ziektes.gekoppeld worden aan defysieke en psychische belasting. (Taken)", "D. Met een druk op een knop bepaaldwordt of bijvoorbeeld iemand met eengebroken voet nog zijn beroep, taken kanuitvoeren", "Het mooie van het systeem is dat erfuncties groen kunnen zijn. Dat betekenddat de werknemers vaak deels nog aanhet werk kunnen." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 21,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 22,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 23,
                column: "Tasks",
                value: new List<string> { "Backend development" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 24,
                column: "Tasks",
                value: new List<string> { "Web applicatie voor nummerportering via de REST API van vereniging COIN", "ERP Web applicatie voor een verloskundigepraktijk", "Service voor het synchroniseren van facturen met een online boekhoudprogramma" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 25,
                column: "Tasks",
                value: new List<string> { "Maken van een LabVIEW applicatie voor het aansturen van een pomp", "Optimalisatie van een hydrogenerigsreactie in een microreactor" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 26,
                column: "Tasks",
                value: new List<string> { "Ontwikkelde en onderhield de backendcomponenten van Bee Portal.", "Testen, debuggen en zoeken naar oplossingen voor problemen binnen het project.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Ondersteuning van andere teamleden in een adviserende rol." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 27,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 28,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 29,
                column: "Tasks",
                value: new List<string> { "Groep geholpen met basic vaardighedenvan programmeren.", "PO geholpen met het initieel vullen van deproduct backlog in Azure Devops.", "Groep gemotiveerd, gestimuleerd engeënthousiasmeerd met workshops enverhalen", "Zorgen dat alle vergaderingen goedingevuld en uitgevoerd worden." });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 30,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 31,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 32,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 33,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 34,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 35,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 36,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 37,
                column: "Tasks",
                value: new List<string>());

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 38,
                column: "Tasks",
                value: new List<string>());
        }
    }
}
