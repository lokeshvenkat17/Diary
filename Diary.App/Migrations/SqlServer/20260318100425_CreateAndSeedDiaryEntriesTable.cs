using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Diary.App.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class CreateAndSeedDiaryEntriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Aishu", new DateTime(2026, 3, 17, 10, 53, 38, 700, DateTimeKind.Local).AddTicks(9220), "Went Hiking" },
                    { 2, "Went shopping with Aishu", new DateTime(2026, 3, 17, 10, 53, 38, 700, DateTimeKind.Local).AddTicks(9542), "Went Shopping" },
                    { 3, "Went diving with Aishu", new DateTime(2026, 3, 17, 10, 53, 38, 700, DateTimeKind.Local).AddTicks(9544), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryEntries");
        }
    }
}
