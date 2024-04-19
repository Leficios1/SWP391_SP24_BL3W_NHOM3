using Microsoft.EntityFrameworkCore;

namespace SWP391_BL3W.Database
{
    public static class SWPContextSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(

               new Role
               {
                   RoleId = 1,
                   RoleName = "Admin"
               },
               new Role
               {
                   RoleId = 2,
                   RoleName = "Customer"
               },
               new Role
               {
                   RoleId = 3,
                   RoleName = "Staff"
               }
               );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Ấm siêu tốc"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Bếp điện từ"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Tivi"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Tủ Lạnh"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Máy Giặt"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Nồi Cơm Điện"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Loa"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Quạt Điều Hòa"
                },
                new Category
                {
                    CategoryID = 9,
                    CategoryName = "Nồi Chiên"
                },
                new Category
                {
                    CategoryID = 10,
                    CategoryName = "Máy Quạt"
                },
                new Category
                {
                    CategoryID = 11,
                    CategoryName = "Máy Sấy"
                },
                new Category
                {
                    CategoryID = 12,
                    CategoryName = "Lò Vi Sóng"
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "admin",
                    Email = "admin@gmail.com",
                    Password = "12345",
                    phone = "0321456789",
                    Address = "HCM",
                    DateOfBirth = DateTime.Now,
                    RoleId = 1,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 2,
                    Name = "Custommer",
                    Email = "customer@gmail.com",
                    Password = "12345",
                    phone = "0501255079",
                    Address = "HCM",
                    DateOfBirth = new DateTime(2002, 05, 23),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 3,
                    Name = "Jennifer Nguyen",
                    Email = "jennifer.nguyen@gmail.com",
                    Password = "12345",
                    phone = "0987654321",
                    Address = "Ho Chi Minh City, Vietnam",
                    DateOfBirth = new DateTime(1999, 03, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Female",
                    status = true
                },
                new User
                {
                    Id = 4,
                    Name = "David Tran",
                    Email = "david.tran@gmail.com",
                    Password = "12345",
                    phone = "0901234567",
                    Address = "HCMC, Vietnam",
                    DateOfBirth = new DateTime(1995, 07, 20),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 5,
                    Name = "Jessica Le",
                    Email = "jessica.le@gmail.com",
                    Password = "12345",
                    phone = "0975123456",
                    Address = "District 3, HCMC",
                    DateOfBirth = new DateTime(1999, 03, 12),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Female",
                    status = true
                },
                new User
                {
                    Id = 6,
                    Name = "Kevin Vo",
                    Email = "kevin.vo@gmail.com",
                    Password = "12345",
                    phone = "0943216789",
                    Address = "Tan Binh District, HCM",
                    DateOfBirth = new DateTime(1988, 12, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 7,
                    Name = "Amanda Ho",
                    Email = "amanda.ho@gmail.com",
                    Password = "12345",
                    phone = "0912345678",
                    Address = "Phu Nhuan District, HCMC",
                    DateOfBirth = new DateTime(1992, 05, 30),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Female",
                    status = true
                },
                new User
                {
                    Id = 8,
                    Name = "Alex Nguyen",
                    Email = "alex.nguyen@gmail.com",
                    Password = "12345",
                    phone = "0987654321",
                    Address = "District 1, HCM",
                    DateOfBirth = new DateTime(1985, 03, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 9,
                    Name = "David Khương",
                    Email = "nkhuong038424@gmail.com",
                    Password = "12345",
                    phone = "0905022946",
                    Address = "Khanh Hoa, Vietnam",
                    DateOfBirth = new DateTime(2003, 08, 04),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 10,
                    Name = "Tony Khoa",
                    Email = "khoatony3705@gmail.com",
                    Password = "12345",
                    phone = "0987657456",
                    Address = "Quang Ngai, Vietnam",
                    DateOfBirth = new DateTime(2003, 03, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 11,
                    Name = "Michelle Pham",
                    Email = "michelle.pham@gmail.com",
                    Password = "12345",
                    phone = "0965432187",
                    Address = "Binh Thanh District, Vietnam",
                    DateOfBirth = new DateTime(1997, 11, 05),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Female",
                    status = true
                },
                new User
                {
                    Id = 12,
                    Name = "Jason Hoang",
                    Email = "jason.hoang@gmail.com",
                    Password = "12345",
                    phone = "0934567890",
                    Address = "Da nang City, Vietnam",
                    DateOfBirth = new DateTime(1983, 08, 04),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 13,
                    Name = "Stephanie Truong",
                    Email = "stephanie.truong@gmail.com",
                    Password = "12345",
                    phone = "0908765432",
                    Address = "Tan Phu District, HCMC",
                    DateOfBirth = new DateTime(1991, 08, 22),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Female",
                    status = true
                },
                new User
                {
                    Id = 14,
                    Name = "Bray Nguyen",
                    Email = "bray.nguyen@gmail.com",
                    Password = "12345",
                    phone = "0976543210",
                    Address = "Vinh City, Vietnam",
                    DateOfBirth = new DateTime(1997, 03, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 15,
                    Name = "Jonny Dang",
                    Email = "jonny.dang@gmail.com",
                    Password = "12345",
                    phone = "0965432109",
                    Address = "Ho Chi Minh City, Vietnam",
                    DateOfBirth = new DateTime(1989, 04, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 16,
                    Name = "Adam Huynh",
                    Email = "adam.huynh@gmail.com",
                    Password = "12345",
                    phone = "0912345678",
                    Address = "Binh Tan District, HCM",
                    DateOfBirth = new DateTime(1975, 05, 01),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 17,
                    Name = "Derek Nguyen",
                    Email = "derek.nguyen@gmail.com",
                    Password = "12345",
                    phone = "0943216789",
                    Address = "District 4, HCM",
                    DateOfBirth = new DateTime(1993, 02, 24),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 18,
                    Name = "Grace Nguyen",
                    Email = "grace.nguyen@gmail.com",
                    Password = "12345",
                    phone = "0912345678",
                    Address = "Ho Chi Minh City, Vietnam",
                    DateOfBirth = new DateTime(1992, 11, 25),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Female",
                    status = true
                },
                new User
                {
                    Id = 19,
                    Name = "Henry Tran",
                    Email = "henry.tran@gmail.com",
                    Password = "12345",
                    phone = "0945678901",
                    Address = "District 2, Vietnam",
                    DateOfBirth = new DateTime(1985, 02, 18),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 20,
                    Name = "Jacky Nguyen",
                    Email = "jacky.nguyen@gmail.com",
                    Password = "12345",
                    phone = "0976543210",
                    Address = "Binh Chanh District, HCM",
                    DateOfBirth = new DateTime(1996, 04, 03),
                    RoleId = 2,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 21,
                    Name = "Admin Khuong",
                    Email = "admin.khuong@gmail.com",
                    Password = "12345",
                    phone = "095335780",
                    Address = "Nha Trang City, Vietnam",
                    DateOfBirth = new DateTime(2003, 08, 03),
                    RoleId = 1,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 22,
                    Name = "Admin Khoa",
                    Email = "admin.khoa@gmail.com",
                    Password = "12345",
                    phone = "0953354430",
                    Address = "Binh Duong, Vietnam",
                    DateOfBirth = new DateTime(2003, 10, 25),
                    RoleId = 1,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 23,
                    Name = "Admin Khoi",
                    Email = "admin.khoi@gmail.com",
                    Password = "12345",
                    phone = "0953353409",
                    Address = "HCM City, Vietnam",
                    DateOfBirth = new DateTime(2002, 03, 27),
                    RoleId = 1,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                new User
                {
                    Id = 24,
                    Name = "Staff Truong",
                    Email = "admin.Truong@gmail.com",
                    Password = "12345",
                    phone = "0501370820",
                    Address = "HCM City, Vietnam",
                    DateOfBirth = new DateTime(1993, 03, 03),
                    RoleId = 3,
                    AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                    Gender = "Male",
                    status = true
                },
                 new User
                 {
                     Id = 25,
                     Name = "Staff Quynh",
                     Email = "admin.quynh@gmail.com",
                     Password = "12345",
                     phone = "0502360820",
                     Address = "HCM City, Vietnam",
                     DateOfBirth = new DateTime(2002, 07, 03),
                     RoleId = 3,
                     AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                     Gender = "Female",
                     status = true
                 },
                  new User
                  {
                      Id = 26,
                      Name = "Staff Anh",
                      Email = "admin.anh@gmail.com",
                      Password = "12345",
                      phone = "0502360730",
                      Address = "HCM City, Vietnam",
                      DateOfBirth = new DateTime(2002, 05, 23),
                      RoleId = 3,
                      AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                      Gender = "Female",
                      status = true
                  },
                   new User
                   {
                       Id = 27,
                       Name = "Staff Duc",
                       Email = "admin.duc@gmail.com",
                       Password = "12345",
                       phone = "0502366423",
                       Address = "HCM City, Vietnam",
                       DateOfBirth = new DateTime(2002, 05, 01),
                       RoleId = 3,
                       AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                       Gender = "Male",
                       status = true
                   },
                    new User
                    {
                        Id = 28,
                        Name = "Staff Dang",
                        Email = "admin.Dang@gmail.com",
                        Password = "12345",
                        phone = "0502360830",
                        Address = "HCM City, Vietnam",
                        DateOfBirth = new DateTime(2003, 07, 03),
                        RoleId = 3,
                        AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                        Gender = "Male",
                        status = true
                    },
                     new User
                     {
                         Id = 29,
                         Name = "Staff Nhan",
                         Email = "admin.Nhan@gmail.com",
                         Password = "12345",
                         phone = "0502360831",
                         Address = "HCM City, Vietnam",
                         DateOfBirth = new DateTime(2002, 01, 25),
                         RoleId = 3,
                         AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                         Gender = "Male",
                         status = true
                     },
                      new User
                      {
                          Id = 30,
                          Name = "Staff Phu",
                          Email = "admin.Phu@gmail.com",
                          Password = "12345",
                          phone = "0703298295",
                          Address = "HCM City, Vietnam",
                          DateOfBirth = new DateTime(2002, 10, 03),
                          RoleId = 3,
                          AvatarUrl = "https://inkythuatso.com/uploads/thumbnails/800/2023/03/9-anh-dai-dien-trang-inkythuatso-03-15-27-03.jpg",
                          Gender = "Male",
                          status = true
                      }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Bình đun siêu tốc Electrolux 1.7 lít EEK3505",
                    Description = "Thiết kế bắt mắt, vỏ ngoài bằng nhựa bền đẹp, dung tích 1.7 lít " +
                    "Bình đun siêu tốc Electrolux EEK3505 cung cấp đủ nước nóng đáp ứng cho nhu cầu sử dụng của gia đình có từ 3 - 4 thành viên, đồng thời kích cỡ nhỏ gọn và không choán chỗ khi đặt trên gian bếp." +
                    "Bình đun có kiểu dáng hiện đại, trang trí cho gian bếp gia đình." +
                    "Mâm nhiệt inox phẳng, công suất 2200W dẫn nhiệt tốt để nấu nước mau sôi" +
                    "Bình đun siêu tốc Electrolux nấu nước sôi từ 4 - 6 phút, tiết kiệm điện năng tối đa cho gia đình bạn." +
                    "Cách sử dụng bình đun siêu tốc tốt nhất Mâm nhiệt to bằng thép không gỉ, Vòi nước có lưới lọc cặn để nước rót ra sạch sẽ và tinh khiết hơn" +
                    "Người dùng dễ dàng tháo lắp lưới lọc cặn khi cần vệ sinh bình đun nước.Lưới lọc cặn giúp nước rót ra luôn sạch" +
                    "Hai cột hiển thị mực nước trong suốt ở cả hai bên thân bình tiện dụng Giúp đo lường nước đổ vào bình dễ dàng.Cửa sổ hiển thị mực nước trang bị 2 bên thân ấm Đế tiếp điện Strix cao cấp, hoạt động tốt, qay 360 độ Giúp bạn nhấc và đặt bình vào đế dễ dàng, tăng thêm sự thoải mái cho người sử dụng." +
                    " Lợi ích của việc sử dụng bình đun siêu tốc Dễ dàng nhấc ấm lên xuống Đế tiếp điện có ngăn chứa dây điện Tránh rối dây, vướng víu khi cần di chuyển hay cất giữ ấm đun.Dây điện được quấn gọn gàng vào chân đế Nhấn công tắc để nấu nước, khi bình bắt đầu đun đèn báo sẽ phát sáng Khi nước sôi, khi bình cạn nước hoặc nhấc bình khỏi đế tiếp điện thì bình đun siêu tốc sẽ tự động ngắt điện và đèn báo sẽ tắt. Nhờ đó, người dùng có thể yên tâm làm nhiều công việc khác trong khi nấu nước. " +
                    "electrolux-eek3505-1Mở nắp bình nhanh chóng bằng cách bấm nút trên tay cầm Người dùng dễ dàng châm nước và rót nước sôi một cách an toàn, nhẹ nhàng. Nút mở nắp trên tay cầm, dễ dàng rót nước bằng một tay Bình đun siêu tốc Electrolux 1.7 lít EEK3505 thiết kế sang trọng, đun nước hiệu quả, an toàn, sử dụng bền lâu.",
                    ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/binh-sieu-toc-electrolux-1-780x433.jpg",
                    quantity = 1000,
                    price = 312000,
                    WarrantyPeriod = 180,
                    CategoryID = 1,

                },
                 new Product
                 {
                     Id = 2,
                     Name = "Bình đun siêu tốc Delites 1.5 lít ST15S01",
                     Description = "Bình đun siêu tốc ST15S01 - Hàng ngon giá rẻ" +
                     "Dung tích bình cung cấp đủ nước nóng cho gia đình 2 - 3 người.Bạn có thể nhanh chóng nấu nước để nấu mì, pha trà, cà phê, hoặc pha sữa bất cứ khi nào cần." +
                     "Để đun nước, bạn chỉ cần một thao tác nhấn công tắc trên tay cầm. " +
                     "Tay cầm được thiết kế vừa vặn lòng bàn tay, làm bằng nhựa cách nhiệt, không gây bỏng cho người sử dụng." +
                     "Bình siêu tốc Delites ST15S01 – Công tắc đơn trên tay cầm\r\n\r\nĐế tiếp điện xoay 360 độ, tiện lợi khi di chuyển, bảo quản delites-st15s01-2 Đèn báo hiệu để người dùng dễ quan sát delites-st15s01-4 An toàn khi dùng delites-st15s01-1 Lưới lọc bã trà giúp nước ra sạch hơn Lưới lọc ST15S01. " +
                     "Bình siêu tốc Delites ST15S01 thiết kế đơn giản, tiện dụng, đun nước sôi nhanh, tiết kiệm thời gian, công sức cho người nội trợ. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/tq-780x433.jpg",
                     quantity = 1000,
                     price = 80000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 3,
                     Name = "Bình đun siêu tốc Delites 1.8 lít ST18S05",
                     Description = "Bình đun siêu tốc Delites kiểu dáng đơn giản, gọn đẹp, dễ dùng trong mọi không gian, Dung tích 1.8 lít phù hợp sử dụng tại gia đình, văn phòng nhỏ ít người..." +
                     "Chất liệu bình đun bằng inox 201 sáng bóng, bền tốt, nấu nước an toàn, hạn chế han gỉ, mới lâu, dễ làm sạch.Chất liệu inox cùng với mâm nhiệt rộng giúp bình làm nóng nhanh hơn, giữ nhiệt lâu, gia tăng hiệu quả sử dụng." +
                     "Bình có đèn báo hoạt động giúp người dùng tiện theo dõi khi đang đun nước.Đế xoay 360 độ dễ dàng đặt, nhấc bình lên xuống. Chế độ tự ngắt khi nước sôi hay khi bình cạn nước tránh cháy nổ, hư hại và bảo vệ an toàn cho người sử dụng." +
                     "Lưới lọc bã trà cho nước dùng sạch hơn, ngăn côn trùng gây hại xâm nhập vào bên trong bình.Bình đun siêu tốc Delites 1.8 lít ST18S05 sản phẩm đẹp, dùng tốt, đơn giản, tiện dụng cho nhu cầu của mọi gia đình.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/Tongquan-1-780x433.jpg",
                     quantity = 1000,
                     price = 195000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 4,
                     Name = "Bình đun siêu tốc Sunhouse 1.8 lít SHD1182",
                     Description = "Bình siêu tốc Sunhouse có tính năng tự ngắt khi nước sôi và khi cạn nước đảm bảo an toàn khi sử dụng" +
                     "Cung cấp đủ nước nóng cho gia đình có từ 4 - 6 thành viên với dung tích lớn 1.8 lít" +
                     "Thân bình sang trọng, đẹp mắt, vệ sinh dễ dàng sau khi dùng. Công suất lớn, mâm nhiệt phẳng to giúp đun nước nhanh sôi" +
                     "Bình siêu tốc Sunhouse 1.8 lít SHD1182 thiết kế gọn nhẹ, tiện di chuyển, công suất lớn, là vật dụng không thể thiếu cho gian bếp mọi nhà.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/tq-780x433.jpg",
                     quantity = 1000,
                     price = 200000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 5,
                     Name = "Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL",
                     Description = "Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL có kiểu dáng đơn giản, gọn đẹp, ruột bình làm từ inox 201 với công suất 1500W hoạt động ổn định, cùng với nhiều tiện ích và chế độ an toàn, đáp ứng tốt nhu cầu sử dụng nước nóng của mỗi gia đình trong việc pha trà, cà phê,..." +
                     "Thiết kế- Vỏ và ruột bình làm từ inox 201 bền đẹp, hạn chế gỉ sét, nấu nước an toàn, dễ dàng vệ sinh.- Thao tác đóng/mở nhẹ nhàng, thuận tiện với nút nhấn trên nắp bình, dễ dàng đổ nước vào và thuận tiện làm sạch.- Trang bị thang đo mực nước bên trong lòng bình, thuận tiện theo dõi lượng nước rót vào bình cho phù hợp với nhu cầu sử dụng. Mẫu bình đun siêu tốc Điện Quang này có thêm lưới lọc giúp ngăn chặn côn trùng xâm nhập và giữ lại phần bã trà để nước rót ra được sạch, trong trẻo.- Bình đun siêu tốc sử dụng đế tiếp điện Chaserr/Gutng hoạt động ổn định, cho tuổi thọ lên tới 5000 lần đun sôi.- Sử dụng gọn gàng, tiện lợi nhờ có rãnh cuốn dây điện bên dưới đế tiếp điện, tránh gây vướng víu." +
                     "Dung tích - Công suất - Công tắc- Bình đun có dung tích 1.8 lít, cung cấp đủ nước nóng cho những nhu cầu sử dụng hằng ngày trong gia đình hoặc văn phòng ít người.- Công suất 1500W hoạt động ổn định, đun nước sôi trong khoảng 7 phút, giúp tiết kiệm thời gian và điện năng tiêu thụ hiệu quả.- Đun nước dễ dàng chỉ với 1 nút nhấn tích hợp trên tay cầm, thao tác đơn giản, tiện lợi ngay cả người lớn tuổi cũng có thể sử dụng được, có đèn báo hoạt động." +
                     "Chế độ an toàn. Tự động ngắt điện khi nước sôi hoặc cạn nước, tráng gây lãng phí điện năng, hạn chế cháy nổ, đảm bảo an toàn khi sử dụng.Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL thiết kế đơn giản, nhỏ gọn dễ dùng, chất liệu an toàn, bền tốt, đến từ thương hiệu Việt uy tín - Điện Quang, là thiết bị nhà bếp hữu ích cho mọi gia đình.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654163373807.jpg",
                     quantity = 1000,
                     price = 200000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 6,
                     Name = "Bình đun siêu tốc Sunhouse 1.8 lít SHD1351 ",
                     Description = "Thiết kế dạng hình trụ gọn đẹp, màu xanh pastel trang nhã, chỉ có 1.07 kg, dễ dàng di chuyển và sử dụng ở mọi nơi" +
                     "Thân bình đun siêu tốc Sunhouse dày 2 lớp chất lượng tốt. Ruột bình làm bằng inox 304 hạn chế rỉ sét, an toàn cho sức khỏe. Trong khi vỏ bình bằng nhựa PP cho khả năng cách nhiệt tốt, giảm nguy cơ bị bỏng khi chạm vào bình lúc nước sôi.Chất liệu nhựa PP có đặc tính không mùi, không vị, không độc, độ bóng bề mặt cao, chịu nhiệt tốt nên được sử dụng rất phổ biến trong thiết kế đồ gia dụng, cho bạn an tâm khi sử dụng Sunhouse SHD1351." +
                     "Dung tích 1.8 lít đáp ứng tốt nhu cầu nước nóng pha chế đồ uống, nấu mì,... cho 2 - 4 người dùng" +
                     "Đèn báo hoạt động thiết kế ở thân bình, cho ánh sáng xanh bắt mắt, dễ quan sát quá trình đun" +
                     "Hướng dẫn sử dụng bình đun siêu tốc​:- Đổ nước vào bình đun siêu tốc không dưới mức MIN và quá mức MAX của cột hiển thị mực nước.- Đặt bình vào đế tiếp điện, kết nối phích cắm với ổ điện.- Nhấn nút công tắc ON/OFF để đun nước, khi đèn báo hiệu phát sáng thì bình đang đun.- 10 giây sau khi nước sôi bình sẽ tự ngắt điện, bạn cũng có thể chủ động ngắt điện khi nhấn vào nút ON/OFF.- Sau đó, bạn có thể nhấc bình ra khỏi đế tiếp điện và bắt đầu sử dụng tùy ý.Bình đun siêu tốc Sunhouse 1.8 lít SHD1351 của thương hiệu Việt Nam - Sunhouse, mẫu mã đẹp mắt, dung tích 1.8 lít, công suất 1500W, đế tiếp điện độ bền cao, đun nước an toàn, lựa chọn cho gia đình. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-1.jpg",
                     quantity = 1000,
                     price = 299000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 7,
                     Name = "Bình đun siêu tốc Sunhouse 1.8 lít SHD1353",
                     Description = "Bình đun siêu tốc kiểu dáng hình trụ hiện đại, màu xanh lá tông pastel trang nhã làm đẹp không gian sử dụng" +
                     "Bình đun siêu tốc Sunhouse thiết kế 2 lớp bền đẹp, sử dụng an toàn với chất liệu cao cấp.Ruột bình bằng inox 304 hạn chế gỉ sét tốt, an toàn sức khỏe, dễ làm sạch.Vỏ bình bằng nhựa PP cách nhiệt giúp giảm nguy cơ bị bỏng khi chạm vào bình lúc nước sôi. " +
                     "Dung tích 1.8 lít đáp ứng tốt nhu cầu nước nóng pha chế đồ uống, nấu mì,... cho 2 - 4 người dùng.Công suất 1500W đun sôi nước trong 4 - 6 phút " +
                     "Sử dụng bình đun siêu tốc bền bỉ:- Không mở nắp khi đang đun nước.- Châm nước theo vạch mức hướng dẫn trên thân bình, tránh châm nước quá đầy hay quá ít.- Không nên trữ nước thừa trong bình đun để phòng tránh rò rỉ nguy hiểm và tình trạng đóng cặn.- Cần vệ sinh bình đun thường xuyên để tránh đóng cặn.Bình đun siêu tốc Sunhouse 1.8 lít SHD1353 sang đẹp, công suất lớn nấu nước nhanh sôi, sử dụng bền bỉ, dung tích 1.8 lít đáp ứng tốt nhu cầu nước nóng cho 2 - 4 người dùng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(1).jpg",
                     quantity = 500,
                     price = 340000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 8,
                     Name = "Bình đun siêu tốc Sunhouse Mama 1.8 lít SHD1389 ",
                     Description = "Bình đun siêu tốc Sunhouse Mama 1.8 lít SHD1389 công suất 1850W đun nước sôi nhanh chóng, tiết kiệm thời gian, ruột bình bằng inox 304 an toàn cho sức khỏe, dung tích 1.8 lít phục vụ tốt cho nhu cầu dùng nước nóng thường nhật của gia đình. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923028275241.jpg",
                     quantity = 100,
                     price = 490000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 9,
                     Name = "Bình đun siêu tốc Bear 1.5 lít BEK-E153W2",
                     Description = "Bình đun siêu tốc Bear 1.5 lít BEK-E153W2 công suất 1500W đun nước sôi nhanh chóng, tiết kiệm thời gian, ruột bình bằng inox 304 an toàn cho sức khỏe, dung tích 1.5 lít phục vụ tốt cho nhu cầu dùng nước nóng thường nhật của gia đình. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-1.jpg",
                     quantity = 1000,
                     price = 350000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 10,
                     Name = "Bình đun siêu tốc Delites 1.8 lít ST18S04",
                     Description = "Bình đun siêu tốc Delites kiểu dáng đơn giản, chất liệu inox với viền nhựa đen tinh tế, dùng đẹp trong mọi không gian, từ nhà ở đến văn phòng, khách sạn, bệnh viện,… Dung tích 1.8 lít đủ dùng cho gia đình 3 – 4 người, pha trà, cà phê, nấu mì, pha nước tắm trẻ… nhanh gọn, tiện lợi.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/Untitled-1-780x433.jpg",
                     quantity = 1000,
                     price = 315000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 11,
                     Name = "Bình đun siêu tốc Toshiba 1.7 lít KT-17SH2NV",
                     Description = "Bình đun siêu tốc Toshiba 1.7 lít KT-17SH2NV, sản phẩm thương hiệu Nhật Bản uy tín, thiết kế đơn giản, dễ sử dụng. Đun nước sôi nhanh, tiết kiệm thời gian công sức cho người nội trợ.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/-tongquan.jpg",
                     quantity = 80,
                     price = 550000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 12,
                     Name = "Bình đun siêu tốc thủy tinh Sunhouse 1.7 lít SHD1217 Đen",
                     Description = "Bình đun siêu tốc Sunhouse thiết kế sang trọng, hiện đại, dung tích 1.7 lít cung cấp đủ nước nóng cho gia đình 3 - 4 thành viên sử dụng",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/Untitled-1-780x433.jpg",
                     quantity = 200,
                     price = 425000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },

                 new Product
                 {
                     Id = 13,
                     Name = "Bình đun siêu tốc Delites 1.8 lít ST18DB01 ",
                     Description = "Bình đun siêu tốc Delites kiểu dáng mềm mại, trang nhã, màu sắc rất nhẹ nhàng, tươi mát nhưng không kém phần ấn tượng, tạo cảm giác tươi mới cho không gian dùng. Dung tích 1.8 lít đủ dùng cho nhu cầu sử dụng gia đình 3 – 4 người: pha trà, cà phê, sữa, nấu mì, nấu nước tắm bé,… tiện dụng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/-45.jpg",
                     quantity = 1000,
                     price = 355000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 14,
                     Name = "Bình đun siêu tốc Sunhouse Mama 1.7 lít SHD1330",
                     Description = "Bình đun siêu tốc Sunhouse SHD1330 dung tích 1.7 lít, công suất lớn 1850W, có thể tự ngắt khi nước sôi, khi cạn nước hoặc quá nhiệt, có lưới lọc cặn an toàn,... đáp ứng tốt nhu cầu sử dụng nước nóng trong việc pha trà, cà phê, nấu mì,...",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/Tong-quan-1020x570.jpg",
                     quantity = 150,
                     price = 510000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 15,
                     Name = "Bình đun siêu tốc Delites 1.7 lít FD-625",
                     Description = "Bình đun nước siêu tốc Delites thiết kế đơn giản mà sang trọng và tinh tế, dung tích 1.7 lít dạng phổ thông dễ dùng tại gia đình, văn phòng nhỏ ít người,…",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/a3-780x433.png",
                     quantity = 1000,
                     price = 535000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 16,
                     Name = "Bình đun siêu tốc Sunhouse 1.7 lít SHD1382B",
                     Description = "Bình đun siêu tốc Sunhouse SHD1382B màu sắc nổi bật, hoa văn nhẹ nhàng, dễ dùng cho mọi không gian gia đình.Bình dung tích 1.7 lít đủ dùng cho nhu cầu sử dụng gia đình 3 – 4 người: pha trà, cà phê, sữa, nấu mì, nấu nước tắm cho bé,… tiện dụng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-binh-dun-sieu-toc-sunhouse-shd1382b.jpg",
                     quantity = 1000,
                     price = 499000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 17,
                     Name = "Bình đun siêu tốc Toshiba 1.7 lít KT-17DR1NV",
                     Description = "Bình đun siêu tốc Toshiba vỏ ngoài sáng bóng, kiểu dáng sang trọng, dung tích 1.7 lít sử dụng thuận tiện tại gia đình, văn phòng nhỏ,...Công suất 1800 - 2150W đun nước nhanh sôi, chỉ chờ 6 - 7 phút nước nóng đã sẵn sàng cho nhu cầu sử dụng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/a3-780x433.png",
                     quantity = 60,
                     price = 1115000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 18,
                     Name = "Bình đun siêu tốc BlueStone 1.7 lít KTB-3417",
                     Description = "Bình đun siêu tốc BlueStone màu đen sang trọng, dung tích 1.7 lít tiện dùng cho nhu cầu sử dụng thường nhật tại gia đình",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/B4-780x433.jpg",
                     quantity = 1000,
                     price = 449000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 19,
                     Name = "Bình đun siêu tốc Rapido 1.7 lít RK1717",
                     Description = "Bình đun siêu tốc Rapido 1.7 lít RK1717 màu xanh đen trung tính, sang trọng, bình có dung tích 1.7 lít, công suất 1700W, ruột bình chất liệu inox 304 bền bỉ, không gây hại khi đun sôi, giúp người dùng đun nước an toàn.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-1.jpg",
                     quantity = 1000,
                     price = 320000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 20,
                     Name = "Bình đun siêu tốc Toshiba 1.5 lít KT-15DS1NV",
                     Description = "Bình đun siêu tốc Toshiba màu đen mạnh mẽ, kết cấu chắc chắn, góp phần làm tăng tính thẩm mỹ cho gian bếp gia đình. Có dung tích 1.5 lít, tương đương với 8 ly nước, bình đun cung cấp đủ nước nóng mỗi ngày cho 1 người dùng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/-tong-quan.jpg",
                     quantity = 500,
                     price = 849000,
                     WarrantyPeriod = 180,
                     CategoryID = 1,

                 },
                 new Product
                 {
                     Id = 21,
                     Name = "Bếp từ đôi lắp âm Kangaroo KG855i",
                     Description = "Bếp từ Kangaroo sở hữu nhiều tính năng an toàn, đảm bảo yên tâm khi sử dụng:- Cảnh báo khi không có nồi trên bếp thông tin đến người dùng kịp thời xử lý.- Tính năng dừng bếp tạm thời khi bận rộn, khi kích hoạt lại bếp vẫn giữ nguyên chế độ đã cài đặt trước đó, tiết kiệm thời gian khởi động.- Tự ngắt khi bếp nóng quá tải bảo vệ động cơ, hạn chế các sự cố cháy nổ.- Tự ngắt khi không có nồi tránh lãng phí điện năng cho gia đình.- Tự nhận diện kích cỡ đáy nồi để phân bổ nhiệt lượng phù hợp.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516146987500.jpg",
                     quantity = 750,
                     price = 4990000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 22,
                     Name = "Bếp từ đôi lắp âm Hafele HC-I2712A (536.61.716)",
                     Description = "Bếp từ thương hiệu Hafele của Đức, sản xuất và nhập khẩu nguyên chiếc từ Malaysia đảm bảo chất lượng, mẫu mã",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/vi-vn-doi-hafele-hc-i2712a637983280837848266.jpg",
                     quantity = 1000,
                     price = 8990000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 23,
                     Name = "Bếp từ đôi lắp âm Hafele HC-I2732A",
                     Description = "Điểm qua những thông tin chung của bếp từ đôi Hafele HC-I2732A. Đây là sản phẩm thuộc dòng bếp từ đôi được thiết kế lắp âm hoặc lắp dương giúp sử dụng linh hoạt trong gian bếp. Đến từ thương hiệu 100 năm - Hafele (Đức), sản xuất và nhập khẩu nguyên chiếc từ Malaysia đảm bảo chất lượng, mẫu mã. Bếp từ sở hữu công suất tổng 4400W, mỗi vùng 2000W và có thể đạt 2200W khi sử dụng chức năng Booster gia nhiệt nhanh giúp rút ngắn thời gian đun sôi chất lỏng. Bếp được tích hợp bảng điều khiển cảm ứng trượt điều chỉnh linh hoạt 9 mức công suất chỉ với thao tác lướt nhẹ ngón tay. Đồng thời bếp từ Hafele được trang bị công nghệ Inverter tiết kiệm điện năng hiệu quả, giúp bếp hoạt động ổn định. Không thể bỏ qua chức năng hẹn giờ tắt bếp trong khoảng 1 - 99 phút giúp người dùng tiện nấu các món ninh, hầm mà không cần canh chừng tắt bếp. Ngoài ra bếp còn sở hữu những tính năng an toàn giúp người dùng an tâm sử dụng: khóa bảng điều khiển, cảnh báo mặt bếp nóng, tự nhận diện kích cỡ đáy nồi, dừng bếp tạm thời.\r\n\r\nNhìn chung, Hafele HC-I2732A sẽ là sự lựa chọn đáng tiền và hứa hẹn mang lại những trải nghiệm tích cực cho căn bếp gia đình. Lưu ý khi sử dụng bếp từ:- Chỉ sử dụng nồi/chảo có đáy nhiễm từ: inox 430, gang,... khi sử dụng bếp. Lưu ý: bếp phù hợp với nồi/chảo có đường kính đáy 12 - 26 cm.\r\n\r\nXem thêm: Những nồi sử dụng được trên bếp từ\r\n\r\n- Đảm bảo chỉ dùng bếp khi nguồn điện ổn định, điện áp không quá cao hoặc quá thấp. \r\n\r\n- Không sử dụng các vật sắc nhọn để cạy các vết bẩn bám trên mặt bếp, dễ gây trầy xước. - Nên dùng khăn vải mềm, miếng bọt biển khi làm sạch mặt bếp.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/vi-vn-hafele-hc-i2732a638277633375209456.jpg",
                     quantity = 1000,
                     price = 10900000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 24,
                     Name = "Bếp từ đôi lắp âm Pramie 2208",
                     Description = "Yên tâm về mẫu mã và chất lượng khi sản phẩm đến từ thương hiệu Pramie - Đức, sản xuất tại Malaysia",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/vi-vn-doi-pramie-2208-230721-04365710-copy-copy.jpg",
                     quantity = 1000,
                     price = 6890000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 25,
                     Name = "Bếp từ AVA AI-32",
                     Description = "Bếp từ AVA AI-32 thiết kế 1 vùng nấu gọn đẹp, dễ đặt ở nhiều nơi, công suất lớn 2000W nấu ăn nhanh, có 6 chế độ nấu cài đặt sẵn, bảng điều khiển cảm ứng hiện đại, dễ tùy chỉnh và sử dụng nấu ăn thuận tiện trong gia đình hằng ngày.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-2.jpg",
                     quantity = 1000,
                     price = 900000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 26,
                     Name = "Bếp từ đôi lắp âm Sunhouse SHB9111MT",
                     Description = "Bếp từ đôi Sunhouse thiết kế lắp âm hiện đại, có hai vùng nấu rộng rãi .Cho bạn chế biến được nhiều món ăn cùng lúc. Bạn có thể vừa nấu canh, vừa chiên xào thực phẩm một cách thoải mái và tiện lợi.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/doi-sunhouse-shb9111mt638017768064342909.jpg",
                     quantity = 1000,
                     price = 29990000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 27,
                     Name = "Bếp hồng ngoại Sunhouse SHD 6015(EMC)",
                     Description = "Bếp hồng ngoại đơn thiết kế hiện đại, màu sắc bắt mắt, nhỏ gọn thích hợp cho nhiều không gian dùng",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/vi-vn-sunhouse-shd-6015-o-780x433.jpg",
                     quantity = 1000,
                     price = 7490000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 28,
                     Name = "Bếp từ hồng ngoại lắp âm Hafele HC-H7321B",
                     Description = "Bếp từ hồng ngoại lắp âm Hafele HC-H7321B là sản phẩm mới ra mắt năm 2023, của thương hiệu Đức, được sản xuất tại Malaysia. Bếp có thiết kế tinh tế, hiện đại, được trang bị công nghệ Inverter, bảng điều khiển độc lập cho từng vùng nấu tiện lợi cùng nhiều tiện ích, chức năng an toàn khác.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/317824-1020x570.jpg",
                     quantity = 1000,
                     price = 890000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 29,
                     Name = "Bếp từ AVA FYM20-71",
                     Description = "Công suất tối đa 2000W có thể tùy chỉnh 10 mức linh hoạt theo món ăn",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/279571/ava-fym20-71-1.jpg",
                     quantity = 1000,
                     price = 990000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 30,
                     Name = "Bếp từ Galanz CH211E",
                     Description = "Bếp từ đơn gọn đẹp, mỏng, tiết kiệm không gian, phù hợp với những căn bếp có diện tích nhỏ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/galanz-ch211e-030821-0423500.jpg",
                     quantity = 1000,
                     price = 7990000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 31,
                     Name = "Bếp hồng ngoại Sanaky SNK-2524HGN",
                     Description = "Mặt bếp hồng ngoại bằng kính Ceramic - Kanger, dễ vệ sinh",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-be%CC%82%CC%81p-ho%CC%82%CC%80ng-ngoa%CC%A3i-sanaky-snk-2524hgn.jpg",
                     quantity = 1000,
                     price = 1390000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 32,
                     Name = "Bếp hồng ngoại Rapido RC2000ES",
                     Description = "Bếp hồng ngoại đơn thiết kế tinh tế, nhỏ gọn với 1 vùng nấu",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117060.jpg",
                     quantity = 1000,
                     price = 790000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 33,
                     Name = "Bếp hồng ngoại 3 vùng nấu lắp âm Hafele HC-R603D",
                     Description = "Bếp hồng ngoại thiết kế lắp đặt âm hiện đại, tiết kiệm không gian",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/BeptudoiTQ-780x433.jpg",
                     quantity = 1000,
                     price = 12390000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 34,
                     Name = "Bếp từ 4 vùng nấu lắp âm tích hợp hút mùi Bosch PVQ731F15E",
                     Description = "Bếp từ 4 vùng nấu lắp âm Bosch PVQ731F15E tích hợp tính năng hút mùi siêu tiện lợi, nhập khẩu từ Tây Ban Nha, có 4 vùng nấu giúp thuận tiện chế biến nhiều món ăn cùng lúc, có tính năng liên kết vùng nấu để tạo ra vùng nấu lớn, cùng các tiện ích: hẹn giờ, chức năng Booster làm nóng nhanh,... là thiết bị gia dụng hiện đại, bền tốt cho căn bếp gia đình.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-1-1.jpg",
                     quantity = 1000,
                     price = 44790000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 35,
                     Name = "Bếp từ 3 vùng nấu lắp âm Bosch PUJ611BB5E",
                     Description = "Yên tâm về mẫu mã và chất lượng khi sản phẩm đến từ thương hiệu Pramie - Đức, sản xuất tại Malaysia",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405789578258494.jpg",
                     quantity = 1000,
                     price = 11689000,
                     WarrantyPeriod = 720,
                     CategoryID = 2,

                 },
                 new Product
                 {
                     Id = 36,
                     Name = "Smart Tivi Samsung 4K 55 inch UA55AU7002",
                     Description = "Smart Tivi Samsung 4K 55 inch UA55AU7002 nâng tầm trải nghiệm xem với khung hình 4K sắc nét, bộ xử lý Crystal 4K cho màu sắc tái tạo sống động, các chi tiết rõ ràng nhờ công nghệ Contrast Enhancer, hệ điều hành Tizen OS 6.0 thân thiện, làm việc tại nhà thuận tiện cùng chế độ máy tính PC trên tivi.\r\n\r\n",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-1.jpg",
                     quantity = 1000,
                     price = 10400000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 37,
                     Name = "Google Tivi QLED TCL 4K 65 inch 65Q646",
                     Description = "Google Tivi QLED TCL 4K 65 inch 65Q646 sở hữu màn hình 65 inch độ phân giải 4K sắc nét. Trang bị các công nghệ hình ảnh và âm thanh nổi bật như Dolby Vision cho độ sáng vượt trội, hình ảnh chi tiết và trung thực, Micro Dimming kiểm soát đèn nền hay âm thanh vòm Dolby Atmos nâng cấp trải nghiệm nghe nhìn. Bên cạnh đó, tivi TCL được trang bị hệ điều hành Google TV với giao diện thân thiện, dễ sử dụng cùng kho ứng dụng phong phú.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-01.jpg",
                     quantity = 1000,
                     price = 11990000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 38,
                     Name = "Smart Tivi Samsung 4K Crystal UHD 55 inch UA55BU8000",
                     Description = "Smart Tivi Samsung 4K Crystal UHD 55 inch UA55BU8000 sở hữu thiết kế tinh tế, màn hình LED viền (Edge LED), VA LCD siêu mỏng đi cùng chất lượng hình ảnh 4K cực nét, công nghệ OTS Lite điều chỉnh âm thanh theo chuyển động của vật thể, hệ điều hành Tizen™ trực quan, thân thiện và vô số các tiện ích giải trí đi kèm chắc chắn đáp ứng nhu cầu giải trí cơ bản của gia đình bạn.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761440968453.jpg",
                     quantity = 1000,
                     price = 11690000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 39,
                     Name = "Smart Tivi LG 4K 65 inch 65UQ8000PSC",
                     Description = "Smart Tivi LG 4K 65 inch 65UQ8000PSC mang đến cảm xúc đắm chìm khi trải nghiệm nghe nhìn, với khung hình 4K tương phản rực rỡ từ HDR10 Pro, âm thanh chân thực tinh chỉnh theo nội dung qua AI Sound, cùng với 1 thiết kế tinh giản đầy sang chảnh, và kho ứng dụng khổng lồ từ webOS 22 đáp ứng hoàn hảo nhu cầu giải trí của người dùng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/smart-lg-4k-65-inch-65uq8000psc638043668474988583.jpg",
                     quantity = 1000,
                     price = 13490000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 40,
                     Name = "Smart Tivi Samsung 4K 43 inch UA43AU7002",
                     Description = "Smart Tivi Samsung 4K 43 inch UA43AU7002 tái tạo khung hình 4K sắc nét, chân thực và sống động nhờ bộ xử lý Crystal 4K, màu sắc rực rỡ cùng PurColor và âm thanh mạnh mẽ, sống động Q-Symphony, Adaptive Sound, mang đến trải nghiệm xem thích thú, cùng kho ứng dụng Tizen™ phong phú thỏa mãn khung giờ giải trí của mọi thành viên trong gia đình.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-1.jpg",
                     quantity = 1000,
                     price = 6990000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 41,
                     Name = "Smart Tivi QLED 4K 55 inch Samsung QA55Q60C",
                     Description = "Smart Tivi QLED 4K 55 inch Samsung QA55Q60C tinh giản trong thiết kế, khung hình 55 inch với độ phân giải 4K sắc nét, bộ xử lý Quantum 4K Lite, công nghệ OTS Lite mang đến trải nghiệm hình ảnh và âm thanh chân thật, hệ điều hành Tizen™ giao diện trực quan dễ sử dụng, tìm kiếm bằng giọng nói tiếng Việt, gọi video qua Google Duo,…",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-1.jpg",
                     quantity = 1000,
                     price = 14550000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 42,
                     Name = "Smart Tivi Samsung 4K 55 inch UA55CU8000",
                     Description = "Smart Tivi Samsung 4K 55 inch UA55CU8000 đem đến trải nghiệm tuyệt đỉnh nhờ màn hình 55 inch độ phân giải 4K với hơn 8 triệu điểm ảnh, khung hình sống động nhờ bộ vi xử lý Crystal 4K, âm thanh chuyển động theo hình ảnh OTS Lite, hệ điều hành Tizen™ đa nhiệm, dễ sử dụng cùng nhiều tiện ích thông minh khác.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-1.jpg",
                     quantity = 1000,
                     price = 13400000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 43,
                     Name = "Smart Tivi NanoCell LG 4K 65 inch 65NANO76SQA",
                     Description = "Smart Tivi NanoCell LG 4K 65 inch 65NANO76SQA cuốn hút tầm nhìn nhờ màn hình 65 inch thanh mảnh, nội dung hiển thị sắc nét với độ phân giải 4K, tối ưu qua bộ xử lý α5 Gen5 AI 4K, âm thanh sống động cùng công nghệ AI Sound, kho ứng dụng webOS 22 phong phú và điều khiển đầy thông minh qua Magic Remote, AI ThinQ mang đến trải nghiệm tuyệt vời.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-001.jpg",
                     quantity = 1000,
                     price = 13990000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 44,
                     Name = "Google Tivi TCL 43 inch 43S5400",
                     Description = "Google Tivi TCL 43 inch 43S5400 tái tạo hình ảnh chân thực với độ phân giải Full HD, công nghệ HDR10, khung hình có độ tương phản cao nhờ hỗ trợ công nghệ Micro Dimming, giả lập âm thanh vòm sống động với công nghệ Dolby Audio, hệ điều hành Google TV với kho ứng dụng đa dạng. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489860884025.jpg",
                     quantity = 1000,
                     price = 5890000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 45,
                     Name = "Smart Tivi QLED 4K 65 inch Samsung QA65Q60C",
                     Description = "Smart Tivi QLED 4K 65 inch Samsung QA65Q60C sở hữu thiết kế thanh lịch, cung cấp màn hình trải nghiệm tuyệt đẹp với độ phân giải 4K sắc nét, khung hình sống động nhờ bộ vi xử lý Quantum 4K Lite, tận hưởng trải nghiệm đắm chìm đa dạng tỷ lệ màn hình với Super Ultra Wide Game View & Game Bar, âm thanh chuyển động theo hình ảnh OTS Lite, hỗ trợ tìm kiếm bằng giọng nói tiếng Việt,… cùng nhiều tiện ích thông minh khác.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-01.jpg",
                     quantity = 1000,
                     price = 17800000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 46,
                     Name = "Google Tivi Sony 4K 43 inch KD-43X77L",
                     Description = "Google Tivi Sony 4K KD-43X77L có kích thước màn hình 43 inch, viền tivi được thiết kế mỏng, đen, giúp bạn dễ dàng tập trung vào màn hình, hình ảnh sắc nét chuẩn 4K với bộ xử lý hình ảnh chuẩn 4K kết hợp cùng với âm thanh vòm Dolby Audio cho bạn trải nghiệm xem phim đầy lôi cuốn.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/vi-vn-google-tivi-sony-4k-43-inch-kd-43x77l-01.jpg",
                     quantity = 1000,
                     price = 11090000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 47,
                     Name = "Google Tivi TCL 32 inch 32S5400",
                     Description = "Google Tivi TCL 32 inch 32S5400 có vẻ ngoài tối giản, kích thước nhỏ gọn phù hợp cho các không gian nhỏ hẹp, hiển thị khung hình giàu sắc thái, chi tiết nhờ công nghệ HDR10, HLG, hình ảnh rõ ràng, sống động với công nghệ Micro Dimming, công nghệ Dolby Audio cho trải nghiệm âm thanh sâu lắng, lôi cuốn, tìm kiếm bằng giọng nói tiếng Việt với remote tích hợp micro và Google Assistant.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490697986708.jpg",
                     quantity = 1000,
                     price = 3990000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 48,
                     Name = "Smart Tivi NanoCell LG 4K 55 inch 55NANO76SQA",
                     Description = "Smart Tivi NanoCell LG 4K 55 inch 55NANO76SQA, một tuyệt tác đến từ LG với thiết kế đơn giản, tinh tế, tái hiện sống động cuộc sống thực lên màn hình 4K trên dải màu Nano Color, tối ưu hiển thị và âm thanh nhờ bộ xử α5 Gen5 AI 4K, AI Sound Pro tinh chỉnh âm thanh lôi cuốn, cùng mang lại trải nghiệm nghe nhìn hoàn hảo trên các lựa chọn phong phú từ hệ điều hành WebOS 22.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-001-1020x570.jpg",
                     quantity = 1000,
                     price = 21090000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 49,
                     Name = "Smart Tivi Toshiba 43 inch 43V31MP",
                     Description = "Smart Tivi Toshiba 43 inch 43V31MP mang đến hình ảnh Full HD rõ đẹp, sống động với bộ xử lý Regza Engine HG, công nghệ Essential PQ tái tạo chi tiết, màu sắc trung thực, công nghệ Dolby Audio cho âm thanh vòm mạnh mẽ, hệ điều hành Vidaa U7 cùng thư viện ứng dụng đa dạng, dễ dàng sử dụng.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996430698528.jpg",
                     quantity = 1000,
                     price = 7350000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 50,
                     Name = "Smart Tivi Samsung 4K 65 inch UA65CU8000",
                     Description = "Smart Tivi Samsung 4K 65 inch UA65CU8000 sở hữu thiết kế trang nhã, tinh giản nhưng sang đẹp, màn hình UHD 4K cùng tấm nền VA LCD cho hình ảnh sắc nét, sống động với công nghệ Dynamic Crystal Color, bộ xử lý Crystal 4K hỗ trợ cải thiện màu sắc hiển thị kết hợp với tính năng chống nhiễu, tái tạo hình ảnh vượt trội.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-1.jpg",
                     quantity = 1000,
                     price = 14490000,
                     WarrantyPeriod = 720,
                     CategoryID = 3,

                 },
                 new Product
                 {
                     Id = 51,
                     Name = "Tủ lạnh Samsung Inverter 236 lít RT22M4032BY/SV",
                     Description = "",
                     ImageUrl = "",
                     quantity = 1000,
                     price = 6890000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 52,
                     Name = "Tủ lạnh Samsung Inverter 256 lít RT25M4032BU/SV",
                     Description = "Tủ lạnh Samsung Inverter 256 lít RT25M4032BU/SV được trang bị ngăn đông mềm -1 độ C Optimal Fresh Zone có tác dụng giữ thực phẩm tươi sống còn trọn dưỡng chất, hoàn toàn không đông đá ở nhiệt độ đông mềm lý tưởng -1°C. Như thế, thịt cá hoàn toàn không bị đông đá giúp bạn có thể nấu ăn ngay không cần rã đông, dễ dàng cắt thái và chế biến trong ngày.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/samsung-rt25m4032bu-sv-140821-0914220.png",
                     quantity = 1000,
                     price = 6890000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 53,
                     Name = "Tủ lạnh Aqua 130 lít AQR-T150FA(BS)",
                     Description = "Công nghệ Nano Fresh Ag+ ứng dụng tính chất của các ion Ag+, giúp diệt khuẩn và ngăn ngừa sự phát triển của vi khuẩn nấm mốc, giữ bầu không khí luôn sạch khuẩn và thoáng mát. Với sự hỗ trợ này, chúng ta có thể thoải mái lưu trữ thực phẩm cho gia đình nhiều ngày mà không phải lo đến việc ám mùi. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-210821-1005140.jpg",
                     quantity = 1000,
                     price = 4590000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 54,
                     Name = "Tủ lạnh Aqua Inverter 189 lít AQR-T220FA(FB)",
                     Description = "Tủ lạnh Aqua Inverter 189 lít AQR-T220FA(FB) có khả năng làm lạnh đa chiều, giúp bảo quản thực phẩm tối ưu, giảm thiểu tỷ lệ hư hỏng. Ngoài ra, tủ lạnh cũng mang lại hiệu quả tiết kiệm điện nhờ sử dụng công nghệ Twin Inverter.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798785782753.jpg",
                     quantity = 1000,
                     price = 5090000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 55,
                     Name = "Tủ lạnh Toshiba Inverter 180 lít GR-B22VU UKG ",
                     Description = "Với kiểu tủ ngăn đá trên, chiếc tủ lạnh Toshiba Inverter 180 lít GR-B22VU UKG được thiết kế nhỏ gọn nhưng vẫn toát lên vẻ đẹp hiện đại bởi tông màu đen tuyền sang trọng. Dễ dàng đặt ở bất kì vị trí nào trong nhà, từ phòng khách đến phòng bếp.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/1-1020x570.jpg",
                     quantity = 1000,
                     price = 4990000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 56,
                     Name = "Tủ lạnh Panasonic Inverter 170 lít NR-BA190PPVN",
                     Description = "Tủ lạnh Panasonic Inverter 170 lít NR-BA190PPVN sử dụng công nghệ biến tần Inverter có khả năng điều chỉnh vòng quay của máy nén giúp duy trì làm lạnh ổn định, hoạt động êm ái, ít gây tiếng ồn hơn và tiết kiệm được điện năng hiệu quả. ",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/panasonic-nr-ba190ppvn-150821-0310380.jpg",
                     quantity = 1000,
                     price = 6790000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 57,
                     Name = "Tủ lạnh LG Inverter 217 Lít GV-B212WB",
                     Description = "Tủ lạnh LG Inverter 217 Lít GV-B212WB có khả năng tiết kiệm điện và duy trì nhiệt độ ổn định giúp thực phẩm luôn tươi ngon. Hơn nữa, tủ lạnh còn có thể làm lạnh nhanh và duy trì các loại đồ uống ở vị trí cánh cửa tủ một cách tối ưu.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb1.jpg",
                     quantity = 1000,
                     price = 5590000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 58,
                     Name = "Tủ lạnh Samsung Inverter 382 lít RT38CG6584B1SV",
                     Description = "Tủ lạnh Samsung Inverter 382 lít RT38CG6584B1SV được trang bị ngăn đông mềm linh hoạt 4 chế độ Optimal Fresh+ chế biến thực phẩm không cần rã đông, mở rộng không gian bảo quản thực phẩm thêm 20 lít với công nghệ SpaceMax, giảm hao phí điện năng với công nghệ Digital Inverter, hệ thống lọc diệt khuẩn Active Fresh Filter khử khuẩn, ngăn mùi hôi trong tủ, chế độ làm lạnh nhanh Power Cool cùng công nghệ làm lạnh vòm All-around Cooling giữ được độ tươi ngon của thực phẩm.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-1.jpg",
                     quantity = 1000,
                     price = 14390000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 59,
                     Name = "Tủ lạnh Samsung Inverter 208 lít RT20HAR8DBU/SV",
                     Description = "Bộ lọc than hoạt tính Deodorizer trên tủ lạnh Samsung Inverter 208 lít RT20HAR8DBU/SV giúp loại bỏ hoàn toàn những mùi hôi khó chịu, các nấm mốc và vi khuẩn phát sinh bên trong tủ, để không khí trong tủ lạnh luôn tươi mát và thực phẩm trọn vị tươi ngon.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/samsung-rt20har8dbu-sv-140821-0959250.jpg",
                     quantity = 1000,
                     price = 6290000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 60,
                     Name = "Tủ lạnh Samsung Inverter 280 lít RB27N4010BU/SV",
                     Description = "Tủ lạnh Samsung Inverter 280 lít RB27N4010BU/SV được thiết kế theo phong cách châu Âu, tối giản chi tiết mang lại sự thanh nhã, giúp cho không gian bếp của bạn có một dấu ấn riêng. Chất liệu cửa tủ là kim loại phủ sơn bóng giả gương làm nổi bật, tôn lên vẻ sang trọng cho tổng thể.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/1-1020x570-1020x570.jpg",
                     quantity = 1000,
                     price = 9290000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 61,
                     Name = "Tủ lạnh LG Inverter 519 lít Side By Side GR-B256JDS",
                     Description = "Tủ lạnh LG Inverter 519 lít GR-B256JDS thuộc dòng tủ lạnh side by side được trang bị công nghệ Smart Inverter giúp tiết kiệm điện năng. Bên cạnh đó, công nghệ làm lạnh đa chiều mang hơi lạnh lan tỏa khắp các ngăn.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667253103233.jpg",
                     quantity = 1000,
                     price = 14990000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 62,
                     Name = "Tủ lạnh Aqua Inverter 456 lít Multi Door AQR-M525XA(FB)",
                     Description = "Tủ lạnh Aqua Inverter 456 lít AQR-M525XA(FB) thiết kế có thể bảo quản thực phẩm khô và ẩm riêng biệt nhờ công nghệ cân bằng độ ẩm HCS, giúp duy trì được độ tươi ngon cũng như kéo dài thời gian bảo quản thực phẩm lâu hơn. Chưa hết, tủ lạnh này còn có khả năng tiết kiệm điện và khử mùi hôi tối ưu.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007604187206283.jpg",
                     quantity = 1000,
                     price = 14990000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 63,
                     Name = "Tủ lạnh Toshiba Inverter 460 lít Side By Side GR-RS600WI-PMV(37)-SG",
                     Description = "Tủ lạnh Toshiba Inverter 460 lít GR-RS600WI-PMV(37)-SG có khả năng kết nối mạng, giúp người dùng điều khiển và kiểm soát tủ lạnh từ xa một cách thuận tiện qua ứng dụng trên điện thoại. Không những thế, tủ lạnh Toshiba 460 lít còn cho khả năng làm lạnh nhanh chóng và đều, giúp bảo quản thực phẩm được tốt hơn.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760502471984.jpg",
                     quantity = 1000,
                     price = 11490000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 64,
                     Name = "Tủ lạnh Aqua Inverter 347 lít AQR-T400FA(WFB)",
                     Description = "Tủ lạnh Aqua Inverter 347 lít AQR-T400FA(WFB) được thiết kế màu đen ánh kim sang trọng, có trang bị ngăn lấy nước bên ngoài tiện lợi. Hơn nữa, tủ lạnh còn được trang bị ngăn đông mềm Magic Zone -3°C, giúp duy trì độ tươi ngon và dưỡng chất của thực phẩm tối ưu, thậm chí có thể chế biến thực phẩm nhanh chóng mà không cần chờ rã đông.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404751829339.jpg",
                     quantity = 1000,
                     price = 9290000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                 new Product
                 {
                     Id = 65,
                     Name = "Tủ lạnh Aqua Inverter 279 lít AQR-T300FA(WFB)",
                     Description = "Tủ lạnh Aqua Inverter 279 lít AQR-T300FA(WFB) thiết kế màu đen sang trọng, công nghệ làm lạnh đa chiều giữ thực phẩm tươi lâu hơn, công nghệ làm lạnh gián tiếp giúp thực phẩm trong tủ không bị đóng tuyết, giữ thực phẩm tươi ngon. Ngoài ra, công nghệ Twin Inverter giúp tủ lạnh tiết kiệm điện năng hiệu quả.",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343059097613.jpg",
                     quantity = 1000,
                     price = 7690000,
                     WarrantyPeriod = 720,
                     CategoryID = 4,

                 },
                  new Product
                  {
                      Id = 66,
                      Name = "Máy giặt Sharp 7.5 Kg ES-Y75HV-S",
                      Description = "Máy giặt Sharp 7.5 kg ES-Y75HV-S có khối lượng giặt 7.5 kg phù hợp với gia đình có 2 - 3 thành viên, được trang bị 4 chương trình giặt đáp ứng được nhu cầu giặt giũ cơ bản của gia đình.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/6-1020x570.jpg",
                      quantity = 1000,
                      price = 3690000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 67,
                      Name = "Máy giặt Samsung Inverter 9 kg WW90T3040WW/SV",
                      Description = "Máy giặt Samsung Inverter 9 kg WW90T3040WW/SV tích hợp công nghệ giặt nước nóng Hot Wash giúp dễ dàng đánh bay các vết bẩn cứng đầu khó loại bỏ, đồng thời giúp diệt khuẩn, ngừa dị ứng, cùng các tiện ích đi kèm khác.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618083819165.jpg",
                      quantity = 1000,
                      price = 6490000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 68,
                      Name = "Máy giặt Panasonic Inverter 9.5 Kg NA-FD95V1BRV",
                      Description = "Máy giặt Panasonic Inverter 9.5 Kg NA-FD95V1BRV được tích hợp công nghệ nước nóng StainMaster+ có khả năng xử lý các vết bẩn hiệu quả với nhiệt độ nước thích hợp, loại bỏ các vi khuẩn gây hại giúp bảo vệ làn da tốt hơn, đồng thời còn giúp đánh bật các vết bẩn cứng đầu dễ dàng nhờ các chương trình giặt chuyên biệt.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-tong-quan-panasonic-na-fd95v1brv-1.jpg",
                      quantity = 1000,
                      price = 10690000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 69,
                      Name = "Máy giặt Samsung Inverter 8kg WW80T3020WW/SV",
                      Description = "Máy giặt được trang bị động cơ Digital Inverter với nam châm vĩnh cửu, giảm tối đa ma sát khi máy giặt vận hành, giúp tiết kiệm điện năng, vận hành êm ái hơn so với động cơ thông thường sử dụng chổi than. Đặc biệt, động cơ Digital Inverter có độ bền vượt trội và được bảo hành đến 11 năm.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-01.jpg",
                      quantity = 1000,
                      price = 4990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 70,
                      Name = "Máy giặt Toshiba 7 Kg AW-L805AV (SG)",
                      Description = "Máy giặt Toshiba 7 Kg AW-L805AV (SG) có màu xám bạc vừa toát lên vẻ sang trọng, hiện đại vừa đảm bảo vệ sinh hơn trong quá trình sử dụng. ",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-2-1020x570.jpg",
                      quantity = 1000,
                      price = 3990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 71,
                      Name = "Máy giặt Samsung Inverter 12 kg WA12CG5745BVSV",
                      Description = "Máy giặt Samsung Inverter 12 kg WA12CG5745BVSV có khả năng đánh bay vết bẩn cứng đầu hiệu quả nhờ công nghệ giặt bong bóng siêu mịn Eco Bubble, công nghệ Digital Inverter tiết kiệm điện năng, vận hành êm ái, giặt sạch siêu tốc 29 phút đảm bảo hiệu quả sạch sâu.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204008922288.jpg",
                      quantity = 1000,
                      price = 8990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 72,
                      Name = "Máy giặt Panasonic Inverter 10.5 Kg NA-FD10VR1BV",
                      Description = "Máy giặt Panasonic Inverter 10.5 Kg NA-FD10VR1BV tích hợp công nghệ giặt nước nóng StainMaster Plus với nhiệt độ nước giặt có thể lên đến 60 độ C, máy giặt có công nghệ giặt nước nóng này không chỉ đánh bay các vết bẩn cứng đầu như: Bùn đất, dầu mỡ, nước sốt,... mà còn có thể tiêu diệt các loại vi khuẩn và tác nhân gây dị ứng có trên quần áo, bảo vệ sức khỏe cho cả gia đình bạn.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/tong-quan-panasonic-na-fd10vr1bv-1-1020x570.jpg",
                      quantity = 1000,
                      price = 12090000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 73,
                      Name = "Máy giặt Aqua 8.8 KG AQW-FR88GT.BK",
                      Description = "Với kháng sinh kháng khuẩn ABT, mâm giặt được phun một dung dịch đặc biệt, kháng khuẩn đến 99,99% và ngăn nấm mốc phát triển bên trong lồng giặt. Bảo vệ sức khỏe toàn diện cho người sử dụng. Sản phẩm thích hợp cho các gia đình có con nhỏ, người dễ bị kích ứng với vi khuẩn, bụi bẩn.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/242732/Slider/1-1020x570-1.jpg",
                      quantity = 1000,
                      price = 5990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 74,
                      Name = "Máy giặt Samsung Inverter 14 kg WA14CG5745BVSV",
                      Description = "Máy giặt Samsung Inverter 14kg WA14CG5745BVSV có khả năng đánh bay vết bẩn cứng đầu hiệu quả nhờ công nghệ giặt bong bóng siêu mịn Eco Bubble, công nghệ Digital Inverter tiết kiệm điện năng vận hành êm ái, giặt sạch siêu tốc 29 phút đảm bảo hiệu quả sạch sâu.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800871763098-1020x570.jpg",
                      quantity = 1000,
                      price = 10090000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 75,
                      Name = "Máy giặt Electrolux UltimateCare 100 Inverter 9 kg EWF9025DQWB",
                      Description = "Máy giặt Electrolux UltimateCare 100 Inverter 9 kg EWF9025DQWB có khả năng tiết kiệm điện nhờ sử dụng công nghệ Inverter. Hơn nữa, máy giặt còn giảm thiểu tác nhân gây dị ứng trên làn da người với công nghệ giặt nước nóng và công nghệ giặt hơi nước tiện lợi.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb1.jpg",
                      quantity = 1000,
                      price = 7990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 76,
                      Name = "Máy giặt Aqua Inverter 9 kg AQD- D902G BK",
                      Description = "Máy giặt Aqua Inverter 9 kg AQD- D902G BK sở hữu động cơ truyền động trực tiếp DD Inverter giúp máy vận hành êm ái và tiết kiệm điện năng. Chương trình giặt thông minh AI tự động cân chỉnh lượng nước và thời gian dựa trên khối lượng giặt giúp tối ưu chu trình giặt giũ.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/01-1020x571.jpg",
                      quantity = 1000,
                      price = 6990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 77,
                      Name = "Máy giặt LG TurboDrum Inverter 9 kg T2109VSAB",
                      Description = "Máy giặt LG TurboDrum Inverter 9 kg T2109VSAB thuộc kiểu máy giặt lồng đứng cùng với bảng điều khiển nằm ở phía trước quen thuộc, chất liệu vỏ máy được làm bằng kim loại sơn tĩnh điện bền bỉ và giảm thiểu tình trạng trầy xước trong quá trình sử dụng. ",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/may-giat-lg-t2109vsab637679232549430455.jpg",
                      quantity = 1000,
                      price = 5990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 78,
                      Name = "Máy giặt Samsung AI Inverter 9kg WW90TP44DSB/SV",
                      Description = "Máy giặt Samsung AI Inverter 9 kg WW90TP44DSB/SV ứng dụng công nghệ AI Wash hiện đại với 4 cảm biến có thể cảm nhận khối lượng và độ bẩn áo quần, từ đó tối ưu lượng nước, lượng nước giặt, nước xả và thời gian giặt sao cho giặt sạch hiệu quả mà không tốn nhiều công sức.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/01-1020x570.jpg",
                      quantity = 1000,
                      price = 9490000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 79,
                      Name = "Máy giặt Casper 7.5 kg WT-75NG1 ",
                      Description = "Máy giặt Casper 7.5 kg WT-75NG1 có khả năng tiết kiệm điện và nước hiệu quả nhờ tích hợp công nghệ suy luận ảo Fuzzy Logic hiện đại. Không những thế, mẫu máy giặt Casper này còn lần đầu tiên được trang bị chế độ sấy gió AirDry, giúp rút ngắn thời gian phơi quần áo đáng kể.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638356597640417536.png",
                      quantity = 1000,
                      price = 3990000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 80,
                      Name = "Máy giặt Aqua Inverter 9.5 kg AQD-A952J BK",
                      Description = "Máy giặt Aqua Inverter 9.5 kg AQD-A952J BK được thiết kế theo kiểu dáng máy giặt lồng ngang hiện đại, được trang bị công nghệ cân bằng AI DBT giúp máy hoạt động ổn định, êm ái, tăng thêm không gian sống cho gia đình bởi kết cấu máy siêu mỏng, tiết kiệm diện tích. ",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpg",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 80,
                      Name = "Máy giặt Aqua Inverter 9.5 kg AQD-A952J BK",
                      Description = "Máy giặt Aqua Inverter 9.5 kg AQD-A952J BK được thiết kế theo kiểu dáng máy giặt lồng ngang hiện đại, được trang bị công nghệ cân bằng AI DBT giúp máy hoạt động ổn định, êm ái, tăng thêm không gian sống cho gia đình bởi kết cấu máy siêu mỏng, tiết kiệm diện tích. ",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpg",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 5,

                  },
                  new Product
                  {
                      Id = 81,
                      Name = "Nồi cơm điện cao tần Sunhouse 1.5 lít SHD8955",
                      Description = "Nồi cơm điện cao tần Sunhouse kiểu dáng đơn giản, chắc chắn, lớp vỏ sáng bóng tạo nên nét sang trọng riêng của một nồi cơm điện tử",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/131925/sunhouse-mama-shd8955-0-600x600.jpg",
                      quantity = 1000,
                      price = 1890000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 82,
                      Name = "Nồi cơm điện tử Sharp 1.8 lít KS-COM183MV-WH",
                      Description = "Nồi cơm điện tử Sharp 1.8 lít KS-COM183MV-WH với nhiều chế độ cài sẵn, công nghệ nhiệt 3D nấu cơm ngon, hẹn giờ đến 24 giờ, bảng điều khiển tiếng Việt dễ hiểu,... là công cụ đắc lực trong căn bếp gia đình.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/296809/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh-021122-102925-600x600.jpg",
                      quantity = 1000,
                      price = 990000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 83,
                      Name = "Nồi cơm nắp gài Sunhouse 1.8 lít SHD 8661",
                      Description = "Nồi cơm điện Sunhouse Mama có kiểu dáng thon gọn, màu đỏ trắng nổi bật, vỏ nồi bóng loáng, sang trọng tăng tính thẩm mỹ cho mọi không gian",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/72067/sunhouse-mama-shd-8661-220923-113258-600x600.jpg",
                      quantity = 1000,
                      price = 1440000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 84,
                      Name = "Nồi cơm nắp gài Delites 1.8 lít NCG1805",
                      Description = "Nồi cơm điện Delites với mẫu mã trẻ trung rất phù hợp nhiều sở thích người dùng",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/152969/delites-ncg1805-250823-101131-600x600.jpg",
                      quantity = 1000,
                      price = 400000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 85,
                      Name = "Nồi cơm nắp gài BlueStone 1.8 lít RCB-5520",
                      Description = "Nồi cơm điện nắp gài BlueStone 1.8 lít RCB-5520 trang bị công nghệ 1D nấu cơm chín nhanh, lòng nồi hợp kim nhôm phủ chống dính bền tốt, điều chỉnh bằng nút gạt dễ sử dụng,... là sản phẩm tiện lợi hỗ trợ chế biến những bữa cơm thơm ngon cho gia đình.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/189688/bluestone-rcb-5520-050124-113008-600x600.jpg",
                      quantity = 1000,
                      price = 700000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 86,
                      Name = "Nồi cơm nắp gài Sunhouse 1 lít SHD8208C",
                      Description = "Nồi cơm nắp gài Sunhouse 1 lít SHD8208C kiểu dáng nhỏ gọn, thanh lịch, màu sắc tươi sáng",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/203417/Slider/Untitled-1-780x433-1a-780x433.jpg",
                      quantity = 1000,
                      price = 490000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 87,
                      Name = "Nồi cơm nắp rời Delites 1.5 lít NCR1502",
                      Description = "Nồi cơm điện Delites NCR1502 màu sắc hiện đại, sang trọng, kiểu dáng trẻ trung bắt mắt, sản phẩm đẹp cho không gian dùng thêm đẹp\r\n",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/no%CC%82%CC%80i6-780x433a-780x433.jpg",
                      quantity = 1000,
                      price = 349000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 88,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 89,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 90,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 91,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 92,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 93,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 94,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 95,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 80,
                      Name = "",
                      Description = " ",
                      ImageUrl = "",
                      quantity = 1000,
                      price = 7690000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  }






                );
        }
    }
}
