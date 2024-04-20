using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBandSeederImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 67,
                column: "ProductId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 76,
                column: "ProductId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 94,
                column: "ProductId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 117,
                column: "ProductId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 137,
                column: "ProductId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 138,
                column: "ProductId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 146,
                column: "ProductId",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 220,
                column: "ProductId",
                value: 74);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 15, 57, 58, 795, DateTimeKind.Local).AddTicks(6215));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 67,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 76,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 94,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 117,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 137,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 138,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 146,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 220,
                column: "ProductId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 15, 31, 0, 60, DateTimeKind.Local).AddTicks(8325));
        }
    }
}
