using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedSkillType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SkillType",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillType", x => x.Id);
                });

            migrationBuilder.Sql(@"
                INSERT INTO ""TalentenPortaal"".""SkillType"" (""Id"", ""Name"") VALUES
                (1, 'Vaardigheid'),
                (2, 'Spreken'),
                (3, 'Schrijven');
            ");

            // Update existing TalentPropertySubCategoryLink records to set SkillTypeId to 1 (Algemeen) for all TalentPropertyLabels with names other then "talen"
            migrationBuilder.Sql(@"
                UPDATE ""TalentenPortaal"".""TalentPropertySubCategoryLink""
                SET ""SkillTypeId"" = 1
                WHERE ""TalentPropertyMainCategoryLinkId"" NOT IN (
                    SELECT ""Id""
                    FROM ""TalentenPortaal"".""TalentPropertyMainCategoryLink""
                    WHERE ""TalentPropertyLabelId"" = 2
                );
            ");

            // Update existing TalentPropertySubCategoryLink records to set SkillTypeId to 2 (Spreken) for TalentPropertyLabels with name "talen"
            migrationBuilder.Sql(@"
                UPDATE ""TalentenPortaal"".""TalentPropertySubCategoryLink""
                SET ""SkillTypeId"" = 2
                WHERE ""TalentPropertyMainCategoryLinkId"" IN (
                    SELECT ""Id""
                    FROM ""TalentenPortaal"".""TalentPropertyMainCategoryLink""
                    WHERE ""TalentPropertyLabelId"" = 2
                );
            ");

            migrationBuilder.CreateIndex(
                name: "IX_TalentPropertySubCategoryLink_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                column: "SkillTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TalentPropertySubCategoryLink_SkillType_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                column: "SkillTypeId",
                principalSchema: "TalentenPortaal",
                principalTable: "SkillType",
                principalColumn: "Id");

            migrationBuilder.Sql(@"
                INSERT INTO ""TalentenPortaal"".""TalentPropertySubCategoryLink""
                    (""TalentPropertyLabelId"", ""SkillLevel"", ""Order"", ""TalentPropertyMainCategoryLinkId"", ""SkillTypeId"")
                SELECT 
                    ""TalentPropertyLabelId"",
                    ""SkillLevel"",
                    ""Order"",
                    ""TalentPropertyMainCategoryLinkId"",
                    3 AS ""SkillTypeId""
                FROM ""TalentenPortaal"".""TalentPropertySubCategoryLink""
                WHERE ""SkillTypeId"" = 2;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalentPropertySubCategoryLink_SkillType_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink");

            migrationBuilder.DropTable(
                name: "SkillType",
                schema: "TalentenPortaal");

            migrationBuilder.DropIndex(
                name: "IX_TalentPropertySubCategoryLink_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink");

            migrationBuilder.DropColumn(
                name: "SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink");

            migrationBuilder.Sql(@"
                DELETE FROM ""TalentenPortaal"".""TalentPropertySubCategoryLink"" t3
                WHERE t3.""SkillTypeId"" = 3;
            ");
        }
    }
}
