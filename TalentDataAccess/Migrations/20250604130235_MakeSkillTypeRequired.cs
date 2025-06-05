using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MakeSkillTypeRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalentPropertySubCategoryLink_SkillType_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink");

            migrationBuilder.AlterColumn<int>(
                name: "SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TalentPropertySubCategoryLink_SkillType_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                column: "SkillTypeId",
                principalSchema: "TalentenPortaal",
                principalTable: "SkillType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalentPropertySubCategoryLink_SkillType_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink");

            migrationBuilder.AlterColumn<int>(
                name: "SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_TalentPropertySubCategoryLink_SkillType_SkillTypeId",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                column: "SkillTypeId",
                principalSchema: "TalentenPortaal",
                principalTable: "SkillType",
                principalColumn: "Id");
        }
    }
}
