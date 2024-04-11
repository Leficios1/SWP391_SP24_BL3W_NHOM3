using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderProductsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDetailsId = table.Column<int>(type: "int", nullable: false),
                    ProductsDetailsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProductsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProductsDetails_ProductDetials_ProductsDetailsId",
                        column: x => x.ProductsDetailsId,
                        principalTable: "ProductDetials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProductsDetails_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProductsDetails_ProductsDetailsId",
                table: "OrderProductsDetails",
                column: "ProductsDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProductsDetails_ProductsId",
                table: "OrderProductsDetails",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProductsDetails");
        }
    }
}
