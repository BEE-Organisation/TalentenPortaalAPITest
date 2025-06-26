using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedLaborMarketRegionsToTable : Migration
    {
        /// <inheritdoc />

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "LaborMarketRegion",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Groningen" },
                    { 2, "Friesland" },
                    { 3, "Noord-Holland (Noord)" },
                    { 4, "Drenthe" },
                    { 5, "Regio Zwolle" },
                    { 6, "Flevoland" },
                    { 7, "Zaanstreek / Waterland" },
                    { 8, "Zuid-Kennemerland en IJmond" },
                    { 9, "Twente" },
                    { 10, "Groot Amsterdam" },
                    { 11, "Veluwe Stedendriehoek" },
                    { 12, "Gooi en Vechtstreek" },
                    { 13, "Holland Rijnland" },
                    { 14, "Midden-Utrecht" },
                    { 15, "Amersfoort" },
                    { 16, "FoodValley" },
                    { 17, "Achterhoek" },
                    { 18, "Zuid-Holland Centraal" },
                    { 19, "Midden-Holland" },
                    { 20, "Haaglanden" },
                    { 21, "Midden-Gelderland" },
                    { 22, "Rijnmond" },
                    { 23, "Rivierenland" },
                    { 24, "Gorinchem" },
                    { 25, "Rijk van Nijmegen" },
                    { 26, "Drechtsteden" },
                    { 27, "Noordoost-Brabant" },
                    { 28, "West-Brabant" },
                    { 29, "Zeeland" },
                    { 30, "Midden-Brabant" },
                    { 31, "Noord-Limburg" },
                    { 32, "Helmond-De Peel" },
                    { 33, "Zuidoost-Brabant" },
                    { 34, "Midden-Limburg" },
                    { 35, "Zuid-Limburg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (int id = 1; id <= 35; id++)
            {
                migrationBuilder.DeleteData(
                    schema: "TalentenPortaal",
                    table: "LaborMarketRegion",
                    keyColumn: "Id",
                    keyValue: id);
            }
        }
    }
}
