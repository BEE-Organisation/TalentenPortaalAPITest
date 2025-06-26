using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedLaborMarketRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LaborMarketRegionId",
                schema: "TalentenPortaal",
                table: "Talent",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LaborMarketRegion",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborMarketRegion", x => x.Id);
                });   

            migrationBuilder.CreateIndex(
                name: "IX_Talent_LaborMarketRegionId",
                schema: "TalentenPortaal",
                table: "Talent",
                column: "LaborMarketRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_LaborMarketRegion_LaborMarketRegionId",
                schema: "TalentenPortaal",
                table: "Talent",
                column: "LaborMarketRegionId",
                principalSchema: "TalentenPortaal",
                principalTable: "LaborMarketRegion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talent_LaborMarketRegion_LaborMarketRegionId",
                schema: "TalentenPortaal",
                table: "Talent");

            migrationBuilder.DropTable(
                name: "LaborMarketRegion",
                schema: "TalentenPortaal");

            migrationBuilder.DropIndex(
                name: "IX_Talent_LaborMarketRegionId",
                schema: "TalentenPortaal",
                table: "Talent");

            migrationBuilder.DropColumn(
                name: "LaborMarketRegionId",
                schema: "TalentenPortaal",
                table: "Talent");          
        }
    }
}
