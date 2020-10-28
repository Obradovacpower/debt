using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gæld.Migrations
{
    public partial class newInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 28, 15, 43, 5, 121, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 10, 28, 15, 43, 5, 123, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 10, 28, 15, 43, 5, 123, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 10, 28, 15, 43, 5, 123, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 9, 28, 15, 43, 5, 123, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 10, 13, 15, 43, 5, 123, DateTimeKind.Local).AddTicks(6325));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 25, 15, 31, 26, 700, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 10, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 10, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 10, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 9, 25, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Debts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 10, 10, 15, 31, 26, 702, DateTimeKind.Local).AddTicks(9049));
        }
    }
}
