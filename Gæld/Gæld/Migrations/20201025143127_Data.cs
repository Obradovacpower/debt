using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gæld.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Carsten" },
                    { 2, "Sebastian" },
                    { 3, "Ermin Jensen" },
                    { 4, "Rayquaza" }
                });

            migrationBuilder.InsertData(
                table: "Debts",
                columns: new[] { "Id", "Amount", "Date", "PersonId" },
                values: new object[,]
                {
                    { 1, -30, new DateTime(2020, 10, 25, 15, 31, 26, 700, DateTimeKind.Local).AddTicks(8737), 1 },
                    { 2, -15, new DateTime(2020, 10, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049), 1 },
                    { 3, 19, new DateTime(2020, 10, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049), 1 },
                    { 4, 5000, new DateTime(2020, 10, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049), 2 },
                    { 5, -5000, new DateTime(2020, 9, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049), 3 },
                    { 6, 1234, new DateTime(2020, 10, 10, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
