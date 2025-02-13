using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "This is the content of the first entry.", new DateTime(1905, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Entry" },
                    { 2, "This is the content of the second entry.", new DateTime(1905, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Entry" },
                    { 3, "This is the content of the third entry.", new DateTime(1905, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Entry" }
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
