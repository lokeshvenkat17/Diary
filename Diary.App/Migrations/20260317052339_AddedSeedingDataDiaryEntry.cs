using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Diary.App.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
