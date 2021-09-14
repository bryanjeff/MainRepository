using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PO_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DivDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivId);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "TargetSettings",
                columns: table => new
                {
                    TSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TSettingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TSettingDesc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetSettings", x => x.TSettingId);
                });

            migrationBuilder.CreateTable(
                name: "TargetSettingSumaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionVal = table.Column<double>(type: "float", nullable: false),
                    TSettingId = table.Column<int>(type: "int", nullable: false),
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    DivId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetSettingSumaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetSettingSumaries_Divisions_DivId",
                        column: x => x.DivId,
                        principalTable: "Divisions",
                        principalColumn: "DivId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TargetSettingSumaries_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TargetSettingSumaries_TargetSettings_TSettingId",
                        column: x => x.TSettingId,
                        principalTable: "TargetSettings",
                        principalColumn: "TSettingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivId", "DivDescription", "DivName" },
                values: new object[,]
                {
                    { 1, "PEC Description", "PEC" },
                    { 12, "NPI Description", "NPI" },
                    { 11, "EEM Description", "EEM" },
                    { 9, "OGW Description", "OGW" },
                    { 8, "QP Description", "QP" },
                    { 7, "FI Description", "FI" },
                    { 10, "PF Description", "PF" },
                    { 5, "DEC Description", "DEC" },
                    { 4, "WPO Description", "WPO" },
                    { 3, "ZLC Description", "ZLC" },
                    { 2, "CSD Description", "CSD" },
                    { 6, "RE Description", "RE" }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "Description", "PlantName" },
                values: new object[,]
                {
                    { 1, "Plant for Region Columbia", "Plant Columbia" },
                    { 2, "Plant for Region Asia-Pacific", "Plant Asia-Pacific" }
                });

            migrationBuilder.InsertData(
                table: "TargetSettings",
                columns: new[] { "TSettingId", "TSettingDesc", "TSettingName" },
                values: new object[,]
                {
                    { 4, "Description 4", "Overall # Target Actions 2021" },
                    { 1, "Description 1", "Current Pillar Score" },
                    { 2, "Description 2", "Current Maturity Level" },
                    { 3, "Description 3", "# Actions to Next Level" },
                    { 5, "Description 5", "# Commited Actions" }
                });

            migrationBuilder.InsertData(
                table: "TargetSettingSumaries",
                columns: new[] { "Id", "ActionVal", "CompDate", "DivId", "PlantId", "TSettingId" },
                values: new object[,]
                {
                    { 1, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 2, 2.2000000000000002, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 3, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 1 },
                    { 4, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1 },
                    { 5, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 1 },
                    { 6, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 1 },
                    { 7, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1 },
                    { 8, 1.2, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1, 1 },
                    { 9, 1.0, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1 },
                    { 10, 2.0, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 },
                    { 11, 1.0, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 },
                    { 12, 1.0, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TargetSettingSumaries_DivId",
                table: "TargetSettingSumaries",
                column: "DivId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSettingSumaries_PlantId",
                table: "TargetSettingSumaries",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSettingSumaries_TSettingId",
                table: "TargetSettingSumaries",
                column: "TSettingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TargetSettingSumaries");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "TargetSettings");
        }
    }
}
