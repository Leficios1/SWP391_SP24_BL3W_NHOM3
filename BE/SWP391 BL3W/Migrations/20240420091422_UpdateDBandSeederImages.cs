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
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 16, 14, 22, 176, DateTimeKind.Local).AddTicks(4641));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 15, 57, 58, 795, DateTimeKind.Local).AddTicks(6215));
        }
    }
}
