using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RateResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RateId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stopped = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RateQNs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EQNType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RateId = table.Column<int>(type: "int", nullable: false),
                    TranslationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateQNs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RateQNs_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "Rates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RateResultDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateQNId = table.Column<int>(type: "int", nullable: false),
                    RateResultId = table.Column<int>(type: "int", nullable: false),
                    ValueInt = table.Column<int>(type: "int", nullable: false),
                    ValueString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateResultDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RateResultDetails_RateQNs_RateQNId",
                        column: x => x.RateQNId,
                        principalTable: "RateQNs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RateResultDetails_RateResults_RateResultId",
                        column: x => x.RateResultId,
                        principalTable: "RateResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RateResults",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "CustomerId", "Notes", "RateId", "TaskId" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2022, 11, 6, 19, 50, 31, 805, DateTimeKind.Local).AddTicks(6781), 1, "Test1", 1, 1 },
                    { 2, "2", new DateTime(2022, 11, 6, 19, 50, 31, 805, DateTimeKind.Local).AddTicks(6794), 2, "Test2", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "Id", "Name", "Stopped" },
                values: new object[,]
                {
                    { 1, "Rate1", true },
                    { 2, "Rate2", false }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "TR" },
                    { 2, "EN" }
                });

            migrationBuilder.InsertData(
                table: "RateQNs",
                columns: new[] { "Id", "EQNType", "RateId", "TranslationId" },
                values: new object[,]
                {
                    { 1, "Star", 1, 1 },
                    { 2, "Star", 1, 1 },
                    { 3, "Star", 1, 1 },
                    { 4, "Star", 2, 2 },
                    { 5, "Star", 2, 2 },
                    { 6, "Star", 2, 2 },
                    { 7, "Star", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "RateResultDetails",
                columns: new[] { "Id", "RateQNId", "RateResultId", "ValueInt", "ValueString" },
                values: new object[] { 1, 1, 1, 1, "test1" });

            migrationBuilder.InsertData(
                table: "RateResultDetails",
                columns: new[] { "Id", "RateQNId", "RateResultId", "ValueInt", "ValueString" },
                values: new object[] { 2, 2, 2, 1, "test" });

            migrationBuilder.CreateIndex(
                name: "IX_RateQNs_RateId",
                table: "RateQNs",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_RateResultDetails_RateQNId",
                table: "RateResultDetails",
                column: "RateQNId");

            migrationBuilder.CreateIndex(
                name: "IX_RateResultDetails_RateResultId",
                table: "RateResultDetails",
                column: "RateResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RateResultDetails");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "RateQNs");

            migrationBuilder.DropTable(
                name: "RateResults");

            migrationBuilder.DropTable(
                name: "Rates");
        }
    }
}
