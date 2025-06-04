using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateFromTillToDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateTill",
                schema: "TalentenPortaal",
                table: "PastExperience",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateFrom",
                schema: "TalentenPortaal",
                table: "PastExperience",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateTill",
                schema: "TalentenPortaal",
                table: "EducationDetail",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateFrom",
                schema: "TalentenPortaal",
                table: "EducationDetail",
                type: "date",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(1980, 9, 1), new DateOnly(1988, 7, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(1995, 1, 1), new DateOnly(1999, 12, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2019, 3, 1), new DateOnly(2019, 9, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2016, 9, 1), new DateOnly(2017, 3, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2012, 1, 1), new DateOnly(2016, 12, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2010, 1, 1), new DateOnly(2020, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2009, 1, 1), new DateOnly(2010, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2007, 1, 1), new DateOnly(2009, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2023, 1, 1), new DateOnly(2023, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2023, 1, 1), new DateOnly(2023, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(1985, 1, 1), new DateOnly(2020, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(2002, 1, 1), new DateOnly(2002, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { new DateOnly(1998, 1, 1), new DateOnly(1998, 1, 1) });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Zeefdrukken maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Grafisch ontwerpen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Websites bouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Sieraden maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Padellen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Lezen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Cocktails maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Tekenen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Acteren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Beeldhouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Lezen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Padellen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Apps ontwikkelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Zeefdrukken maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Websites bouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Doe-het-zelven");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Zeefdrukken maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Robots bouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Zingen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Volleybal");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Apps ontwikkelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Puzzelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Een instrument spelen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Films kijken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Je eigen bier brouwen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Kleding maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Taarten bakken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Video’s bewerken (TikTokken!)");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Tekenen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Borduren");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Tennis");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Dansen");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Cocktails maken");

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "Hobby",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Je eigen bier brouwen");

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
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(1990, 1, 15), new DateOnly(1998, 12, 1), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2000, 1, 10), new DateOnly(2021, 11, 1), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 3, 5), new DateOnly(2023, 1, 6), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 5, 20), new DateOnly(2023, 3, 21), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2016, 6, 8), new DateOnly(2020, 7, 9), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2015, 2, 12), new DateOnly(2019, 9, 13), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2014, 10, 3), new DateOnly(2019, 10, 4), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 3, 18), new DateOnly(2024, 1, 1), new List<string> { "De wensen van de stakeholdervertalen naar werkbare items inde backlog.", "Oplossingen vanuit het teambespreken met de stakeholder", "Testen, debuggen en zoekennaar oplossingen voorproblemen binnen het project.", "Deelname aan het ontwerp ende structurering van hetproject.", "Deelname aan planningstakenen werkitems binnen hetscrum-framework.", "Presenteren en geven vandemo's van functies in deapplicatie aan zowel de interneteams als externe klanten.", "Zoeken naar nieuweoplossingen en best practices-", "scenario's om de kwaliteit vanhet product te verbeteren.", "Structuur geven aan het team" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 12, 7), new DateOnly(2023, 2, 8), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 9, 22), new DateOnly(2021, 11, 23), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2001, 8, 14), new DateOnly(2018, 8, 15), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2016, 1, 9), new DateOnly(2024, 1, 1), new List<string> { "Vertalen van de wensen van een klant aar een tastbaar product.", "Ondersteuning van andere teamleden in en adviserende rol.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Presenteren en geven van demo's van functies in de applicatie aan zowel de interne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en best practices-scenario's om de kwaliteit van het product te verbeteren." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2015, 4, 25), new DateOnly(2018, 12, 13), new List<string> { "Coachende en begeleidende rol in het team", "Aanpakken van issues op zowel teamverband als persoonlijke hindernissen", "Motiveren en inspireren" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2014, 7, 2), new DateOnly(2016, 9, 3), new List<string> { "Ghostwriting van nummers", "Arrangeren", "Componeren", "Partijen inspelen in de studio", "Studioplanning", "Mix- en masteringwerk", "Publiceren van muziek", "Meedenken aan het eindproduct van de artiest", "Studioplanning maken en handhaven" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2013, 3, 11), new DateOnly(2015, 8, 7), new List<string> { "Mensen te woord staan om ze wegwijs te maken in de wereld van de energie", "Technische ondersteuning bieden", "Administratief alles op orde maken", "Hulp en oplossingen bieden bij betalingsachterstanden" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 8, 6), new DateOnly(2024, 1, 1), new List<string> { "Programmeren in de frontend van de applicatie.", "Uitvoeren van scrum gerelateerde taken." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 1, 17), new DateOnly(2023, 6, 18), new List<string> { "Programmeren in de frontend van de applicatie.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Contactpersoon tussen verschillendestakeholders.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Presenteren en geven van demo's vanfuncties in de applicatie aan zowel deinterne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 10, 28), new DateOnly(2022, 5, 29), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 3, 13), new DateOnly(2024, 1, 1), new List<string> { "Deelname aan het ontwerp en destructurering van het project.", "Programmeren in de backend en front-end van de applicatie.", "Testen, debuggen en zoeken naaroplossingen voor problemen binnen hetproject.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2010, 11, 19), new DateOnly(2022, 1, 20), new List<string> { "Maken en ontwikkeling vanbedrijfskritische verzuimsoftwarevoornamelijk voor arbodiensten maar ookvoor bedrijfsartsen en werkgevers.", "Betrokkenheid bij ISO certificatie.", "Waar ik trots op ben, CBBS.", "Een systeem waar:", "A. Beroepen met functies en takenworden gekoppeld aan de fysieke enpsychische belasting.", "B. De taken bij het beroep per belastingeen kleur van de stoplicht krijgen, rood isnoodzakelijk en groen is niet vantoepassing.", "C. Ziektes.gekoppeld worden aan defysieke en psychische belasting. (Taken)", "D. Met een druk op een knop bepaaldwordt of bijvoorbeeld iemand met eengebroken voet nog zijn beroep, taken kanuitvoeren", "Het mooie van het systeem is dat erfuncties groen kunnen zijn. Dat betekenddat de werknemers vaak deels nog aanhet werk kunnen." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2005, 1, 4), new DateOnly(2010, 10, 5), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2003, 10, 23), new DateOnly(2004, 12, 24), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 3, 2), new DateOnly(2024, 1, 1), new List<string> { "Backend development" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 2, 15), new DateOnly(2022, 10, 16), new List<string> { "Web applicatie voor nummerportering via de REST API van vereniging COIN", "ERP Web applicatie voor een verloskundigepraktijk", "Service voor het synchroniseren van facturen met een online boekhoudprogramma" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2010, 9, 30), new DateOnly(2011, 1, 31), new List<string> { "Maken van een LabVIEW applicatie voor het aansturen van een pomp", "Optimalisatie van een hydrogenerigsreactie in een microreactor" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 7, 13), new DateOnly(2024, 1, 1), new List<string> { "Ontwikkelde en onderhield de backendcomponenten van Bee Portal.", "Testen, debuggen en zoeken naar oplossingen voor problemen binnen het project.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Ondersteuning van andere teamleden in een adviserende rol." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 3, 12), new DateOnly(2023, 7, 13), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2010, 7, 5), new DateOnly(2010, 8, 28), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2018, 3, 1), new DateOnly(2023, 9, 30), new List<string> { "Groep geholpen met basic vaardighedenvan programmeren.", "PO geholpen met het initieel vullen van deproduct backlog in Azure Devops.", "Groep gemotiveerd, gestimuleerd engeënthousiasmeerd met workshops enverhalen", "Zorgen dat alle vergaderingen goedingevuld en uitgevoerd worden." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2017, 5, 1), new DateOnly(2022, 11, 30), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2013, 5, 1), new DateOnly(2022, 3, 31), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2012, 8, 1), new DateOnly(2013, 4, 30), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2010, 8, 1), new DateOnly(2012, 7, 31), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2009, 1, 26), new DateOnly(2010, 7, 31), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2007, 10, 1), new DateOnly(2009, 1, 27), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2003, 6, 1), new DateOnly(2007, 11, 30), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(2001, 1, 16), new DateOnly(2003, 5, 31), new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { new DateOnly(1998, 5, 1), new DateOnly(2001, 1, 17), new List<string>() });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateTill",
                schema: "TalentenPortaal",
                table: "PastExperience",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateFrom",
                schema: "TalentenPortaal",
                table: "PastExperience",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateTill",
                schema: "TalentenPortaal",
                table: "EducationDetail",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateFrom",
                schema: "TalentenPortaal",
                table: "EducationDetail",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "Sept. 1980", "Juli 1988" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "Januari 1995", "December 1999" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "03/2019", "09/2019" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "09/2016", "03/2017" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "01/2012", "12/2016" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "2010", "2020" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "2009", "2010" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "2007", "2009" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "2023", "2023" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "2023", "2023" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "1985", "2020" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "2002", "2002" });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateFrom", "DateTill" },
                values: new object[] { "1998", "1998" });

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
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "januari 1990", "december 1998", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "januari 2000", "november 2021", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "maart 2022", "januari 2023", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "mei 2020", "maart 2023", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "juni 2019", "juli 2020", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "02/2019", "09/2019", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "10-2018", "10-2019", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "03-2023", "Heden", new List<string> { "De wensen van de stakeholdervertalen naar werkbare items inde backlog.", "Oplossingen vanuit het teambespreken met de stakeholder", "Testen, debuggen en zoekennaar oplossingen voorproblemen binnen het project.", "Deelname aan het ontwerp ende structurering van hetproject.", "Deelname aan planningstakenen werkitems binnen hetscrum-framework.", "Presenteren en geven vandemo's van functies in deapplicatie aan zowel de interneteams als externe klanten.", "Zoeken naar nieuweoplossingen en best practices-", "scenario's om de kwaliteit vanhet product te verbeteren.", "Structuur geven aan het team" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "12-2021", "02-2023", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "09-2021", "11-2021", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "08-2001", "08-2018", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "01-2020", "Heden", new List<string> { "Vertalen van de wensen van een klant aar een tastbaar product.", "Ondersteuning van andere teamleden in en adviserende rol.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Presenteren en geven van demo's van functies in de applicatie aan zowel de interne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en best practices-scenario's om de kwaliteit van het product te verbeteren." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "04-2018", "12-2018", new List<string> { "Coachende en begeleidende rol in het team", "Aanpakken van issues op zowel teamverband als persoonlijke hindernissen", "Motiveren en inspireren" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "07-2016", "09-2016", new List<string> { "Ghostwriting van nummers", "Arrangeren", "Componeren", "Partijen inspelen in de studio", "Studioplanning", "Mix- en masteringwerk", "Publiceren van muziek", "Meedenken aan het eindproduct van de artiest", "Studioplanning maken en handhaven" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "03-2014", "08-2015", new List<string> { "Mensen te woord staan om ze wegwijs te maken in de wereld van de energie", "Technische ondersteuning bieden", "Administratief alles op orde maken", "Hulp en oplossingen bieden bij betalingsachterstanden" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "08-2023", "Heden", new List<string> { "Programmeren in de frontend van de applicatie.", "Uitvoeren van scrum gerelateerde taken." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "01-2023", "06-2023", new List<string> { "Programmeren in de frontend van de applicatie.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Contactpersoon tussen verschillendestakeholders.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Presenteren en geven van demo's vanfuncties in de applicatie aan zowel deinterne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "10-2021", "05-2022", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "03-2023", "Heden", new List<string> { "Deelname aan het ontwerp en destructurering van het project.", "Programmeren in de backend en front-end van de applicatie.", "Testen, debuggen en zoeken naaroplossingen voor problemen binnen hetproject.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "11-2010", "1-2022", new List<string> { "Maken en ontwikkeling vanbedrijfskritische verzuimsoftwarevoornamelijk voor arbodiensten maar ookvoor bedrijfsartsen en werkgevers.", "Betrokkenheid bij ISO certificatie.", "Waar ik trots op ben, CBBS.", "Een systeem waar:", "A. Beroepen met functies en takenworden gekoppeld aan de fysieke enpsychische belasting.", "B. De taken bij het beroep per belastingeen kleur van de stoplicht krijgen, rood isnoodzakelijk en groen is niet vantoepassing.", "C. Ziektes.gekoppeld worden aan defysieke en psychische belasting. (Taken)", "D. Met een druk op een knop bepaaldwordt of bijvoorbeeld iemand met eengebroken voet nog zijn beroep, taken kanuitvoeren", "Het mooie van het systeem is dat erfuncties groen kunnen zijn. Dat betekenddat de werknemers vaak deels nog aanhet werk kunnen." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-2005", "10-2010", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "10-2003", "12-2004", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "03-2023", "Heden", new List<string> { "Backend development" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "2-2020", "10-2022", new List<string> { "Web applicatie voor nummerportering via de REST API van vereniging COIN", "ERP Web applicatie voor een verloskundigepraktijk", "Service voor het synchroniseren van facturen met een online boekhoudprogramma" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "09-2010", "01-2011", new List<string> { "Maken van een LabVIEW applicatie voor het aansturen van een pomp", "Optimalisatie van een hydrogenerigsreactie in een microreactor" } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "13/7/2023", "Heden", new List<string> { "Ontwikkelde en onderhield de backendcomponenten van Bee Portal.", "Testen, debuggen en zoeken naar oplossingen voor problemen binnen het project.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Ondersteuning van andere teamleden in een adviserende rol." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "12/3/2020", "12/7/2023", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "5/7/2010", "27/8/2010", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1/3/2023", "30/9/2023", new List<string> { "Groep geholpen met basic vaardighedenvan programmeren.", "PO geholpen met het initieel vullen van deproduct backlog in Azure Devops.", "Groep gemotiveerd, gestimuleerd engeënthousiasmeerd met workshops enverhalen", "Zorgen dat alle vergaderingen goedingevuld en uitgevoerd worden." } });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-5-2022", "30/11/2022", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-5-2013", "31-3-2022", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-8-2012", "30-4-2013", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-8-2010", "31-7-2012", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "26-1-2009", "31-7-2010", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-12-2007", "25-01-2009", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-6-2003", "30-11-2007", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "16-1-2001", "31-5-2003", new List<string>() });

            migrationBuilder.UpdateData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateFrom", "DateTill", "Tasks" },
                values: new object[] { "1-5-1998", "15-1-2001", new List<string>() });
        }
    }
}
