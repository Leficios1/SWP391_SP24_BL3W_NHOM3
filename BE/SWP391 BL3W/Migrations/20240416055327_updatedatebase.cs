using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class updatedatebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_CategoryBlog_CategoryBlogId",
                table: "Blog");

            migrationBuilder.RenameColumn(
                name: "CategoryBlogId",
                table: "Blog",
                newName: "CategoryBlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_CategoryBlogId",
                table: "Blog",
                newName: "IX_Blog_CategoryBlogID");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryBlogID",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 16, 12, 53, 26, 786, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "AvatarUrl", "DateOfBirth", "Email", "Gender", "Name", "Password", "RoleId", "phone", "status" },
                values: new object[,]
                {
                    { 2, "HCM", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer@gmail.com", "Male", "Custommer", "12345", 2, "0501255079", true },
                    { 3, "Ho Chi Minh City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1999, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "jennifer.nguyen@gmail.com", "Female", "Jennifer Nguyen", "12345", 2, "0987654321", true },
                    { 4, "HCMC, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1995, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.tran@gmail.com", "Male", "David Tran", "12345", 2, "0901234567", true },
                    { 5, "District 3, HCMC", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1999, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "jessica.le@gmail.com", "Female", "Jessica Le", "12345", 2, "0975123456", true },
                    { 6, "Tan Binh District, HCM", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1988, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.vo@gmail.com", "Male", "Kevin Vo", "12345", 2, "0943216789", true },
                    { 7, "Phu Nhuan District, HCMC", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1992, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "amanda.ho@gmail.com", "Female", "Amanda Ho", "12345", 2, "0912345678", true },
                    { 8, "District 1, HCM", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1985, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "alex.nguyen@gmail.com", "Male", "Alex Nguyen", "12345", 2, "0987654321", true },
                    { 9, "Khanh Hoa, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2003, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "nkhuong038424@gmail.com", "Male", "David Khương", "12345", 2, "0905022946", true },
                    { 10, "Quang Ngai, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2003, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "khoatony3705@gmail.com", "Male", "Tony Khoa", "12345", 2, "0987657456", true },
                    { 11, "Binh Thanh District, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1997, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "michelle.pham@gmail.com", "Female", "Michelle Pham", "12345", 2, "0965432187", true },
                    { 12, "Da nang City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1983, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "jason.hoang@gmail.com", "Male", "Jason Hoang", "12345", 2, "0934567890", true },
                    { 13, "Tan Phu District, HCMC", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1991, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "stephanie.truong@gmail.com", "Female", "Stephanie Truong", "12345", 2, "0908765432", true },
                    { 14, "Vinh City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1997, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "bray.nguyen@gmail.com", "Male", "Bray Nguyen", "12345", 2, "0976543210", true },
                    { 15, "Ho Chi Minh City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1989, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "jonny.dang@gmail.com", "Male", "Jonny Dang", "12345", 2, "0965432109", true },
                    { 16, "Binh Tan District, HCM", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1975, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam.huynh@gmail.com", "Male", "Adam Huynh", "12345", 2, "0912345678", true },
                    { 17, "District 4, HCM", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1993, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "derek.nguyen@gmail.com", "Male", "Derek Nguyen", "12345", 2, "0943216789", true },
                    { 18, "Ho Chi Minh City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1992, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.nguyen@gmail.com", "Female", "Grace Nguyen", "12345", 2, "0912345678", true },
                    { 19, "District 2, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1985, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.tran@gmail.com", "Male", "Henry Tran", "12345", 2, "0945678901", true },
                    { 20, "Binh Chanh District, HCM", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1996, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jacky.nguyen@gmail.com", "Male", "Jacky Nguyen", "12345", 2, "0976543210", true },
                    { 21, "Nha Trang City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2003, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.khuong@gmail.com", "Male", "Admin Khuong", "12345", 1, "095335780", true },
                    { 22, "Binh Duong, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2003, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.khoa@gmail.com", "Male", "Admin Khoa", "12345", 1, "0953354430", true },
                    { 23, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.khoi@gmail.com", "Male", "Admin Khoi", "12345", 1, "0953353409", true },
                    { 24, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(1993, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.Truong@gmail.com", "Male", "Staff Truong", "12345", 3, "0501370820", true },
                    { 25, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.quynh@gmail.com", "Female", "Staff Quynh", "12345", 3, "0502360820", true },
                    { 26, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.anh@gmail.com", "Female", "Staff Anh", "12345", 3, "0502360730", true },
                    { 27, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.duc@gmail.com", "Male", "Staff Duc", "12345", 3, "0502366423", true },
                    { 28, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2003, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.Dang@gmail.com", "Male", "Staff Dang", "12345", 3, "0502360830", true },
                    { 29, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.Nhan@gmail.com", "Male", "Staff Nhan", "12345", 3, "0502360831", true },
                    { 30, "HCM City, Vietnam", "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg", new DateTime(2002, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin.Phu@gmail.com", "Male", "Staff Phu", "12345", 3, "0703298295", true }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_CategoryBlog_CategoryBlogID",
                table: "Blog",
                column: "CategoryBlogID",
                principalTable: "CategoryBlog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_CategoryBlog_CategoryBlogID",
                table: "Blog");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.RenameColumn(
                name: "CategoryBlogID",
                table: "Blog",
                newName: "CategoryBlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_CategoryBlogID",
                table: "Blog",
                newName: "IX_Blog_CategoryBlogId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryBlogId",
                table: "Blog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 15, 15, 40, 43, 52, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_CategoryBlog_CategoryBlogId",
                table: "Blog",
                column: "CategoryBlogId",
                principalTable: "CategoryBlog",
                principalColumn: "Id");
        }
    }
}
