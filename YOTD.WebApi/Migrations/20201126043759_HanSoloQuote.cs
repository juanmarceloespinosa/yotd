using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YOTD.WebApi.Migrations
{
    public partial class HanSoloQuote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 1, "Han Solo", 1, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It’s not my fault." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
