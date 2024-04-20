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
                keyValue: 1,
                column: "Url",
                value: "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/vi-vn-1.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 1, "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 1, "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 2, "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 2, "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 2, "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 3, "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-thiet-ke-(1).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 3, "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-dung-tich-(1).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 3, "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/congsuat-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 4, "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 4, "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 4, "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 5, "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654167272451.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 5, "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654168202480.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 5, "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654169122563.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 6, "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 6, "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 6, "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 7, "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(2).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 7, "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(3).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 7, "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(4).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 8, "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923030465278.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 8, "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923031375346.jpg " });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 8, "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923032445291.jpgv" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 9, "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 9, "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 10, "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-thiet-ke.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 10, "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/cong-suat-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 10, "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-dung-tich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 11, "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-thietke.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 11, "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/-congsuat-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 11, "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 12, "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-thietke.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 12, "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-congsuat.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 12, "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 13, "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 13, "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/Untitled-2-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 13, "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 14, "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466480780750.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 14, "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466481600801.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 14, "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466485200682.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 15, "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/Untitled-2-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 15, "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 15, "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 16, "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-thietke.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 16, "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/a4-780x433.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 16, "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 17, "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(6).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 17, "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(4).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 17, "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/a2-780x433.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 18, "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 18, "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 18, "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/thumb-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 19, "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 19, "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 19, "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 20, "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-thietke.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 20, "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-congsuat.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 20, "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 21, "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/2KG855i-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 21, "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516149397546.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 21, "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516150627512.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 22, "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709265189907349.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 22, "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274051416304.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 22, "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274053406269.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148159663228.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 23, "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148161073382.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 23, "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638277628983499420.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 24, "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208638306537136599246.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 24, "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/vi-vn-doi-pramie-2208-230721-0436562.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 24, "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208-230721-0436578.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 25, "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 25, "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 25, "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-1-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 26, "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-2-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 26, "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-3-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 27, "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-2-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 27, "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-3-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 27, "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-4-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 28, "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157188439325.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 28, "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157187419347.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 28, "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157186249325.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 29, "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-4-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 29, "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-3-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 29, "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 30, "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-thietkefinal.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 30, "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/galanz-ch211e637701457133462016.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 30, "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-matbepfinal.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 31, "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 31, "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/-hong-ngoai-sanaky-at-2524hgn-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 31, "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117081.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 32, "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117092.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 32, "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117113.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 33, "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/tongcongsuat-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 33, "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127511.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 33, "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127500.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 34, "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-2-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 34, "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-3-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 34, "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-4-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 35, "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788887736001.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 35, "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788587167004.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 35, "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788583007035.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 36, "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-02.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 36, "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 36, "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 37, "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-02.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 37, "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-03.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 37, "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-05.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 38, "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761528510276.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 38, "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761529460408.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 38, "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761530420342.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 39, "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 39, "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 40, "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/smart-samsung-4k-43-inch-ua43au7002638022060998318047.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 40, "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 40, "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 41, "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 41, "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 41, "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 42, "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-2.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 42, "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-4.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 42, "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-8.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 43, "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-2.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 43, "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-3.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 43, "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 44, "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489862454084.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 44, "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489863354037.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 44, "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489864254065.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 45, "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-006.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 45, "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 45, "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-10.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 46, "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972278342842.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972277412853.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972276662851.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 47, "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490700146555.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 47, "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490701116452.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 47, "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490702106380.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 48, "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-2.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 48, "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-3.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 48, "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 49, "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996422198459.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 0, "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996422198459.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 49, "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996424168464.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 50, "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-2.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 50, "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-4.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 50, "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-8.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 51, "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/02-1020x571.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 51, "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/03-1020x571.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 51, "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/06-1020x571.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 52, "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/1-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 52, "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/2-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 52, "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/4-1020x570-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 53, "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-050821-0710241.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 53, "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-100821-0218070.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 53, "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-210821-1005141.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 54, "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798790132815.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 54, "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798792382855.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 54, "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798793442838.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 55, "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/2-1020x570.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 55, "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/toshiba-gr-b22vu-ukg-050821-1121262.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 55, "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/198-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 56, "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/2-1020x570.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 56, "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 56, "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 57, "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 57, "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 57, "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 58, "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 58, "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 58, "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 59, "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/samsung-rt20har8dbu-sv-080821-0639042.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 59, "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-2-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 59, "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-4-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 60, "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-080821-0341071.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 60, "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-210821-0601370.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 60, "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/225858-1020x570.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 61, "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667257173349.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 61, "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258003283.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 61, "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258813389.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 62, "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007604134225944.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 62, "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603868094190.jpg" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 186, 62, "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603817113795.jpg" },
                    { 187, 63, "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760509272052.jpg" },
                    { 188, 63, "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760510222056.jpg" },
                    { 189, 63, "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760511042060.jpg" },
                    { 190, 64, "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343064927731.jpg" },
                    { 191, 64, "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343066856041.jpg" },
                    { 192, 64, "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343067926248.jpg" },
                    { 193, 65, "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404755929362-1020x571.jpg" },
                    { 194, 65, "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404757959374.jpg" },
                    { 195, 65, "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404760909361.jpg" },
                    { 196, 66, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121296906251.jpg" },
                    { 197, 66, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121297826281.jpg" },
                    { 198, 66, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpg" },
                    { 199, 67, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpg" },
                    { 200, 67, "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618087619203.jpg" },
                    { 201, 67, "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpg" },
                    { 202, 68, "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpg" },
                    { 203, 68, "https://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-giat-nuoc-nong-panasonic-na-fd95v1brv-3.jpg" },
                    { 204, 68, "https://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-bot-min-panasonic-na-fd95v1brv-4.jpg" },
                    { 205, 69, "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-03.jpg" },
                    { 206, 69, "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-04.jpg" },
                    { 207, 69, "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-05.jpg" },
                    { 208, 70, "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/vi-vn-toshiba-7-kg-aw-l805av-sg03.jpg" },
                    { 209, 70, "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-4-1020x570.jpg" },
                    { 210, 70, "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-3-1020x570.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 211, 71, "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/chuong-trinh-giat-may-giat-samsung-12kg-wa12cg5745bvsv-1018x575.jpg" },
                    { 212, 71, "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204011022314.jpg" },
                    { 213, 71, "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204012042319.jpg" },
                    { 214, 72, "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/3-1020x570.jpg" },
                    { 215, 72, "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-giat-nuoc-nong--panasonic-na-fd10vr1bv-3.jpg" },
                    { 216, 72, "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-bot-min-panasonic-na-fd10vr1bv-4.jpg" },
                    { 217, 73, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpg" },
                    { 218, 73, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpg" },
                    { 219, 73, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg" },
                    { 220, 0, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpg" },
                    { 221, 74, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpg" },
                    { 222, 74, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg" },
                    { 223, 75, "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb2.jpg" },
                    { 224, 75, "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb3.jpg" },
                    { 225, 75, "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb4.jpg" },
                    { 226, 76, "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528027737733.jpg" },
                    { 227, 76, "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528028857718.jpg" },
                    { 228, 76, "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/06-1020x570.jpg" },
                    { 229, 77, "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/5-1020x570.jpg" },
                    { 230, 77, "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/7-1020x570.jpg" },
                    { 231, 77, "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/8-1020x570.jpg" },
                    { 232, 78, "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/3-1020x570-1.jpg" },
                    { 233, 78, "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpg" },
                    { 234, 78, "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpg" },
                    { 235, 79, "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734854518930.jpg" },
                    { 236, 79, "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734855308947.jpg" },
                    { 237, 79, "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734856288998.jpg" },
                    { 238, 80, "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpg" },
                    { 239, 80, "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/5-1018x575.jpg" },
                    { 240, 80, "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/may-giat-aqua-inverter-9-5-kg-aqd-a952j-bk638271882394422354.jpg" },
                    { 241, 81, "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016161.jpg" },
                    { 242, 81, "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016192.jpg" },
                    { 243, 81, "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/a6-780x433.png" },
                    { 244, 82, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080436398647.gif" },
                    { 245, 82, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080743600911.jpg" },
                    { 246, 82, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpg" },
                    { 247, 83, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpg" },
                    { 248, 83, "https://cdn.tgdd.vn/Products/Images/1922/72067/Slider/vi-vn-cong-nghe-nau3d.jpg" },
                    { 249, 83, "https://cdn.tgdd.vn/Products/Images/1922/72067/Slider/NO2-780x433-A-780x433.jpg" },
                    { 250, 84, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921571.jpg" },
                    { 251, 84, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921572.jpg" },
                    { 252, 84, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 253, 85, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpg" },
                    { 254, 85, "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-3.jpg" },
                    { 255, 85, "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpg" },
                    { 256, 86, "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpg" },
                    { 257, 86, "https://cdn.tgdd.vn/Products/Images/1922/203417/Slider/-dung-tich.jpg" },
                    { 258, 86, "https://cdn.tgdd.vn/Products/Images/1922/203417/Slider/vi-vn-cong-nghe-nau1d.jpg" },
                    { 259, 87, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-delites-ncr1502.jpg" },
                    { 260, 87, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/n%E1%BB%93i-c%C6%A1m-n%E1%BA%AFp-r%E1%BB%9Di-delites-ncr1502-111120-0416280.jpg" },
                    { 261, 87, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpg" },
                    { 262, 88, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpg" },
                    { 263, 88, "https://cdn.tgdd.vn/Products/Images/1922/275584/Slider/hinh-3-1020x570.jpg" },
                    { 264, 88, "https://cdn.tgdd.vn/Products/Images/1922/275584/Slider/vi-vn-sunhouse-12-lit-shd8217w-4.jpg" },
                    { 265, 89, "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-thiet-ke.jpg" },
                    { 266, 89, "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-dung-tich.jpg" },
                    { 267, 89, "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-chat-lieu-long-noi.jpg" },
                    { 268, 90, "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-noi-com-nap-gai-toshiba-rc-10jh2pv-b-1l-(1).png" },
                    { 269, 90, "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-cong-nghe-nau1d-in-thuong.jpg" },
                    { 270, 90, "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-bang-dieu-khien.jpg" },
                    { 271, 91, "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928471.jpg" },
                    { 272, 91, "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928482.jpg" },
                    { 273, 91, "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928483.jpg" },
                    { 274, 92, "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-2.jpg" },
                    { 275, 92, "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-10.jpg" },
                    { 276, 92, "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-cong-nghe-nau3d.jpg" },
                    { 277, 93, "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-thiet-ke.jpg" },
                    { 278, 93, "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-dung-tich-1.jpg" },
                    { 279, 93, "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/vi-vn-cong-nghe-nau1d.jpg" },
                    { 280, 94, "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720211.jpg" },
                    { 281, 94, "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpg" },
                    { 282, 94, "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpg" },
                    { 283, 95, "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-thietke2.jpg" },
                    { 284, 95, "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-dung-tich.jpg" },
                    { 285, 95, "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-cong-nghe-nau3d.jpg" },
                    { 286, 96, "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-18.jpg" },
                    { 287, 96, "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/1-780x433-780x433.jpg" },
                    { 288, 96, "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-13.jpg" },
                    { 289, 97, "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311729789327.jpg" },
                    { 290, 97, "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311732449371.jpg" },
                    { 291, 97, "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311734499431.jpg" },
                    { 292, 98, "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-2.jpg" },
                    { 293, 98, "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-3.jpg" },
                    { 294, 98, "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 295, 99, "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(2).jpg" },
                    { 296, 99, "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(3).jpg" },
                    { 297, 99, "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(4).jpg" },
                    { 298, 100, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-2.jpg" },
                    { 299, 100, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-3.jpg" },
                    { 300, 100, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpg" },
                    { 301, 101, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpg" },
                    { 302, 101, "https://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014372-780x433.jpg" },
                    { 303, 101, "https://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014340.jpg" },
                    { 304, 102, "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208261.jpg" },
                    { 305, 102, "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208272.jpg" },
                    { 306, 102, "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208283.jpg" },
                    { 307, 103, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-2.jpg" },
                    { 308, 103, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-3.jpg" },
                    { 309, 103, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpg" },
                    { 310, 104, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpg" },
                    { 311, 104, "https://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556233422401.jpg" },
                    { 312, 104, "https://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556232132456.jpg" },
                    { 313, 105, "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142290.jpg" },
                    { 314, 105, "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142311.jpg" },
                    { 315, 105, "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142322.jpg" },
                    { 316, 106, "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220311.jpg" },
                    { 317, 106, "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220322.jpg" },
                    { 318, 106, "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220333.jpg" },
                    { 319, 107, "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-2.jpg" },
                    { 320, 107, "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpg" },
                    { 321, 107, "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpg" },
                    { 322, 108, "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325321.jpg" },
                    { 323, 108, "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325332.jpg" },
                    { 324, 108, "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325344.jpg" },
                    { 325, 109, "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042071.jpg" },
                    { 326, 109, "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042082.jpg" },
                    { 327, 109, "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042093.jpg" },
                    { 328, 110, "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988717215598.jpg" },
                    { 329, 110, "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988715785825.jpg" },
                    { 330, 110, "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988720605323.jpg" },
                    { 331, 111, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(1).jpg" },
                    { 332, 111, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-vi-vn-vi-vn-vi-vn-sunhouse-shd7727-kg--(4).jpg" },
                    { 333, 111, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpg" },
                    { 334, 112, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpg" },
                    { 335, 112, "https://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpg" },
                    { 336, 112, "https://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 337, 113, "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556893691639.jpg" },
                    { 338, 113, "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556894541546.jpg" },
                    { 339, 113, "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556899521529.gif" },
                    { 340, 114, "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-2.jpg" },
                    { 341, 114, "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-3.jpg" },
                    { 342, 114, "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-4.jpg" },
                    { 343, 115, "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpg" },
                    { 344, 115, "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpg" },
                    { 345, 115, "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/-vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(1)-copy.jpg" },
                    { 346, 116, "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-2.jpg" },
                    { 347, 116, "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-3.jpg" },
                    { 348, 116, "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-4.jpg" },
                    { 349, 117, "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-12.jpg" },
                    { 350, 117, "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-2.jpg" },
                    { 351, 117, "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-7.jpg" },
                    { 352, 118, "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-2.jpg" },
                    { 353, 118, "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-3.jpg" },
                    { 354, 118, "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-4.jpg" },
                    { 355, 119, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-2.jpg" },
                    { 356, 119, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-3.jpg" },
                    { 357, 119, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpg" },
                    { 358, 120, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpg" },
                    { 359, 120, "https://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-3.jpg" },
                    { 360, 120, "https://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-4.jpg" },
                    { 361, 121, "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085709130066.jpg" },
                    { 362, 121, "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085710240063.jpg" },
                    { 363, 121, "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085711406269.jpg" },
                    { 364, 122, "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-1.jpg" },
                    { 365, 122, "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-8.jpg" },
                    { 366, 122, "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-9.jpg" },
                    { 367, 123, "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/vi-vn-quat-dieu-hoa-khong-khi-rapido-9000d-(1).jpg" },
                    { 368, 123, "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/Untitled-2-780x433.jpg" },
                    { 369, 123, "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/quat-dieu-hoa-khong-khi-rapido-9000d-190821-0759520.jpg" },
                    { 370, 124, "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-2.jpg" },
                    { 371, 124, "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-3.jpg" },
                    { 372, 124, "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-4.jpg" },
                    { 373, 125, "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/thietke-780x433.jpg" },
                    { 374, 125, "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/congsuat-780x433-1.jpg" },
                    { 375, 125, "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/dakho-780x433-1.jpg" },
                    { 376, 126, "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750178906564.jpg" },
                    { 377, 126, "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750177976576.jpg" },
                    { 378, 126, "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750176666568.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 379, 127, "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit-1a-min-1020x570.jpg" },
                    { 380, 127, "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342257456180.jpg" },
                    { 381, 127, "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342256156195-1020x570--2--1020x570.jpg" },
                    { 382, 128, "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662592506879.gif" },
                    { 383, 128, "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638318407391409045.jpg" },
                    { 384, 128, "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662590086953.jpg" },
                    { 385, 129, "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/ava-kdf-593d-75lit637956538234543296.jpg" },
                    { 386, 129, "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-3-(1).jpg" },
                    { 387, 129, "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-5-(2).jpg" },
                    { 388, 130, "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/ava-af358t-4-lit637956536037141108.jpg" },
                    { 389, 130, "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/3-1020x573.jpg" },
                    { 390, 130, "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/5-1020x570.jpg" },
                    { 391, 131, "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-2.gif" },
                    { 392, 131, "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-3.jpg" },
                    { 393, 131, "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-4--2--1020x570.jpg" },
                    { 394, 132, "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit-2-min-1020x570.jpg" },
                    { 395, 132, "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474989859767-1020x570.jpg" },
                    { 396, 132, "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474988859626-1020x570.jpg" },
                    { 397, 133, "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194027111283.jpg" },
                    { 398, 133, "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194028841288.gif" },
                    { 399, 133, "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194036871330.jpg" },
                    { 400, 134, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-2.jpg" },
                    { 401, 134, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-3.jpg" },
                    { 402, 134, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpg" },
                    { 403, 135, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpg" },
                    { 404, 135, "https://cdn.tgdd.vn/Products/Images/9418/217595/Slider/3-1020x570.jpg" },
                    { 405, 135, "https://cdn.tgdd.vn/Products/Images/9418/217595/Slider/noi-chien-khong-dau-kangaroo-kg55af1a-2-1020x570.jpg" },
                    { 406, 136, "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/hafele-af-t5a-2-1020x570-1.jpg" },
                    { 407, 136, "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/3-1020x570.jpg" },
                    { 408, 136, "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/5-1020x570.jpg" },
                    { 409, 137, "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035764079802.jpg" },
                    { 410, 137, "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit-6-1020x570.jpg" },
                    { 411, 137, "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035762639897.jpg" },
                    { 412, 138, "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/ava-af40155d-5-lit637956537558080659.jpg" },
                    { 413, 138, "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/3-1020x570.jpg" },
                    { 414, 138, "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/tinh-nang-5.jpg" },
                    { 415, 139, "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-2-1020x570-1.jpg" },
                    { 416, 139, "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047016485840.jpg" },
                    { 417, 139, "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047018855747.jpg" },
                    { 418, 140, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018751589262.jpg" },
                    { 419, 140, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018737269189.gif" },
                    { 420, 140, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 421, 141, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpg" },
                    { 422, 141, "https://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(2).jpg" },
                    { 423, 141, "https://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(4).jpg" },
                    { 424, 142, "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(2).jpg" },
                    { 425, 142, "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(3).jpg" },
                    { 426, 142, "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(4).jpg" },
                    { 427, 143, "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409519551001.jpg" },
                    { 428, 143, "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409520581014.jpg" },
                    { 429, 143, "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409521621105.jpg" },
                    { 430, 144, "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221087301321.gif" },
                    { 431, 144, "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221081601265.gif" },
                    { 432, 144, "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221096181354.jpg" },
                    { 433, 145, "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-1.jpg" },
                    { 434, 145, "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-3.jpg" },
                    { 435, 145, "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-2.jpg" },
                    { 436, 146, "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/-artboard-3-(1).jpg" },
                    { 437, 146, "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-2.jpg" },
                    { 438, 146, "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-1-(1).jpg" },
                    { 439, 147, "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861153767.jpg" },
                    { 440, 147, "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861983811.jpg" },
                    { 441, 147, "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/vi-vn-lung-senko-l1638637962675862923843-copy.jpg" },
                    { 442, 148, "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831920187882.gif" },
                    { 443, 148, "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831923127883.jpg" },
                    { 444, 148, "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831922237870.jpg" },
                    { 445, 149, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792400586624.gif" },
                    { 446, 149, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792399526428.jpg" },
                    { 447, 149, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpg" },
                    { 448, 150, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpg" },
                    { 449, 150, "https://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-3.jpg" },
                    { 450, 150, "https://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-4.jpg" },
                    { 451, 151, "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784521558850.gif" },
                    { 452, 151, "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784530598927.jpg" },
                    { 453, 151, "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784498602706.jpg" },
                    { 454, 152, "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpg" },
                    { 455, 152, "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpg" },
                    { 456, 152, "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777905.jpg" },
                    { 457, 153, "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426805242552.jpg" },
                    { 458, 153, "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426806303120.jpg" },
                    { 459, 153, "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426807332619.gif" },
                    { 460, 154, "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270747742066.jpg" },
                    { 461, 154, "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270748552124.jpg" },
                    { 462, 154, "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270750642154.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 463, 155, "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-1.jpg" },
                    { 464, 155, "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-5.jpg" },
                    { 465, 155, "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-canh-quat.jpg" },
                    { 466, 156, "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-may-say-thong-hoi-galanz-dv-70q1c-2.jpg" },
                    { 467, 156, "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-khoi-luong-may-say-thong-hoi-galanz-dv-70q1c-3.jpg" },
                    { 468, 156, "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-chuong-trinh-say-may-say-thong-hoi-galanz-dv-70q1c-4.jpg" },
                    { 469, 157, "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128165.jpg" },
                    { 470, 157, "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128178-(1).jpg" },
                    { 471, 157, "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128160.jpg" },
                    { 472, 158, "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-19.png" },
                    { 473, 158, "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-20.png" },
                    { 474, 158, "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-21.png" },
                    { 475, 159, "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253873168169.jpg" },
                    { 476, 159, "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874088441.jpg" },
                    { 477, 159, "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874968425.jpg" },
                    { 478, 160, "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/2-1028x578.jpg" },
                    { 479, 160, "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/3-1020x570.jpg" },
                    { 480, 160, "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/4-1020x570.jpg" },
                    { 481, 161, "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023825.jpg" },
                    { 482, 161, "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023856.jpg" },
                    { 483, 161, "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-130723-113516.jpg" },
                    { 484, 162, "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175913318814.jpg" },
                    { 485, 162, "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175914328840.jpg" },
                    { 486, 162, "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175915268944.jpg" },
                    { 487, 163, "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-2.jpg" },
                    { 488, 163, "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-3.jpg" },
                    { 489, 163, "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-4.jpg" },
                    { 490, 164, "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087530263383.jpg" },
                    { 491, 164, "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087531273334.jpg" },
                    { 492, 164, "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087532343348.jpg" },
                    { 493, 165, "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-2.jpg" },
                    { 494, 165, "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-3.jpg" },
                    { 495, 165, "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-4.jpg" },
                    { 496, 166, "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620147203825.jpg" },
                    { 497, 166, "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620148293832.jpg" },
                    { 498, 166, "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620149193805.jpg" },
                    { 499, 167, "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpg" },
                    { 500, 167, "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpg" },
                    { 501, 167, "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701396132621.jpg" },
                    { 502, 168, "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-110955.jpg" },
                    { 503, 168, "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111058.jpg" },
                    { 504, 168, "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111131.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 505, 169, "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745148.jpg" },
                    { 506, 169, "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745116.jpg" },
                    { 507, 169, "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745083.jpg" },
                    { 508, 170, "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344524.jpg" },
                    { 509, 170, "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344545.jpg" },
                    { 510, 170, "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344492.jpg" },
                    { 511, 171, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpg" },
                    { 512, 171, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpg" },
                    { 513, 171, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg" },
                    { 514, 172, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpg" },
                    { 515, 172, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpg" },
                    { 516, 172, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg" },
                    { 517, 173, "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533255389572.jpg" },
                    { 518, 173, "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533254489493.jpg" },
                    { 519, 173, "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533251179393.jpg" },
                    { 520, 174, "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362669326069.jpg" },
                    { 521, 174, "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667866005.jpg" },
                    { 522, 174, "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667026013.jpg" },
                    { 523, 175, "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/bluestone-mob-7733-25-lit637688001563014937.jpg" },
                    { 524, 175, "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/3-1020x570.jpg" },
                    { 525, 175, "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/4-1020x570.jpg" },
                    { 526, 176, "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082498421640.jpg" },
                    { 527, 176, "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082497591644.jpg" },
                    { 528, 176, "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082496741625.jpg" },
                    { 529, 177, "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/2-min.jpg" },
                    { 530, 177, "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/3.jpg" },
                    { 531, 177, "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/4.jpg" },
                    { 532, 178, "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882448995926.jpg" },
                    { 533, 178, "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882450315945.jpg" },
                    { 534, 178, "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882451896008.jpg" },
                    { 535, 179, "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053426432333.jpg" },
                    { 536, 179, "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053425522315.jpg" },
                    { 537, 179, "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053424072423.jpg" },
                    { 538, 180, "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/2.jpg" },
                    { 539, 180, "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/3.jpg" },
                    { 540, 180, "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/4.jpg" },
                    { 541, 181, "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102501.jpg" },
                    { 542, 181, "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102512.jpg" },
                    { 543, 181, "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-0653220.jpg" },
                    { 544, 182, "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642354.jpg" },
                    { 545, 182, "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642396.jpg" },
                    { 546, 182, "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642322.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 547, 183, "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742187747662.jpg" },
                    { 548, 183, "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742188627552.jpg" },
                    { 549, 183, "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742189537562.jpg" },
                    { 550, 184, "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333812797881.jpg" },
                    { 551, 184, "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333811900019.jpg" },
                    { 552, 184, "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333810992534.jpg" },
                    { 553, 185, "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777980886164.jpg" },
                    { 554, 185, "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777979636127.jpg" },
                    { 555, 185, "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777978286125.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 15, 31, 0, 60, DateTimeKind.Local).AddTicks(8325));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 2, "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 3, "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-thiet-ke-(1).jpghttps://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-dung-tich-(1).jpghttps://cdn.tgdd.vn/Products/Images/1989/210263/Slider/congsuat-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 4, "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 5, "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654167272451.jpghttps://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654168202480.jpghttps://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654169122563.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 6, "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-3.jpghttps://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 7, "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(2).jpghttps://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(3).jpghttps://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(4).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 8, "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923030465278.jpghttps://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923031375346.jpg https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923032445291.jpgv" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 9, "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-3.jpghttps://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 10, "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-thiet-ke.jpghttps://cdn.tgdd.vn/Products/Images/1989/193481/Slider/cong-suat-780x433.jpghttps://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-dung-tich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 11, "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/224396/Slider/-congsuat-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 12, "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-congsuat.jpghttps://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 13, "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/177836/Slider/Untitled-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 14, "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466480780750.jpghttps://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466481600801.jpghttps://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466485200682.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 15, "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/Untitled-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 16, "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/217362/Slider/a4-780x433.pnghttps://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 17, "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(6).jpghttps://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(4).jpghttps://cdn.tgdd.vn/Products/Images/1989/204621/Slider/a2-780x433.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 18, "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-7.jpghttps://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-4.jpghttps://cdn.tgdd.vn/Products/Images/1989/203066/Slider/thumb-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 19, "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-3.jpghttps://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 20, "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-congsuat.jpghttps://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-dungtich.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 21, "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/2KG855i-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516149397546.jpghttps://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516150627512.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 22, "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709265189907349.jpghttps://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274051416304.jpghttps://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274053406269.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 23, "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148159663228.jpghttps://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148161073382.jpghttps://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638277628983499420.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 24, "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208638306537136599246.jpghttps://cdn.tgdd.vn/Products/Images/1982/237344/Slider/vi-vn-doi-pramie-2208-230721-0436562.jpghttps://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208-230721-0436578.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 25, "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-3.jpghttps://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-4.jpghttps://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 26, "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-1-min.jpghttps://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-2-min.jpghttps://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-3-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 27, "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-3-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-4-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 28, "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157188439325.jpghttps://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157187419347.jpghttps://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157186249325.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 29, "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-4-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-3-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 30, "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-thietkefinal.jpghttps://cdn.tgdd.vn/Products/Images/1982/234972/Slider/galanz-ch211e637701457133462016.jpghttps://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-matbepfinal.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 31, "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-1.jpghttps://cdn.tgdd.vn/Products/Images/3305/63990/Slider/-hong-ngoai-sanaky-at-2524hgn-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 32, "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117081.jpghttps://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117092.jpghttps://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117113.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 33, "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/tongcongsuat-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127511.jpghttps://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127500.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 34, "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-2-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-3-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-4-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 35, "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788887736001.jpghttps://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788587167004.jpghttps://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788583007035.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 36, "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-02.gifhttps://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-3.jpghttps://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 37, "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-02.pnghttps://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-03.jpghttps://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-05.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 38, "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761528510276.gifhttps://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761529460408.gifhttps://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761530420342.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 39, "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-2.jpghttps://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-3.jpghttps://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 40, "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/smart-samsung-4k-43-inch-ua43au7002638022060998318047.gifhttps://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-3.jpghttps://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 41, "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-5.jpghttps://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-006.jpghttps://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 42, "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-2.pnghttps://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-4.pnghttps://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-8.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 43, "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-2.gifhttps://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-3.gifhttps://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 44, "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489862454084.jpghttps://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489863354037.jpghttps://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489864254065.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 45, "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-006.jpghttps://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-9.jpghttps://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-10.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 46, "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972278342842.jpghttps://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972277412853.jpghttps://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972276662851.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 47, "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490700146555.jpghttps://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490701116452.jpghttps://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490702106380.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 48, "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-2.gifhttps://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-3.gifhttps://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 49, "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996419458470.pnghttps://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996422198459.pnghttps://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996424168464.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 50, "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-2.pnghttps://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-4.pnghttps://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-8.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 51, "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/02-1020x571.jpghttps://cdn.tgdd.vn/Products/Images/1943/220325/Slider/03-1020x571.jpghttps://cdn.tgdd.vn/Products/Images/1943/220325/Slider/06-1020x571.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 52, "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/1-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1943/220326/Slider/2-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1943/220326/Slider/4-1020x570-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 53, "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-050821-0710241.pnghttps://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-100821-0218070.jpghttps://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-210821-1005141.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 54, "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798790132815.jpghttps://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798792382855.jpghttps://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798793442838.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 55, "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/2-1020x570.pnghttps://cdn.tgdd.vn/Products/Images/1943/202857/Slider/toshiba-gr-b22vu-ukg-050821-1121262.jpghttps://cdn.tgdd.vn/Products/Images/1943/202857/Slider/198-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 56, "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/2-1020x570.pnghttps://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.pnghttps://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 57, "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb2.jpghttps://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb3.jpghttps://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 58, "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-5.jpghttps://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-6.jpghttps://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 59, "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/samsung-rt20har8dbu-sv-080821-0639042.jpghttps://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-2-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-4-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 60, "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-080821-0341071.jpghttps://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-210821-0601370.jpghttps://cdn.tgdd.vn/Products/Images/1943/225858/Slider/225858-1020x570.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 61, "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667257173349.jpghttps://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258003283.jpghttps://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258813389.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 62, "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007604134225944.jpghttps://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603868094190.jpghttps://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603817113795.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 63, "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760509272052.jpghttps://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760510222056.jpghttps://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760511042060.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 64, "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343064927731.jpghttps://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343066856041.jpghttps://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343067926248.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 65, "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404755929362-1020x571.jpghttps://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404757959374.jpghttps://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404760909361.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 66, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121296906251.jpghttps://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121297826281.jpghttps://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 67, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpghttps://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618087619203.jpghttps://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 68, "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpghttps://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-giat-nuoc-nong-panasonic-na-fd95v1brv-3.jpghttps://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-bot-min-panasonic-na-fd95v1brv-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 69, "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-03.jpghttps://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-04.jpghttps://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-05.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 70, "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/vi-vn-toshiba-7-kg-aw-l805av-sg03.jpghttps://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-4-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-3-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 71, "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/chuong-trinh-giat-may-giat-samsung-12kg-wa12cg5745bvsv-1018x575.jpghttps://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204011022314.jpghttps://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204012042319.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 72, "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-giat-nuoc-nong--panasonic-na-fd10vr1bv-3.jpghttps://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-bot-min-panasonic-na-fd10vr1bv-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 73, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 74, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 75, "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb2.jpghttps://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb3.jpghttps://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 76, "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528027737733.jpghttps://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528028857718.jpghttps://cdn.tgdd.vn/Products/Images/1944/274173/Slider/06-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 77, "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/5-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/230077/Slider/7-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/230077/Slider/8-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 78, "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/3-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 79, "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734854518930.jpghttps://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734855308947.jpghttps://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734856288998.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 80, "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/307863/Slider/5-1018x575.jpghttps://cdn.tgdd.vn/Products/Images/1944/307863/Slider/may-giat-aqua-inverter-9-5-kg-aqd-a952j-bk638271882394422354.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 81, "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016161.jpghttps://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016192.jpghttps://cdn.tgdd.vn/Products/Images/1922/131925/Slider/a6-780x433.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 82, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080436398647.gifhttps://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080743600911.jpghttps://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 83, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1922/72067/Slider/vi-vn-cong-nghe-nau3d.jpghttps://cdn.tgdd.vn/Products/Images/1922/72067/Slider/NO2-780x433-A-780x433.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 84, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921571.jpghttps://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921572.jpghttps://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 85, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpghttps://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-3.jpghttps://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 86, "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpghttps://cdn.tgdd.vn/Products/Images/1922/203417/Slider/-dung-tich.jpghttps://cdn.tgdd.vn/Products/Images/1922/203417/Slider/vi-vn-cong-nghe-nau1d.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 87, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-delites-ncr1502.jpghttps://cdn.tgdd.vn/Products/Images/1922/147243/Slider/n%E1%BB%93i-c%C6%A1m-n%E1%BA%AFp-r%E1%BB%9Di-delites-ncr1502-111120-0416280.jpghttps://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 88, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpghttps://cdn.tgdd.vn/Products/Images/1922/275584/Slider/hinh-3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1922/275584/Slider/vi-vn-sunhouse-12-lit-shd8217w-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 89, "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-thiet-ke.jpghttps://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-dung-tich.jpghttps://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-chat-lieu-long-noi.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 90, "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-noi-com-nap-gai-toshiba-rc-10jh2pv-b-1l-(1).pnghttps://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-cong-nghe-nau1d-in-thuong.jpghttps://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-bang-dieu-khien.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 91, "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928471.jpghttps://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928482.jpghttps://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928483.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 92, "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-2.jpghttps://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-10.jpghttps://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-cong-nghe-nau3d.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 93, "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-thiet-ke.jpghttps://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-dung-tich-1.jpghttps://cdn.tgdd.vn/Products/Images/1922/220502/Slider/vi-vn-cong-nghe-nau1d.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 94, "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720211.jpghttps://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpghttps://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 95, "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-thietke2.jpghttps://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-dung-tich.jpghttps://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-cong-nghe-nau3d.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 96, "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-18.jpghttps://cdn.tgdd.vn/Products/Images/2162/214631/Slider/1-780x433-780x433.jpghttps://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-13.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 97, "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311729789327.jpghttps://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311732449371.jpghttps://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311734499431.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 98, "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-3.jpghttps://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 99, "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(2).jpghttps://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(3).jpghttps://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(4).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 100, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-3.jpghttps://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 101, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpghttps://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014372-780x433.jpghttps://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014340.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 102, "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208261.jpghttps://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208272.jpghttps://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208283.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 103, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-3.jpghttps://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 104, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpghttps://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556233422401.jpghttps://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556232132456.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 105, "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142290.jpghttps://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142311.jpghttps://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142322.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 106, "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220311.jpghttps://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220322.jpghttps://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220333.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 107, "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpghttps://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 108, "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325321.jpghttps://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325332.jpghttps://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325344.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 109, "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042071.jpghttps://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042082.jpghttps://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042093.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 110, "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988717215598.jpghttps://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988715785825.jpghttps://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988720605323.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 111, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(1).jpghttps://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-vi-vn-vi-vn-vi-vn-sunhouse-shd7727-kg--(4).jpghttps://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 112, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpghttps://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 113, "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556893691639.jpghttps://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556894541546.jpghttps://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556899521529.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 114, "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 115, "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpghttps://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpghttps://cdn.tgdd.vn/Products/Images/7498/218312/Slider/-vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(1)-copy.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 116, "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 117, "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-12.jpghttps://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 118, "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 119, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 120, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpghttps://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 121, "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085709130066.jpghttps://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085710240063.jpghttps://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085711406269.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 122, "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-1.jpghttps://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-8.jpghttps://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-9.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 123, "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/vi-vn-quat-dieu-hoa-khong-khi-rapido-9000d-(1).jpghttps://cdn.tgdd.vn/Products/Images/7498/219138/Slider/Untitled-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/7498/219138/Slider/quat-dieu-hoa-khong-khi-rapido-9000d-190821-0759520.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 124, "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 125, "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/thietke-780x433.jpghttps://cdn.tgdd.vn/Products/Images/7498/235380/Slider/congsuat-780x433-1.jpghttps://cdn.tgdd.vn/Products/Images/7498/235380/Slider/dakho-780x433-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 126, "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750178906564.jpghttps://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750177976576.jpghttps://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750176666568.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 127, "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit-1a-min-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342257456180.jpghttps://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342256156195-1020x570--2--1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 128, "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662592506879.gifhttps://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638318407391409045.jpghttps://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662590086953.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 129, "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/ava-kdf-593d-75lit637956538234543296.jpghttps://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-3-(1).jpghttps://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-5-(2).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 130, "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/ava-af358t-4-lit637956536037141108.jpghttps://cdn.tgdd.vn/Products/Images/9418/240297/Slider/3-1020x573.jpghttps://cdn.tgdd.vn/Products/Images/9418/240297/Slider/5-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 131, "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-2.gifhttps://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-3.jpghttps://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-4--2--1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 132, "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit-2-min-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474989859767-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474988859626-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 133, "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194027111283.jpghttps://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194028841288.gifhttps://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194036871330.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 134, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-2.jpghttps://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-3.jpghttps://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 135, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpghttps://cdn.tgdd.vn/Products/Images/9418/217595/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/217595/Slider/noi-chien-khong-dau-kangaroo-kg55af1a-2-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 136, "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/hafele-af-t5a-2-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/9418/233494/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/233494/Slider/5-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 137, "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035764079802.jpghttps://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit-6-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035762639897.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 138, "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/ava-af40155d-5-lit637956537558080659.jpghttps://cdn.tgdd.vn/Products/Images/9418/235357/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/235357/Slider/tinh-nang-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 139, "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-2-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047016485840.jpghttps://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047018855747.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 140, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018751589262.jpghttps://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018737269189.gifhttps://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 141, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpghttps://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(2).jpghttps://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(4).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 142, "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(2).jpghttps://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(3).jpghttps://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(4).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 143, "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409519551001.jpghttps://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409520581014.jpghttps://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409521621105.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 144, "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221087301321.gifhttps://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221081601265.gifhttps://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221096181354.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 145, "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-3.jpghttps://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 146, "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/-artboard-3-(1).jpghttps://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-2.jpghttps://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-1-(1).jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 147, "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861153767.jpghttps://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861983811.jpghttps://cdn.tgdd.vn/Products/Images/1992/268452/Slider/vi-vn-lung-senko-l1638637962675862923843-copy.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 148, "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831920187882.gifhttps://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831923127883.jpghttps://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831922237870.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 149, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792400586624.gifhttps://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792399526428.jpghttps://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 150, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpghttps://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-3.jpghttps://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 151, "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784521558850.gifhttps://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784530598927.jpghttps://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784498602706.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 152, "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpghttps://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpghttps://cdn.tgdd.vn/Products/Images/1992/275528/vy3777905.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 153, "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426805242552.jpghttps://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426806303120.jpghttps://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426807332619.gif" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 154, "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270747742066.jpghttps://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270748552124.jpghttps://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270750642154.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 155, "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-1.jpghttps://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-5.jpghttps://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-canh-quat.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 156, "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-may-say-thong-hoi-galanz-dv-70q1c-2.jpghttps://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-khoi-luong-may-say-thong-hoi-galanz-dv-70q1c-3.jpghttps://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-chuong-trinh-say-may-say-thong-hoi-galanz-dv-70q1c-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 157, "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128165.jpghttps://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128178-(1).jpghttps://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128160.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 158, "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-19.pnghttps://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-20.pnghttps://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-21.png" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 159, "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253873168169.jpghttps://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874088441.jpghttps://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874968425.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 160, "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/2-1028x578.jpghttps://cdn.tgdd.vn/Products/Images/2202/272144/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/2202/272144/Slider/4-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 161, "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023825.jpghttps://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023856.jpghttps://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-130723-113516.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 162, "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175913318814.jpghttps://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175914328840.jpghttps://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175915268944.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 163, "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-2.jpghttps://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-3.jpghttps://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 164, "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087530263383.jpghttps://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087531273334.jpghttps://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087532343348.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 165, "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-2.jpghttps://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-3.jpghttps://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 166, "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620147203825.jpghttps://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620148293832.jpghttps://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620149193805.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 167, "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpghttps://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpghttps://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701396132621.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 168, "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-110955.jpghttps://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111058.jpghttps://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111131.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 169, "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745148.jpghttps://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745116.jpghttps://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745083.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 170, "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344524.jpghttps://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344545.jpghttps://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344492.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 171, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 172, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 173, "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533255389572.jpghttps://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533254489493.jpghttps://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533251179393.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 174, "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362669326069.jpghttps://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667866005.jpghttps://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667026013.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 175, "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/bluestone-mob-7733-25-lit637688001563014937.jpghttps://cdn.tgdd.vn/Products/Images/1987/242774/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1987/242774/Slider/4-1020x570.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 176, "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082498421640.jpghttps://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082497591644.jpghttps://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082496741625.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 177, "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/2-min.jpghttps://cdn.tgdd.vn/Products/Images/1987/197818/Slider/3.jpghttps://cdn.tgdd.vn/Products/Images/1987/197818/Slider/4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 178, "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882448995926.jpghttps://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882450315945.jpghttps://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882451896008.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 179, "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053426432333.jpghttps://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053425522315.jpghttps://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053424072423.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 180, "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/2.jpghttps://cdn.tgdd.vn/Products/Images/1987/203059/Slider/3.jpghttps://cdn.tgdd.vn/Products/Images/1987/203059/Slider/4.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 181, "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102501.jpghttps://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102512.jpghttps://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-0653220.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 182, "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642354.jpghttps://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642396.jpghttps://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642322.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 183, "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742187747662.jpghttps://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742188627552.jpghttps://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742189537562.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 184, "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333812797881.jpghttps://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333811900019.jpghttps://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333810992534.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ProductId", "Url" },
                values: new object[] { 185, "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777980886164.jpghttps://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777979636127.jpghttps://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777978286125.jpg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 19, 23, 16, 32, 657, DateTimeKind.Local).AddTicks(3573));
        }
    }
}
