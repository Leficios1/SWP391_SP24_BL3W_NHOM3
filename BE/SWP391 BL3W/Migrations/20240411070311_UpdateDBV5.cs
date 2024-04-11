using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProductsDetails_Products_ProductsId",
                table: "OrderProductsDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderProductsDetails_ProductsId",
                table: "OrderProductsDetails");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "OrderProductsDetails");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProductsDetails_OrderDetailsId",
                table: "OrderProductsDetails",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProductsDetails_OrderDetails_OrderDetailsId",
                table: "OrderProductsDetails",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProductsDetails_OrderDetails_OrderDetailsId",
                table: "OrderProductsDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderProductsDetails_OrderDetailsId",
                table: "OrderProductsDetails");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "OrderProductsDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProductsDetails_ProductsId",
                table: "OrderProductsDetails",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProductsDetails_Products_ProductsId",
                table: "OrderProductsDetails",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
