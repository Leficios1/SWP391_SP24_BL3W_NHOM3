using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBandSeederBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 18, 34, 7, 609, DateTimeKind.Local).AddTicks(3669));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 18, 33, 42, 717, DateTimeKind.Local).AddTicks(9789));
        }
    }
}
