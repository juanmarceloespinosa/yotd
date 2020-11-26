using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YOTD.WebApi.Migrations
{
    public partial class QuoteUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 2, "Qui-Gon Jinn", 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your focus determines your reality." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 3, "Yoda", 1, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do. Or do not. There is no try." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 4, "Leia Organa", 3, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somebody has to save our skins." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 5, "Obi-Wan Kenobi", 1, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In my experience there is no such thing as luck." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 6, "Darth Vader", 2, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I find your lack of faith disturbing." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 7, "basically everyone", 3, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I’ve got a bad feeling about this" });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 8, "Admiral Ackbar", 3, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It’s a trap!" });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 9, "Padmé Amidala", 3, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "So this is how liberty dies... with thunderous applause." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 10, "Obi-Wan Kenobi", 1, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Your eyes can deceive you. Don’t trust them." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 11, "Han Solo", 3, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Never tell me the odds." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 12, "Watto", 3, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mind tricks don’t work on me." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 13, "Han Solo", 3, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great, kid. Don’t get cocky." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 14, "Gold Five", 1, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stay on target." });

            migrationBuilder.InsertData(
                table: "Quote",
                columns: new[] { "Id", "Author", "CategoryId", "Date", "Text" },
                values: new object[] { 15, "Ahsoka Tano", 1, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a new day, a new beginning." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Quote",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);
        }
    }
}
