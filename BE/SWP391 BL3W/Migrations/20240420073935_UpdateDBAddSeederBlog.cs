using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBAddSeederBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryBlog",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Bình ấm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 20, 14, 39, 34, 888, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "CategoryBlogID", "ImageUrl", "Title", "UserId", "content" },
                values: new object[] { 1, 1, "https://ckeditor.com/assets/images/ckdemo/ckbox/browse-files.png", "<h2>\r\nElctricstorre\r\n</h2>\r\n", 24, "<p>\r\n    Uncover the power of CKEditor 5 combined with CKBox, offering unparalleled ease in image management, editing, and file storage.\r\n</p>\r\n<h3>\r\n    Seamless Image Insertion\r\n</h3>\r\n<ul>\r\n    <li>\r\n        Open CKBox: Start by clicking the first toolbar button to open CKBox <img src=\"https://ckeditor.com/assets/images/ckdemo/ckbox/browse-files.png\" alt=\"Browse files\" srcset=\"\r\n        				https://ckeditor.com/assets/images/ckdemo/ckbox/browse-files.png 2x\r\n        			\" sizes=\"100vw\" width=\"20\" height=\"20\">, your portal to an extensive image library.\r\n    </li>\r\n    <li>\r\n        Choose and Insert Images: Browse through CKBox to pick the perfect image. Hit the \"Choose\" button to insert it directly into your CKEditor content.\r\n    </li>\r\n    <li>\r\n        Drag &amp; Drop Uploading: For a faster approach, drag and drop images right into CKEditor for immediate uploading.\r\n    </li>\r\n</ul>\r\n<h3>\r\n    Advanced Image Editing Capabilities\r\n</h3>\r\n<ul>\r\n    <li>\r\n        Editing: Select an image, and then edit (icon). Resize, crop, and rotate directly from the editor, ensuring perfect placement every time.\r\n    </li>\r\n    <li>\r\n        Customizable Styles: Apply various presets to format your image according to social media standards.\r\n    </li>\r\n</ul>\r\n<figure class=\"image\">\r\n    <img style=\"aspect-ratio:1600/900;\" src=\"https://ckeditor.com/assets/images/ckdemo/ckbox/ckbox.jpg\" alt=\"CKBox\" srcset=\"https://ckeditor.com/assets/images/ckdemo/ckbox/ckbox.jpg 2x\" sizes=\"100vw\" width=\"1600\" height=\"900\">\r\n</figure>\r\n<h3>\r\n    Efficient File Storage and Management\r\n</h3>\r\n<p>\r\n    File Storage: Store your files in the CKBox, and then link them in the editor, see the examples below:\r\n</p>\r\n<ul>\r\n    <li>\r\n        <a href=\"https://ckbox.cloud/rc1DFuFpHqcR3Mah6y0e/assets/fZ80j2kBXus9/file?download=true\" data-ckbox-resource-id=\"6dvpcACCdA02\">Presentation</a>\r\n    </li>\r\n    <li>\r\n        <a href=\"https://ckbox.cloud/rc1DFuFpHqcR3Mah6y0e/assets/6OPSiQ4nquqq/file?download=true\" data-ckbox-resource-id=\"vWExt16w0Se0\">List of products</a>\r\n    </li>\r\n    <li>\r\n        <a href=\"https://ckbox.cloud/rc1DFuFpHqcR3Mah6y0e/assets/VjmTQ_vAbX-T/file?download=true\" data-ckbox-resource-id=\"MU8NoYaB-D33\">Final agreement copy</a>\r\n    </li>\r\n</ul>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryBlog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 17, 16, 36, 0, 404, DateTimeKind.Local).AddTicks(4593));
        }
    }
}
