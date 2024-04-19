using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBandSeederImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[] { 1, 1, "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 19, 19, 22, 39, 11, DateTimeKind.Local).AddTicks(9751));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 19, 14, 7, 55, 495, DateTimeKind.Local).AddTicks(3833));
        }
    }
}
