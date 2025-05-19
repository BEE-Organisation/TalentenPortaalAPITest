using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TalentDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initialsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TalentenPortaal");

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CompanyLogoUrl = table.Column<string>(type: "text", nullable: false),
                    Creator = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    TalentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Theme = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalentPropertyLabel",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentPropertyLabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacancyDemand",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HoursMin = table.Column<decimal>(type: "numeric", nullable: false),
                    HoursMax = table.Column<decimal>(type: "numeric", nullable: false),
                    HourType = table.Column<int>(type: "integer", nullable: false),
                    EducationLevel = table.Column<string>(type: "text", nullable: false),
                    SkillLevel = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyDemand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacancyDemandDetail",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentProperties = table.Column<int[]>(type: "integer[]", nullable: false),
                    ChildProperties = table.Column<int[]>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyDemandDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacancyOffer",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SalaryMin = table.Column<decimal>(type: "numeric", nullable: false),
                    SalaryMax = table.Column<decimal>(type: "numeric", nullable: false),
                    SalaryType = table.Column<int>(type: "integer", nullable: false),
                    MonthsMin = table.Column<int>(type: "integer", nullable: false),
                    MonthsMax = table.Column<int>(type: "integer", nullable: false),
                    ContractType = table.Column<int>(type: "integer", nullable: false),
                    SecondaryConditions = table.Column<int[]>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyOffer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacancyText",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    ShowCompanyInfo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Talent",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Initials = table.Column<string>(type: "text", nullable: false),
                    GivenName = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    NamePrefix = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Municipality = table.Column<string>(type: "text", nullable: false),
                    Province = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    HouseNumber = table.Column<string>(type: "text", nullable: false),
                    HouseNumberSuffix = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    LinkedInUrl = table.Column<string>(type: "text", nullable: false),
                    ContactOptions = table.Column<string>(type: "text", nullable: false),
                    ProfilePhotoRef = table.Column<string>(type: "text", nullable: false),
                    PitchUrl = table.Column<string>(type: "text", nullable: false),
                    LoopUrl = table.Column<string>(type: "text", nullable: false),
                    CvUrl = table.Column<string>(type: "text", nullable: false),
                    OrganisationId = table.Column<int>(type: "integer", nullable: true),
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Education = table.Column<string>(type: "text", nullable: false),
                    TravelDistance = table.Column<int>(type: "integer", nullable: false),
                    DesiredWorkLocation = table.Column<string>(type: "text", nullable: false),
                    AvailableHours = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    FoundJob = table.Column<bool>(type: "boolean", nullable: false),
                    WorksAtCompany = table.Column<string>(type: "text", nullable: false),
                    IsProfileVisible = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Talent_Organization_OrganisationId",
                        column: x => x.OrganisationId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VacancyComplete",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    VacancyOfferId = table.Column<int>(type: "integer", nullable: true),
                    VacancyDemandId = table.Column<int>(type: "integer", nullable: true),
                    VacancyDemandDetailId = table.Column<int>(type: "integer", nullable: true),
                    VacancyTextId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    IsEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyComplete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyComplete_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VacancyComplete_VacancyDemandDetail_VacancyDemandDetailId",
                        column: x => x.VacancyDemandDetailId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "VacancyDemandDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VacancyComplete_VacancyDemand_VacancyDemandId",
                        column: x => x.VacancyDemandId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "VacancyDemand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VacancyComplete_VacancyOffer_VacancyOfferId",
                        column: x => x.VacancyOfferId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "VacancyOffer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VacancyComplete_VacancyText_VacancyTextId",
                        column: x => x.VacancyTextId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "VacancyText",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EducationDetail",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateFrom = table.Column<string>(type: "text", nullable: false),
                    DateTill = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Institution = table.Column<string>(type: "text", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    TalentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetail_Talent_TalentId",
                        column: x => x.TalentId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PastExperience",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateFrom = table.Column<string>(type: "text", nullable: false),
                    DateTill = table.Column<string>(type: "text", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: false),
                    Function = table.Column<string>(type: "text", nullable: false),
                    Tasks = table.Column<List<string>>(type: "text[]", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    TalentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PastExperience_Talent_TalentId",
                        column: x => x.TalentId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalentPropertyMainCategoryLink",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalentPropertyLabelId = table.Column<int>(type: "integer", nullable: false),
                    TalentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentPropertyMainCategoryLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentPropertyMainCategoryLink_Talent_TalentId",
                        column: x => x.TalentId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalentPropertySubCategoryLink",
                schema: "TalentenPortaal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalentPropertyLabelId = table.Column<int>(type: "integer", nullable: false),
                    SkillLevel = table.Column<int>(type: "integer", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    TalentPropertyMainCategoryLinkId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentPropertySubCategoryLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentPropertySubCategoryLink_TalentPropertyMainCategoryLin~",
                        column: x => x.TalentPropertyMainCategoryLinkId,
                        principalSchema: "TalentenPortaal",
                        principalTable: "TalentPropertyMainCategoryLink",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "Company",
                columns: new[] { "Id", "CompanyLogoUrl", "Creator", "Description", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "https://beeideasstorage.blob.core.windows.net/talentenportaal/company-logos/gemeente_dinodrecht.png", "", "De gemeente Dinodrecht is altijd op zoek naar nieuwe IT'ers.", "gemeente@dinodrecht.nl", "Gemeente Dinodrecht" },
                    { 2, "https://beeideasstorage.blob.core.windows.net/talentenportaal/company-logos/white_seal_it_detachering.jpg", "", "Regelmatig is White Seal IT Detachering op zoek naar nieuwe IT talenten.", "algemeen@white-seals.nl", "White Seal IT Detachering" },
                    { 3, "https://beeideasstorage.blob.core.windows.net/talentenportaal/company-logos/vwu_werkbedrijf.png", "", "Het WVU Werkbedrijf is een organisatie die personen zal begeleiden naar een werkplaats binnen de IT-wereld.", "contact@wvu-werkbedrijf.nl", "WVU Werkbedrijf" }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "Hobby",
                columns: new[] { "Id", "Name", "Order", "TalentId" },
                values: new object[,]
                {
                    { 1, "Glas-in-lood maken", 0, 1 },
                    { 2, "Doe-het-zelven", 1, 1 },
                    { 3, "3D-printen", 2, 1 },
                    { 4, "Apps ontwikkelen", 3, 1 },
                    { 5, "Puzzelen", 4, 1 },
                    { 6, "Kaarten maken", 0, 2 },
                    { 7, "Hardlopen", 1, 2 },
                    { 8, "Skateboarden", 2, 2 },
                    { 9, "Podcast maken", 3, 2 },
                    { 10, "Yoga", 4, 2 },
                    { 11, "Schilderen", 0, 3 },
                    { 12, "Muziek luisteren", 1, 3 },
                    { 13, "Podcast maken", 2, 3 },
                    { 14, "Lezen", 3, 3 },
                    { 15, "Robots bouwen", 4, 3 },
                    { 16, "Een radiozender beginnen", 0, 4 },
                    { 17, "Modelbouw", 1, 4 },
                    { 18, "Drones bouwen/besturen", 2, 4 },
                    { 19, "Breien of haken", 3, 4 },
                    { 20, "Wandelen", 4, 4 },
                    { 21, "Tekenen", 0, 5 },
                    { 22, "Surfen", 1, 5 },
                    { 23, "Kleding maken", 2, 5 },
                    { 24, "Wandelen", 3, 5 },
                    { 25, "Lezen", 4, 5 },
                    { 26, "Pilates", 0, 6 },
                    { 27, "Sterrenkijken", 1, 6 },
                    { 28, "Auto’s restaureren", 2, 6 },
                    { 29, "Sieraden maken", 3, 6 },
                    { 30, "Keramiek", 4, 6 },
                    { 31, "Podcast maken", 0, 7 },
                    { 32, "Een radiozender beginnen", 1, 7 },
                    { 33, "Programmeren", 2, 7 },
                    { 34, "Basketbal", 3, 7 },
                    { 35, "Kleding maken", 4, 7 },
                    { 36, "Koken", 0, 8 },
                    { 37, "Reizen", 1, 8 },
                    { 38, "Wandelen", 2, 8 },
                    { 39, "Fietsen", 3, 8 },
                    { 40, "Muziek maken", 0, 9 },
                    { 41, "Gamen", 1, 9 },
                    { 42, "Hardlopen", 2, 9 },
                    { 43, "Film liefhebber", 3, 9 },
                    { 44, "Festivallen", 4, 9 },
                    { 45, "Video Games", 0, 10 },
                    { 46, "Schrijven", 1, 10 },
                    { 47, "Rollenspel (DnD)", 2, 10 },
                    { 48, "Wandelen", 0, 11 },
                    { 49, "De natuur", 1, 11 },
                    { 50, "Gewichtheffen", 0, 12 },
                    { 51, "Gamen", 1, 12 },
                    { 52, "Mountainbiken", 0, 13 },
                    { 53, "Microcontrollers Programmeren", 1, 13 },
                    { 54, "Fietsen onderhouden", 2, 13 },
                    { 55, "Films/Series kijken", 3, 13 },
                    { 56, "Computer spellen", 4, 13 },
                    { 57, "Wandelen met hond", 5, 13 },
                    { 58, "Hockey", 0, 14 },
                    { 59, "Wandelen", 1, 14 },
                    { 60, "Musea en theaters bezoeken", 2, 14 }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "Organization",
                columns: new[] { "Id", "Description", "Name", "Theme" },
                values: new object[,]
                {
                    { 1, "Talenten-Portaal zorgt voor begeleiding naar werk in de IT-Sector.", "Talenten-Portaal", 0 },
                    { 2, "Het Leer/Werk Loket zorgt voor begeleiding naar werk in de IT-Sector.", "Leer/Werk Loket", 1 },
                    { 3, "Het UWV (Uitvoeringsinstituut Werknemersverzekeringen) is een betrokken partij die kandidaten ondersteunen in het vinden van werk.", "UWV", 0 },
                    { 4, "WSP staat beter bekend als het WerkgeversServicepunt en geeft werkgevers advies en ondersteuning bij de werving en selectie van personeel.", "WSP", 0 },
                    { 5, "De Bee-Organisatie leidt IT-professionals op. Ook is er begeleiding naar werk.", "Bee", 0 }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "Talent",
                columns: new[] { "Id", "AvailableHours", "ContactOptions", "CountryCode", "CvUrl", "DateOfBirth", "Description", "DesiredWorkLocation", "Education", "Email", "FoundJob", "GivenName", "HouseNumber", "HouseNumberSuffix", "Initials", "IsProfileVisible", "JobTitle", "LinkedInUrl", "LoopUrl", "Municipality", "Name", "NamePrefix", "OrganisationId", "PhoneNumber", "PitchUrl", "PostalCode", "ProfilePhotoRef", "Province", "Street", "Surname", "TravelDistance", "WorksAtCompany" },
                values: new object[,]
                {
                    { 1, 20.00m, "email, telefonisch", "", "", new DateTime(1955, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maakt mensen graag aan het lachen.", "Remote", "WO", "", false, "", "", "", "", true, "Product Owner", "", "", "Eindhoven", "Mister Bean", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 2, 40.00m, "email, telefonisch", "", "", new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debiteuren en crediteuren is echt zijn ding.", "Thuis/Kantoor", "HBO", "", false, "", "", "", "", true, "Scrum Master", "", "", "Den Bosch", "Christian", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 3, 32.00m, "email, telefonisch", "", "", new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Een echte kei in Desktop Publishing.", "Remote", "MBO", "", false, "", "", "", "", true, "Senior Developer", "", "", "Breda", "Carolien", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 4, 32.00m, "email, telefonisch", "", "", new DateTime(1988, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verkoopt graag in een winkel.", "Remote/Kantoor", "MBO", "", false, "", "", "", "", true, "Junior Frontend Developer", "", "", "Tilburg", "Saskia", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 5, 36.00m, "email, telefonisch", "", "", new DateTime(1987, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brengt graag mensen naar een bestemming.", "Remote", "MBO", "", false, "", "", "", "", true, "Frontend Developer", "", "", "Goirle", "Matilda", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 6, 40.00m, "email, telefonisch", "", "", new DateTime(1990, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administratie is haar lust en haar leven.", "Remote/Kantoor", "MBO", "", false, "", "", "", "", true, "Backend Developer", "", "", "Waalwijk", "Jane", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 7, 28.00m, "email, telefonisch", "", "", new DateTime(1991, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maakt ook graag een praatje met de mensen.", "Remote", "MBO", "", false, "", "", "", "", true, "Fullstack Developer", "", "", "Dongen", "Judith", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Noord-Brabant", "", "", 0, "" },
                    { 8, 40.00m, "email, telefonisch, LinkedIn", "", "", new DateTime(1972, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mijn passie is om mensen behulpzaam te zijn door producten te maken die mensen helpen in hun dagelijkse werkzaamheden. Als Product Owner/ (Scrum Master/Projectleider) ben ik de bruggenbouwer die hier dagelijks voor zorgt en hier haal ik elke dag veel voldoening uit. In de toekomst wil ik meer complexere vraagstukken vanuit de business kunnen vertalen naar goede software matige oplossingen. Bij BEE-Ideas heb ik beide aspecten van het SCRUM proces leren kennen doordat ik zowel de rol van Product Owner als de rol van Scrum Master heb bekleed.", "Hybride - Thuis/Kantoor", "HBO", "", false, "", "", "", "", true, "Product Owner", "https://www.linkedin.com/in/dennis-olislagers-442b3a68", "https://beeideasstorage.blob.core.windows.net/talentenportaal/video_loops/DENNIS_2_THUMBNAIL-853_480.mp4", "Maastricht", "Dennis", "", null, "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV DENNIS.mp4", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/dennis2.jpg", "Limburg", "", "", 50, "" },
                    { 9, 40.00m, "email", "", "", new DateTime(1994, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Websites maken, gamen, het web afstruinen, computers bouwen - van kinds af aan fascineerde de IT mij al.  Tijdens mijn carriere in de ruimtelijke ordening heb ik veel vaardigheid ontwikkeld in projectmatig werken - zowel zelfstandig als in teamverband. Ik kreeg echter te weinig uitdaging en mijn interesse in het vak ebde weg .  Nadat ik in 2017 door een operatie van epilepsie ben genezen, heb ik besloten om van mijn liefde voor de IT - en met name front-end development - mijn beroep te gaan maken. Met cursussen, een IT-traineeship en zelfstandige projecten heb ik een professioneel niveau bereikt.", "Remote", "WO", "", false, "", "", "", "", true, "Front End Developer", "", "", "Nijmegen", "Michiel", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/michiel.jpg", "Gelderland", "", "", 60, "" },
                    { 10, 32.00m, "email, telefonisch, LinkedIn", "", "", new DateTime(1992, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ik omschrijf mijzelf als een positief persoon die altijd direct op zoek gaat naar de juiste oplossing voor een probleem. Over de jaren ben ik erg gegroeid in het herkennen van mijn goede kwaliteiten maar zo ook mijn valkuilen. Communicatie vind ik zeer belangrijk.  Op een technisch niveau heb ik interesse in front-end development en wil mij daar ook graag verder in ontwikkelen. Tijdens mijn opleiding heb ik grotendeels met PHP gewerkt met de OOP methode. SQL kwam ook te pas. In mijn zelfstudie heb ik mij verdiept in React.js.", "Hybride - Remote/Kantoor", "MBO", "", false, "", "", "", "", true, "Applicatie- en Mediaontwikkelaar", "https://www.linkedin.com/in/kelvinkohl", "", "Heerlen", "Kelvin", "", null, "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV KELVIN.mp4", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/kelvin.jpg", "Limburg", "", "", 100, "" },
                    { 11, 40.00m, "email, telefonisch", "", "", new DateTime(1960, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Als werknemer wens ik als loyale teamplayer intellectueel uitgedaagd te worden. Het geeft mij voldoening tegenslagen te overwinnen en samen fantastische prestaties te behalen. Ik vind het heerlijk om gezamenlijk (maar soms ook zelfstandig) een zowel technisch als functioneel kwalitatief hoogstaand product op te leveren.", "Remote", "WO", "", false, "", "", "", "", true, "Fullstack Software Engineer", "", "", "Nijmegen", "John", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/john.jpg", "Gelderland", "", "", 40, "" },
                    { 12, 36.00m, "email", "", "", new DateTime(1986, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ik vind het leuk om te programmeren, ben  hier ook in mijn vrije tijd veel mee bezig. Zo heb ik bijvoorbeeld een berechtingssyteem gemaakt voor gewichthefwedstrijden op basis van een arduino. Ik kan goed zelfstandig werken. Ook doe ik mijn werk secuur en met veel aandacht voor details.", "Hybride - Remote/Kantoor", "HBO", "", false, "", "", "", "", true, "Fullstack Software Engineer", "", "", "Valkenswaard", "Peter", "", null, "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV PETER.mp4", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/peter.jpg", "Noord-Brabant", "", "", 40, "" },
                    { 13, 36.00m, "email, telefonisch, LinkedIn", "", "", new DateTime(1988, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ik ben een gedreven software-ontwikkelaar met een sterke technische achtergrond en een passie voor innovatie. Mijn\r\nvoortdurende zoektocht naar uitdagingen stelt me in staat om op de hoogte te blijven van de nieuwste technologische trends en\r\ndeze toe te passen om bestaande projecten te versterken en nieuwe te initiëren. Mijn ambitie is om samen met getalenteerde\r\nteams hoogwaardige producten te creëren waar we allemaal trots op zijn. Mijn focus ligt op het leveren van kwaliteit en het\r\nontwikkelen van innovatieve, probleemoplossende oplossingen.", "Remote", "HBO", "", false, "", "", "", "", true, "Software Engineer", "https://www.linkedin.com/in/roel-van-deursen-851058231", "", "Someren", "Roel", "", null, "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/temp-videos/CV ROEL.mp4", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/roel.jpg", "Noord-Brabant", "", "", 50, "" },
                    { 14, 36.00m, "email, telefonisch, LinkedIn", "", "", new DateTime(1960, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technisch onderlegde en didactisch vaardige scrum master.Door diverse functies in software engineering ben ik technischonderlegd in allerlei takken van software ontwikkeling. Tevensheb ik jarenlang als docent wiskunde voor de klas gestaanwaarbij diverse sturende en motiverende vaardigheden belangrijkzijn. Tot mijn verrassing komen vele onderdelen uit deze functiesheel mooi samen in de rol van een scrum master. Ik wil nu graagalles combineren en inzetten om tot een mooi mogelijk resultaatte komen met een scrum team.", "Hybride - Remote/Kantoor", "HBO", "", false, "", "", "", "", true, "Scrum Master / Product Owner", "https://www.linkedin.com/in/jos-broeren4918833", "", "Grave", "Jos", "", null, "", "", "", "https://beeideasstorage.blob.core.windows.net/talentenportaal/images/jos.jpg", "Noord-Brabant", "", "", 40, "" }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "TalentPropertyLabel",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "HCM Competenties", null },
                    { 2, "Talen", null },
                    { 3, "Methoden & technieken", null },
                    { 4, "Softwarepakketten & -tools", null },
                    { 5, "Programmeer- & scriptingtalen", null },
                    { 6, "Frameworks & databases", null },
                    { 7, "Rijbewijs", null },
                    { 8, "Karakterkenmerken", null },
                    { 9, "Secundaire Arbeidsvoorwaarden", null },
                    { 10, "Proactiviteit", 1 },
                    { 11, "Communicatieve vaardigheden", 1 },
                    { 12, "Discipline", 1 },
                    { 13, "Emotionele stabiliteit", 1 },
                    { 14, "Integriteit", 1 },
                    { 15, "Analytische kwaliteiten", 1 },
                    { 16, "Creativiteit", 1 },
                    { 17, "Beïnvloedende kwaliteiten", 1 },
                    { 18, "Organisatorische kwaliteiten", 1 },
                    { 19, "Leiderschapskwaliteiten", 1 },
                    { 20, "Nederlands", 2 },
                    { 21, "Engels", 2 },
                    { 22, "Duits", 2 },
                    { 23, "Frans", 2 },
                    { 24, "Spaans", 2 },
                    { 25, "Agile", 3 },
                    { 26, "Agile/Scrum", 3 },
                    { 27, "Scrum", 3 },
                    { 28, "OOP", 3 },
                    { 29, "TDD", 3 },
                    { 30, "VM Mangement", 3 },
                    { 31, "Stakeholdermanagement", 3 },
                    { 32, "Projectmanagement", 3 },
                    { 33, "Software Development", 3 },
                    { 34, "Productmanagement", 3 },
                    { 35, "IntelliJ IDEA", 4 },
                    { 36, "JetBrains", 4 },
                    { 37, "VS Code", 4 },
                    { 38, "Azure DevOps", 4 },
                    { 39, "Visual Studio", 4 },
                    { 40, "Visual Studio 2019", 4 },
                    { 41, "Visual Studio 2022", 4 },
                    { 42, "Godot", 4 },
                    { 43, "Gdscript", 4 },
                    { 44, "Adobe CC", 4 },
                    { 45, "Npm", 4 },
                    { 46, "Git", 4 },
                    { 47, "Microsoft Office", 4 },
                    { 48, "Webstorm", 4 },
                    { 49, "C#", 5 },
                    { 50, "C", 5 },
                    { 51, "C++", 5 },
                    { 52, "ASP.Net MVC", 5 },
                    { 53, ".NET Core", 5 },
                    { 54, "Java", 5 },
                    { 55, "JavaScript", 5 },
                    { 56, "TypeScript", 5 },
                    { 57, "HTML 5", 5 },
                    { 58, "HTML", 5 },
                    { 59, "CSS", 5 },
                    { 60, "CSS3", 5 },
                    { 61, "SCSS/SASS", 5 },
                    { 62, "PHP", 5 },
                    { 63, "Visual Basic", 5 },
                    { 64, "Python", 5 },
                    { 65, "Delphi", 5 },
                    { 66, "Angular", 6 },
                    { 67, "MySQL", 6 },
                    { 68, "SQL Server", 6 },
                    { 69, "Mongo DB", 6 },
                    { 70, "MongoDB", 6 },
                    { 71, "VueJS", 6 },
                    { 72, "NodeJS", 6 },
                    { 73, "SQL", 6 },
                    { 74, "MariaDB", 6 },
                    { 75, "SQLite", 6 },
                    { 76, "React.js", 6 },
                    { 77, "Bootstrap", 6 },
                    { 78, "Entity Framework", 6 },
                    { 79, "Notes-Domino", 6 },
                    { 80, "geen", 7 },
                    { 81, "AM - Brommer", 7 },
                    { 82, "A - Motor", 7 },
                    { 83, "B - Personenauto", 7 },
                    { 84, "BE - Auto met aanhanger", 7 },
                    { 85, "C - Vrachtwagen", 7 },
                    { 86, "CE - Vrachtwagen met aanhanger", 7 },
                    { 87, "Code 95 - Heftruck", 7 },
                    { 88, "Creatief", 8 },
                    { 89, "Nieuwsgierigheid", 8 },
                    { 90, "Kritisch denken, beoordelingsvermogen", 8 },
                    { 91, "Leergierigheid", 8 },
                    { 92, "Levenswijs", 8 },
                    { 93, "Moed", 8 },
                    { 94, "Doorzettingsvermogen", 8 },
                    { 95, "Oprechtheid", 8 },
                    { 96, "Enthousiast/levenslustig", 8 },
                    { 97, "Liefde", 8 },
                    { 98, "Vriendelijkheid", 8 },
                    { 99, "Sociale intelligentie", 8 },
                    { 100, "Samenwerking", 8 },
                    { 101, "Rechtvaardigheid", 8 },
                    { 102, "Leiderschap", 8 },
                    { 103, "Vergevingsgezindheid", 8 },
                    { 104, "Bescheidenheid", 8 },
                    { 105, "Bedachtzaam", 8 },
                    { 106, "Zelfregulatie", 8 },
                    { 107, "Waardering van schoonheid en excellentie", 8 },
                    { 108, "Dankbaarheid", 8 },
                    { 109, "Hoopvol", 8 },
                    { 110, "Humor", 8 },
                    { 111, "Spiritualiteit", 8 },
                    { 112, "Auto van de zaak", 9 },
                    { 113, "Lease-auto", 9 },
                    { 114, "Telefoon", 9 },
                    { 115, "Mobiele telefoon", 9 },
                    { 116, "Pensioenopbouw", 9 },
                    { 117, "Leuke uitjes", 9 },
                    { 118, "Vrijdagmiddagborrels", 9 },
                    { 119, "Dertiende maand", 9 },
                    { 120, "Flexibele uren", 9 }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "VacancyDemand",
                columns: new[] { "Id", "EducationLevel", "HourType", "HoursMax", "HoursMin", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "MBO", 2, 40m, 20m, "Beginner" },
                    { 2, "HBO", 1, 40m, 32m, "Senior" },
                    { 3, "MBO", 2, 40m, 36m, "Geen" }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "VacancyDemandDetail",
                columns: new[] { "Id", "ChildProperties", "ParentProperties" },
                values: new object[,]
                {
                    { 1, new[] { 15, 20, 21, 26, 56, 55, 66 }, new[] { 1, 2, 3, 5, 6 } },
                    { 2, new[] { 10, 11, 12, 15, 20, 21, 22, 27, 28, 40, 41, 49, 68, 88, 89, 90, 94 }, new[] { 1, 2, 3, 4, 5, 6, 8 } },
                    { 3, new[] { 20, 21, 27, 28, 41, 55, 56, 66, 88, 89, 94, 98, 110 }, new[] { 2, 3, 4, 5, 6, 8 } }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "VacancyOffer",
                columns: new[] { "Id", "ContractType", "MonthsMax", "MonthsMin", "SalaryMax", "SalaryMin", "SalaryType", "SecondaryConditions" },
                values: new object[,]
                {
                    { 1, 3, 12, 6, 2500m, 1000m, 1, new[] { 115, 117, 118, 120 } },
                    { 2, 1, 12, 12, 3000m, 1250m, 1, new[] { 113, 114, 116 } },
                    { 3, 5, 6, 6, 300m, 0m, 2, new[] { 117, 118, 120 } }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "VacancyText",
                columns: new[] { "Id", "ShowCompanyInfo", "Text" },
                values: new object[,]
                {
                    { 1, true, "De Gemeente Dinodrecht zoekt een beginnende tester." },
                    { 2, true, "White Seals IT Detachering is op zoek naar een Senior C# programmeur." },
                    { 3, true, "Het WVU werkbedrijf biedt een stage aan voor een Frontend programmeur Angular." }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "EducationDetail",
                columns: new[] { "Id", "Comments", "DateFrom", "DateTill", "Institution", "Name", "TalentId" },
                values: new object[,]
                {
                    { 1, "De opleiding duurde lang door de vele ongelukken.", "Sept. 1980", "Juli 1988", "Britse Beeldbuis Club (BBC)", "Acteuropleiding", 1 },
                    { 2, "", "Januari 1995", "December 1999", "Nyenrode Business University", "Master Business Adminstration (MBA)", 2 },
                    { 3, "", "03/2019", "09/2019", "LOI", "Redacteren kun je leren", 3 },
                    { 4, "Certificaat niet behaald.", "09/2016", "03/2017", "Oranje licht? Dan gas geven!", "Taxidienst voor gevorderden", 5 },
                    { 5, "", "01/2012", "12/2016", "HRO Rotterdam", "Office Management", 6 },
                    { 6, "", "", "", "HBO", "Software Development", 8 },
                    { 7, "", "", "", "", "Vapro-C", 8 },
                    { 8, "", "", "", "", "Vapro-B", 8 },
                    { 9, "", "", "", "Scrum.org", "PSM1", 8 },
                    { 10, "(Bezig met)", "", "", "Scrum.org", "PSPO1", 8 },
                    { 11, "", "", "", "HBO", "Communicatie; International Event Music and Entertainment industrie", 9 },
                    { 12, "", "", "", "MBO", "Rock City Institute", 9 },
                    { 13, "", "", "", "MBO", "Juridisch Medewerker", 9 },
                    { 14, "", "", "", "Scrum.org", "Professional Scrum Master I", 9 },
                    { 15, "", "", "", "", "Wft Zorgverzekeringen 2019", 9 },
                    { 16, "", "", "", "", "Wft Basis", 9 },
                    { 17, "", "", "", "", "Volver Sound Academy", 9 },
                    { 18, "", "", "", "", "Adecco CEO for One Month", 9 },
                    { 19, "", "", "", "", "Ascensos Communicatie Training", 9 },
                    { 20, "", "", "", "Trevianum Sittard", "HAVO", 10 },
                    { 21, "", "", "", "Vista College Maastricht", "MBO 4 Applicatie en Mediaontwikkelaar", 10 },
                    { 22, "Work in Progress", "", "", "Scrum.org", "PSM1", 10 },
                    { 23, "", "", "", "LOI", "HBO Informatica", 11 },
                    { 24, "", "", "", "Open Universiteit", "Milieukunde", 11 },
                    { 25, "", "", "", "", "HAVO", 11 },
                    { 26, "", "", "", "Scrum.org", "Professional Scrum Master", 11 },
                    { 27, "", "", "", "", "Developing ASP.NET MVC Web Applications", 11 },
                    { 28, "", "", "", "", "Angular Development", 11 },
                    { 29, "", "", "", "", "Programming in HTML 5 with Javascript and CSS3", 11 },
                    { 30, "", "", "", "", "Microsoft DEV204.1x Introduction to C#", 11 },
                    { 31, "Propedeuse", "", "", "HBO", "Applied Science", 12 },
                    { 32, "", "", "", "Scrum.org", "PSM1", 12 },
                    { 33, "", "2010", "2020", "HBO", "Toegepaste Psychologie", 13 },
                    { 34, "", "2009", "2010", "HBO", "Milieukunde", 13 },
                    { 35, "", "2007", "2009", "HBO", "Informatica", 13 },
                    { 36, "", "", "", "", "Codeacademy C#", 13 },
                    { 37, "", "", "", "Scrum.org", "Professional Scrum Master 1", 13 },
                    { 38, "", "", "", "learncpp.com", "Learn C++", 13 },
                    { 39, "", "", "", "HBO", "HAN Leraren opleiding Wis-/Natuurkunde", 14 },
                    { 40, "", "2023", "2023", "Bee-Ideas", "Capacity building inclusief PSM1 certificering", 14 },
                    { 41, "", "2023", "2023", "", "Agile Scrum Foundation", 14 },
                    { 42, "", "1985", "2020", "", "Diverse programmeertalen en operating systemen", 14 },
                    { 43, "", "2002", "2002", "", "Teamleider", 14 },
                    { 44, "", "1998", "1998", "", "Effectief communiceren", 14 }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "PastExperience",
                columns: new[] { "Id", "Company", "DateFrom", "DateTill", "Description", "Function", "TalentId", "Tasks" },
                values: new object[,]
                {
                    { 1, "Lachen, Gieren, Brullen Entertainment", "januari 1990", "december 1998", "", "Kwaliteits-entertainer", 1, new List<string>() },
                    { 2, "De Wolven van Wallstreet", "januari 2000", "november 2021", "", "Leidinggevend Boekhouder", 2, new List<string>() },
                    { 3, "Drukkerij en Uitgeverij De inktvis.", "maart 2022", "januari 2023", "", "Redactrice", 3, new List<string>() },
                    { 4, "Bloempot BV", "mei 2020", "maart 2023", "", "Bloemenverkoopster", 4, new List<string>() },
                    { 5, "Taxidienst Quick", "juni 2019", "juli 2020", "", "Chauffeur", 5, new List<string>() },
                    { 6, "Mensen, potloden en stompies BV", "02/2019", "09/2019", "", "Administratief medewerker", 6, new List<string>() },
                    { 7, "De Dozenschuivers BV", "10-2018", "10-2019", "", "Cassière en winkelmedewerker", 7, new List<string>() },
                    { 8, "BEE-Ideas", "03-2023", "Heden", "In de rol van Product Owner vertaal ik de wensenvanuit de business naar werkbare items voor hetteam van ontwikkelaars. Oplossingen vanuit het teambespreek ik met de stakeholders en op deze manierverbind ik de stakeholders met het team vanontwikkelaars en wordt het beste product gemaaktvoor de stakeholder. Als Product Owner begeleid iktwee teams, met het eerste team wordt een nieuwCRM systeem gebouwd en met het tweede teamwordt er een NFT platform gebouwd. Als ScrumMaster heb ik voor een gestructureerde en openwerkomgeving gezorgd voor de ontwikkelaars. Ditheb ik gerealiseerd door regelmatig meetings tefaciliteren waarbij iedereen open, vrij en zonderrestricties kan communiceren. Om hier deel van tezijn en samen fijne, gebruikersvriendelijke productente maken geeft me elke dag veel voldoening.", "Product Owner/Scrum Master", 8, new List<string> { "De wensen van de stakeholdervertalen naar werkbare items inde backlog.", "Oplossingen vanuit het teambespreken met de stakeholder", "Testen, debuggen en zoekennaar oplossingen voorproblemen binnen het project.", "Deelname aan het ontwerp ende structurering van hetproject.", "Deelname aan planningstakenen werkitems binnen hetscrum-framework.", "Presenteren en geven vandemo's van functies in deapplicatie aan zowel de interneteams als externe klanten.", "Zoeken naar nieuweoplossingen en best practices-", "scenario's om de kwaliteit vanhet product te verbeteren.", "Structuur geven aan het team" } },
                    { 9, "Zelfstandig", "12-2021", "02-2023", "", "Webdevelopment", 8, new List<string>() },
                    { 10, "OCI", "09-2021", "11-2021", "", "Controlroom Operator/Projectleider", 8, new List<string>() },
                    { 11, "Sabic", "08-2001", "08-2018", "", "Controlroom Operator/Projectleider", 8, new List<string>() },
                    { 12, "BEE-Ideas", "01-2020", "Heden", "Als Product Owner ben ik verantwoordelijk om de lijm te zijn tussen de cliënt en het dev team. Het duidelijk in kaart brengen wat het team aan kan qua skills en workload (vooral hier belangrijk omdat de ervaring van teamleden uiteenlopen van medior IT-er tot iemand die net zijn eerste regel code heeft geschreven) en wat de verwachtingen/wensen van de cliënt zijn staan hier in centraal. Daarbij ben ik ook degene die de planning maakt en er voor zorgt dat iedereen weet wat de verwachtingen zijn. Dat houd soms dus ook in om onrealistische wensen aan te kaarten bij de cliënt.", "Front end developer", 9, new List<string> { "Vertalen van de wensen van een klant aar een tastbaar product.", "Ondersteuning van andere teamleden in en adviserende rol.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Presenteren en geven van demo's van functies in de applicatie aan zowel de interne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en best practices-scenario's om de kwaliteit van het product te verbeteren." } },
                    { 13, "EduCom", "04-2018", "12-2018", "Het zijn van Scrum Master betekend dat ik het aanspreekpunt ben van het hele team en zorg dat iedereen zijn werk kan doen en ook met de juiste oplossingen kom wanneer we kuilen in de weg tegenkomen. Van coaching van teamleden tot het escaleren van issues naar hogerop mochten we er zelf niet uitkomen.", "Traineeship", 9, new List<string> { "Coachende en begeleidende rol in het team", "Aanpakken van issues op zowel teamverband als persoonlijke hindernissen", "Motiveren en inspireren" } },
                    { 14, "VGI", "07-2016", "09-2016", "Als sessiemuzikant ben ik kundig om in verschillende genres nieuw materiaal te componeren dan wel arrangementen op bestaande\r\nmuziek uit te denken en te perfectioneren. Als producer ben ik verantwoordelijkheid voor een opnamesessie. Tot de minimale taken\r\nvan het indelen van de opnametijd in de studio en het nemen van eindbeslissingen. Als Sound Engineer nam ik alle techische aspecten ook op zoals het mix- en masterwerk, plaatsen van apparatuur etc.", "CAD Operator", 9, new List<string> { "Ghostwriting van nummers", "Arrangeren", "Componeren", "Partijen inspelen in de studio", "Studioplanning", "Mix- en masteringwerk", "Publiceren van muziek", "Meedenken aan het eindproduct van de artiest", "Studioplanning maken en handhaven" } },
                    { 15, "Stichting de Gemeenschap", "03-2014", "08-2015", "In deze rol ben ik verantwoordelijk geweest om alle klantvragen in kaart te brengen en mensen te helpen bij hun vraag. Ook het\r\nmeedenken voor oplossingen van mensen met een betalingsachterstand hoorde hier bij.", "Anaylist", 9, new List<string> { "Mensen te woord staan om ze wegwijs te maken in de wereld van de energie", "Technische ondersteuning bieden", "Administratief alles op orde maken", "Hulp en oplossingen bieden bij betalingsachterstanden" } },
                    { 16, "GPPS", "08-2023", "Heden", "Binnen het project ben ik zowel developer als scrum master binnenhet team. Als developer ben ik voornamelijk betrokken bij het stukfrontend. Hierin werk ik met HTML, CSS, TS (JS) binnen het Angularframework.", "Frontend developer", 10, new List<string> { "Programmeren in de frontend van de applicatie.", "Uitvoeren van scrum gerelateerde taken." } },
                    { 17, "BEE-Ideas", "01-2023", "06-2023", "Binnen The Challenge Zone ben ik begonnen als stagiair developer. Inmijn tijd daar heb ik een goed contact opgebouwd met de managerMarc Huntjens en heb ik mij ook bewezen om twee projecten teoverzien als project manager. Deze werden gehanteerd met de scrummethode. Een van deze projecten was een webshop voor eenfi etswinkel. Het andere project was een datahygiëne project insamenwerking met 4 bouw gerelateerde bedrijven en Open University Maastricht.", "Frontend developer", 10, new List<string> { "Programmeren in de frontend van de applicatie.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Contactpersoon tussen verschillendestakeholders.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Presenteren en geven van demo's vanfuncties in de applicatie aan zowel deinterne teams als externe klanten.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." } },
                    { 18, "Applicatieontwikkelaar", "10-2021", "05-2022", "", "The Challenge Zone", 10, new List<string>() },
                    { 19, "BEE-Ideas", "03-2023", "Heden", "Developer in Srum-Team", "Fullstack developer", 11, new List<string> { "Deelname aan het ontwerp en destructurering van het project.", "Programmeren in de backend en front-end van de applicatie.", "Testen, debuggen en zoeken naaroplossingen voor problemen binnen hetproject.", "Ondersteuning van andere teamleden ineen adviserende rol.", "Deelname aan planningstaken enwerkitems binnen het scrum-framework.", "Zoeken naar nieuwe oplossingen en bestpractices-scenario's om de kwaliteit vanhet product te verbeteren." } },
                    { 20, "Track Software", "11-2010", "1-2022", "Analyseren, Ontwerpen, Ontwikkelen, Testen, Documenteren, Plannen.", "Fullstack developer", 11, new List<string> { "Maken en ontwikkeling vanbedrijfskritische verzuimsoftwarevoornamelijk voor arbodiensten maar ookvoor bedrijfsartsen en werkgevers.", "Betrokkenheid bij ISO certificatie.", "Waar ik trots op ben, CBBS.", "Een systeem waar:", "A. Beroepen met functies en takenworden gekoppeld aan de fysieke enpsychische belasting.", "B. De taken bij het beroep per belastingeen kleur van de stoplicht krijgen, rood isnoodzakelijk en groen is niet vantoepassing.", "C. Ziektes.gekoppeld worden aan defysieke en psychische belasting. (Taken)", "D. Met een druk op een knop bepaaldwordt of bijvoorbeeld iemand met eengebroken voet nog zijn beroep, taken kanuitvoeren", "Het mooie van het systeem is dat erfuncties groen kunnen zijn. Dat betekenddat de werknemers vaak deels nog aanhet werk kunnen." } },
                    { 21, "Technosoft", "1-2005", "10-2010", "", "Fullstack developer", 11, new List<string>() },
                    { 22, "Philadelphia zorg", "10-2003", "12-2004", "", "Software developer", 11, new List<string>() },
                    { 23, "BEE-Ideas", "03-2023", "Heden", "Werken in een Scrum team aan een project voor AZL.", "Fullstack Developer", 12, new List<string> { "Backend development" } },
                    { 24, "JSR IT", "2-2020", "10-2022", "Ontwikkelen van PHP web applicaties - Maken en optimaliseren van SQL queries - Linux systeembeheer - Beheren van VM's via VMware vCenter en het maken van backups hiervan.", "IT Medewerker", 12, new List<string> { "Web applicatie voor nummerportering via de REST API van vereniging COIN", "ERP Web applicatie voor een verloskundigepraktijk", "Service voor het synchroniseren van facturen met een online boekhoudprogramma" } },
                    { 25, "Flowid", "09-2010", "01-2011", "Stage", "Stagiair", 12, new List<string> { "Maken van een LabVIEW applicatie voor het aansturen van een pomp", "Optimalisatie van een hydrogenerigsreactie in een microreactor" } },
                    { 26, "BEE-Ideas Organisation", "13/7/2023", "Heden", "Als software engineer voor Bee Portal, richt ik me op het bouwen en onderhouden van de achterliggende systemen en API's. Ik werk nauw samen met een multidisciplinair team van ontwikkelaars om een vloeiende integratie tussen de frontend en backend te waarborgen. Mijn taken omvatten systeemintegratie, gegevensbeheer en het ondersteunen van de realisatie van Bee Portal's visie als een centrale informatiehub voor kandidaten, medewerkers en begeleiders. Dit is fulltime en remote.", "Software Engineer", 13, new List<string> { "Ontwikkelde en onderhield de backendcomponenten van Bee Portal.", "Testen, debuggen en zoeken naar oplossingen voor problemen binnen het project.", "Deelname aan het ontwerp en de structurering van het project.", "Deelname aan planningstaken en werkitems binnen het scrum-framework.", "Ondersteuning van andere teamleden in een adviserende rol." } },
                    { 27, "Zelfstandig", "12/3/2020", "12/7/2023", "Eigen projecten uitvoeren om zo ervaring op te doen als software engineer. Deze projecten waren bijvoorbeeld een microcontroller\r\nprogrammeren zodat deze een sensor kan a􀀁ezen en via internet data op kon vragen en daarna deze data ook via websocket en http\r\nrequests beschikbaar worden gemaakt om op te vragen via een programma dat draait op een server. Dit programma slaat dit op in een database waarna deze data bekeken kan worden via een gemaakte website. Nog een project was een C++ programma om automatisch een nieuw C++ project te kunnen starten, dit hield in de  juiste folder structuur te maken en de juiste benodigde start bestanden te maken. Een derde project was Covid data van het RIVM ophalen, deze importeren in een database elke dag en deze lokaal te laten benaderen via een website. Hierdoor was te zien wat de situatie was in mijn eigen dorp en de trend.", "Software Engineer", 13, new List<string>() },
                    { 28, "Kuehne+Nagel", "5/7/2010", "27/8/2010", "", "Administratief Medewerker", 13, new List<string>() },
                    { 29, "Bee Ideas", "1/3/2023", "30/9/2023", "Tijdens een leer-werk traject wordt er projectmatig gewerkt aan eenportal. Ik heb gedurende een half jaar de rol van Scrum Master op megenomen. Tevens heb ik me hierbij steeds meer verdiept in defacetten van Scrum Master. Ik heb mijn PSM1 certifi caat gehaald enben momenteel bezig om het PSM2 certificaat te halen.", "Scrum Master", 14, new List<string> { "Groep geholpen met basic vaardighedenvan programmeren.", "PO geholpen met het initieel vullen van deproduct backlog in Azure Devops.", "Groep gemotiveerd, gestimuleerd engeënthousiasmeerd met workshops enverhalen", "Zorgen dat alle vergaderingen goedingevuld en uitgevoerd worden." } },
                    { 30, "Ida Gerhardt Academie", "1-5-2022", "30/11/2022", "Docent wiskunde onderbouw Havo / VWO", "Docent Wiskunde", 14, new List<string>() },
                    { 31, "Holland House", "1-5-2013", "31-3-2022", "Analist, developer, Software Tester, Support engineer", "Senior Software Engineer", 14, new List<string>() },
                    { 32, "Raayland College", "1-8-2012", "30-4-2013", "Doceren wiskunde VMBO / HAVO / VWO klas 1, 2 en 3", "Docent Wiskunde", 14, new List<string>() },
                    { 33, "Udens College", "1-8-2010", "31-7-2012", "", "Docent Wiskunde", 14, new List<string>() },
                    { 34, "Rodenborch College", "26-1-2009", "31-7-2010", "", "Docent Wiskunde", 14, new List<string>() },
                    { 35, "Mapscape", "1-12-2007", "25-01-2009", "", "Technical Writer", 14, new List<string>() },
                    { 36, "Planon", "1-6-2003", "30-11-2007", "", "ICT Consultant", 14, new List<string>() },
                    { 37, "Computron", "16-1-2001", "31-5-2003", "", "Senior Software Engineer", 14, new List<string>() },
                    { 38, "PTS Software", "1-5-1998", "15-1-2001", "", "Senior Software Engineer", 14, new List<string>() }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "TalentPropertyMainCategoryLink",
                columns: new[] { "Id", "TalentId", "TalentPropertyLabelId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 7 },
                    { 8, 1, 8 },
                    { 9, 2, 1 },
                    { 10, 2, 2 },
                    { 11, 2, 3 },
                    { 12, 2, 4 },
                    { 13, 2, 5 },
                    { 14, 2, 6 },
                    { 15, 2, 7 },
                    { 16, 2, 8 },
                    { 17, 3, 1 },
                    { 18, 3, 2 },
                    { 19, 3, 3 },
                    { 20, 3, 4 },
                    { 21, 3, 5 },
                    { 22, 3, 6 },
                    { 23, 3, 7 },
                    { 24, 3, 8 },
                    { 25, 4, 1 },
                    { 26, 4, 2 },
                    { 27, 4, 3 },
                    { 28, 4, 4 },
                    { 29, 4, 5 },
                    { 30, 4, 6 },
                    { 31, 4, 7 },
                    { 32, 4, 8 },
                    { 33, 5, 1 },
                    { 34, 5, 2 },
                    { 35, 5, 3 },
                    { 36, 5, 4 },
                    { 37, 5, 5 },
                    { 38, 5, 6 },
                    { 39, 5, 7 },
                    { 40, 5, 8 },
                    { 41, 6, 1 },
                    { 42, 6, 2 },
                    { 43, 6, 3 },
                    { 44, 6, 4 },
                    { 45, 6, 5 },
                    { 46, 6, 6 },
                    { 47, 6, 7 },
                    { 48, 6, 8 },
                    { 49, 7, 1 },
                    { 50, 7, 2 },
                    { 51, 7, 3 },
                    { 52, 7, 4 },
                    { 53, 7, 5 },
                    { 54, 7, 6 },
                    { 55, 7, 7 },
                    { 56, 7, 8 },
                    { 57, 8, 1 },
                    { 58, 8, 2 },
                    { 59, 8, 3 },
                    { 60, 8, 4 },
                    { 61, 8, 5 },
                    { 62, 8, 6 },
                    { 63, 8, 7 },
                    { 64, 8, 8 },
                    { 65, 9, 1 },
                    { 66, 9, 2 },
                    { 67, 9, 3 },
                    { 68, 9, 4 },
                    { 69, 9, 5 },
                    { 70, 9, 6 },
                    { 71, 9, 7 },
                    { 72, 9, 8 },
                    { 73, 10, 1 },
                    { 74, 10, 2 },
                    { 75, 10, 3 },
                    { 76, 10, 4 },
                    { 77, 10, 5 },
                    { 78, 10, 6 },
                    { 79, 10, 7 },
                    { 80, 10, 8 },
                    { 81, 11, 1 },
                    { 82, 11, 2 },
                    { 83, 11, 3 },
                    { 84, 11, 4 },
                    { 85, 11, 5 },
                    { 86, 11, 6 },
                    { 87, 11, 7 },
                    { 88, 11, 8 },
                    { 89, 12, 1 },
                    { 90, 12, 2 },
                    { 91, 12, 3 },
                    { 92, 12, 4 },
                    { 93, 12, 5 },
                    { 94, 12, 6 },
                    { 95, 12, 7 },
                    { 96, 12, 8 },
                    { 97, 13, 1 },
                    { 98, 13, 2 },
                    { 99, 13, 3 },
                    { 100, 13, 4 },
                    { 101, 13, 5 },
                    { 102, 13, 6 },
                    { 103, 13, 7 },
                    { 104, 13, 8 },
                    { 105, 14, 1 },
                    { 106, 14, 2 },
                    { 107, 14, 3 },
                    { 108, 14, 4 },
                    { 109, 14, 5 },
                    { 110, 14, 6 },
                    { 111, 14, 7 },
                    { 112, 14, 8 }
                });

            migrationBuilder.InsertData(
                schema: "TalentenPortaal",
                table: "VacancyComplete",
                columns: new[] { "Id", "CompanyId", "Created", "IsEnabled", "Region", "Title", "VacancyDemandDetailId", "VacancyDemandId", "VacancyOfferId", "VacancyTextId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Landelijk", "Tester", 1, 1, 1, 1 },
                    { 2, 2, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Limburg", "Senior C# programmeur", 2, 2, 2, 2 },
                    { 3, 3, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Noord-Brabant", "Stage Frontend programmeur Angular", 3, 3, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_TalentId",
                schema: "TalentenPortaal",
                table: "EducationDetail",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_PastExperience_TalentId",
                schema: "TalentenPortaal",
                table: "PastExperience",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_OrganisationId",
                schema: "TalentenPortaal",
                table: "Talent",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentPropertyLabel_Name",
                schema: "TalentenPortaal",
                table: "TalentPropertyLabel",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TalentPropertyMainCategoryLink_TalentId",
                schema: "TalentenPortaal",
                table: "TalentPropertyMainCategoryLink",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentPropertySubCategoryLink_TalentPropertyMainCategoryLin~",
                schema: "TalentenPortaal",
                table: "TalentPropertySubCategoryLink",
                column: "TalentPropertyMainCategoryLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplete_CompanyId",
                schema: "TalentenPortaal",
                table: "VacancyComplete",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplete_VacancyDemandDetailId",
                schema: "TalentenPortaal",
                table: "VacancyComplete",
                column: "VacancyDemandDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplete_VacancyDemandId",
                schema: "TalentenPortaal",
                table: "VacancyComplete",
                column: "VacancyDemandId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplete_VacancyOfferId",
                schema: "TalentenPortaal",
                table: "VacancyComplete",
                column: "VacancyOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplete_VacancyTextId",
                schema: "TalentenPortaal",
                table: "VacancyComplete",
                column: "VacancyTextId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetail",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "Hobby",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "PastExperience",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "TalentPropertyLabel",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "TalentPropertySubCategoryLink",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "VacancyComplete",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "TalentPropertyMainCategoryLink",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "VacancyDemandDetail",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "VacancyDemand",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "VacancyOffer",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "VacancyText",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "Talent",
                schema: "TalentenPortaal");

            migrationBuilder.DropTable(
                name: "Organization",
                schema: "TalentenPortaal");
        }
    }
}
