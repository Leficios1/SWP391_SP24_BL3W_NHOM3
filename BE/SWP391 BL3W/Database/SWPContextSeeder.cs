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
                     Description = "Thịt cá tươi ngon, ăn trong ngày không cần rã đông với ngăn đông mềm -1 độ C Optimal Fresh Zone",
                     ImageUrl = "https://cdn.tgdd.vn/Products/Images/1943/220325/TimerThumb/Frame-1-600x600.png ",
                     quantity = 1000,
                     price = 5990000,
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
                      Name = "Máy    Sharp 7.5 Kg ES-Y75HV-S",
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
                      Name = "Nồi cơm nắp gài Sunhouse 1.2 lít SHD8217W",
                      Description = "Nồi cơm nắp gài Sunhouse 1.2 lít SHD8217W thiết kế gọn nhẹ, điều chỉnh bằng nút gạt đơn giản, công nghệ 1D nấu cơm chín nhanh, giúp phục vụ những bữa cơm nóng hổi cho gia đình.",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/275584/Slider/vi-vn-sunhouse-12-lit-shd8217w-1.jpg",
                      quantity = 1000,
                      price = 540000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 89,
                      Name = "Nồi cơm nắp rời Delites 1.8 lít RC-10W003",
                      Description = "Nồi cơm điện Delites sang trọng với vỏ kim loại phủ màu nâu đồng bắt mắt, sang trọng, tạo điểm nhấn trong không gian dùng\r\n",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-noi-com-nap-roi-delites-18-lit-rc-10w003a-780x433-a-780x433.jpg",
                      quantity = 1000,
                      price = 430000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 90,
                      Name = "Nồi cơm nắp gài Toshiba 1 lít RC-10JH2PV(B)",
                      Description = "Nồi cơm điện có dung tích 1 lít thích hợp để nấu cơm cho 2 - 4 người dùng",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/Untitled-1-780x433(8)-a-780x433.jpg",
                      quantity = 1000,
                      price = 550000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 91,
                      Name = "Nồi cơm nắp gài AVA 1 lít JRC-100P",
                      Description = "Nồi cơm điện nắp gài thiết kế màu sắc nhã nhặn, kiểu dáng sang trọng phù hợp với mọi gian bếp trong gia đình",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928470.jpg",
                      quantity = 1000,
                      price = 490000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 92,
                      Name = "Nồi cơm điện tử Toshiba 1.8 lít RC-18NMFVN(WT)",
                      Description = "Nồi cơm điện Toshiba RC-18NMFVN(WT) thiết kế chắc chắn, màu trắng sang trọng",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/92601/toshiba-rc-18nmfvn-wt-250823-102810-600x600.jpg",
                      quantity = 1000,
                      price = 2890000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 93,
                      Name = "Nồi cơm nắp gài Toshiba 1.8 lít RC-18JH2PV(B)",
                      Description = "Nồi cơm nắp gài Toshiba 1.8 lít RC-18JH2PV(B) thiết kế hiện đại, màu sắc trẻ trung phù hợp mọi căn bếp",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/noi-com-nap-gai-toshiba-rc-18jh2pv-b-18l637834603189310546.jpg",
                      quantity = 1000,
                      price = 650000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 94,
                      Name = "Nồi cơm điện tử Sunhouse mama 1.8 lít SHD8903 ",
                      Description = "Nồi cơm điện Sunhouse mama SHD8903 thiết kế gọn gàng, vỏ nồi bằng thép không gỉ bóng đẹp, bắt mắt, có tính thẩm mỹ cao",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/131916/sunhouse-mama-shd8903-thumb-600x600-2.jpg",
                      quantity = 1000,
                      price = 1290000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                  new Product
                  {
                      Id = 95,
                      Name = "Nồi cơm điện tử Toshiba 1.8 lít RC-18DR2PV(K)",
                      Description = "Nồi cơm điện tử Toshiba 1.8 lít RC-18DR2PV(K) thiết kế quai xách dễ cầm, màu sắc sang trọng với dung tích phù hợp cho gia đình 4 - 6 người",
                      ImageUrl = "https://cdn.tgdd.vn/Products/Images/1922/220499/noi-com-dien-tu-toshiba-rc-18dr2pv-k-18l-thumb-600x600-1.jpg",
                      quantity = 1000,
                      price = 2290000,
                      WarrantyPeriod = 720,
                      CategoryID = 6,

                  },
                   new Product
                   {
                       Id = 96,
                       Name = "Loa kéo Karaoke Dalton TS-15G600X 600W",
                       Description = "Loa kéo Karaoke Dalton TS-15G600X 600W có thiết kế đẹp mắt với tông màu đen chủ đạo mạnh mẽ phù hợp với nhiều không gian. Thân loa karaoke làm bằng gỗ cao cấp cho chất âm tốt hơn cũng như tạo sự sang trọng cho loa.\r\n\r\n",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/214631/dalton-ts-15g600x-270223-020348-600x600.jpg",
                       quantity = 1000,
                       price = 7690000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 97,
                       Name = "Loa kéo Nanomax S-820",
                       Description = "Mang tiệc tùng trở nên sống động với loa di động Nanomax S-820. Với công suất âm thanh mạnh mẽ lên đến 400W, kết nối Bluetooth và thiết kế dễ mang đi, loa này hoàn hảo cho các buổi hát karaoke hoặc các sự kiện ngoài trời.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/278796/loa-keo-karaoke-nanomax-s-820-400w-270223-021529-600x600.jpg",
                       quantity = 1000,
                       price = 3770000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 98,
                       Name = "Loa kéo Nanomax X-2000",
                       Description = "Nâng cao trải nghiệm âm thanh của bạn với loa karaoke Nanomax X-2000. Với thiết kế mạnh mẽ và công suất lên đến 1000W, loa này mang đến âm thanh rõ ràng cho các bữa tiệc, sự kiện hoặc các buổi biểu diễn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/308043/loa-karaoke-nanomax-x-2000-010623-041107-600x600.jpg",
                       quantity = 1000,
                       price = 7890000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 99,
                       Name = "Loa kéo Mobell MK-2120C",
                       Description = "Kích động đám đông với loa karaoke di động Mobell MK-2120C. Với kích thước nhỏ gọn và âm thanh mạnh mẽ lên đến 30W, loa này lý tưởng cho các buổi tụ tập nhỏ, buổi hát karaoke hoặc các chuyến phiêu lưu ngoài trời.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/236681/loa-keo-karaoke-mobell-mk-2120c-30w-040723-111711-600x600.jpg",
                       quantity = 1000,
                       price = 1440000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 100,
                       Name = "Loa kéo Dalton TS-12G350N",
                       Description = "Trải nghiệm chất lượng âm thanh cao cấp với loa karaoke Dalton TS-12G350N. Với công suất 350W và thiết kế bền bỉ, loa này được thiết kế để mang lại hiệu suất âm thanh xuất sắc cho các buổi tiệc karaoke hoặc sự kiện.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/306932/loa-keo-karaoke-dalton-ts-12g350n-100523-094658-600x600.jpg",
                       quantity = 1000,
                       price = 5160000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 101,
                       Name = "Loa kéo Dalton TS-18G850X",
                       Description = "Đưa trải nghiệm âm thanh của bạn lên một tầm cao mới với loa karaoke Dalton TS-18G850X. Với công suất 850W đáng kinh ngạc và âm thanh chuyên nghiệp, loa này hoàn hảo cho các DJ, người biểu diễn hoặc bất kỳ ai đòi hỏi chất lượng âm thanh hàng đầu.    ",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/214636/dalton-ts-18g850x-270223-020450-600x600.jpg",
                       quantity = 1000,
                       price = 9590000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 102,
                       Name = "Loa kéo Nanomax S-1000",
                       Description = "Tạo ấn tượng với loa karaoke di động Nanomax S-1000. Với công suất 1000W và thiết kế sang trọng, loa này mang đến âm thanh rõ ràng, động đạc cho các buổi karaoke, tiệc hoặc sự kiện của bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/226094/nanomax-s-1000-270223-020825-600x600.jpg",
                       quantity = 1000,
                       price = 5390000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 103,
                       Name = "Loa kéo Nanomax S-5000",
                       Description = "Sẵn sàng để làm náo động buổi tiệc với loa karaoke Nanomax S-5000. Với công suất khủng lên đến 5000W và các tính năng tiên tiến, loa này hoàn hảo cho các buổi tụ tập lớn, sự kiện hoặc các buổi biểu diễn chuyên nghiệp.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/297489/loa-karaoke-nanomax-s-5000-270223-022010-600x600.jpg",
                       quantity = 1000,
                       price = 9350000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 104,
                       Name = "Loa điện Dalton TS-18A8500",
                       Description = "Trải nghiệm chất lượng âm thanh không giới hạn với loa karaoke điện Dalton TS-18A8500. Với công suất 18.500W ấn tượng và các linh kiện cao cấp, loa này được thiết kế để mang lại âm thanh sâu lắng cho các buổi hòa nhạc, sự kiện hoặc địa điểm.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/278932/loa-dien-karaoke-dalton-ts-18a8500-3000w-270223-023623-600x600.jpg",
                       quantity = 1000,
                       price = 16790000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 105,
                       Name = "Loa kéo Nanomax S-900",
                       Description = "Thưởng thức âm thanh mạnh mẽ mọi nơi với loa karaoke di động Nanomax S-900. Với kích thước nhỏ gọn và công suất 420W, loa này hoàn hảo cho các buổi tiệc trong nhà, sự kiện ngoài trời hoặc các buổi karaoke cùng bạn bè.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/232105/loa-keo-karaoke-nanomax-s-900-420w-270223-021046-600x600.jpg",
                       quantity = 1000,
                       price = 4510000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 106,
                       Name = "Loa kéo Dalton TS-12G450X",
                       Description = "Bắt đầu bữa tiệc với loa karaoke Dalton TS-12G450X. Với công suất 450W và thiết kế bền bỉ, loa này mang đến âm thanh rõ ràng, không méo mó cho các buổi karaoke, sự kiện hoặc các chuyến phiêu lưu ngoài trời.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/226090/loa-karaoke-dalton-ts-12g450x-270223-020754-600x600.jpg",
                       quantity = 1000,
                       price = 5500000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 107,
                       Name = "Loa kéo Birici NB-6889",
                       Description = "Nâng cao trải nghiệm âm thanh của bạn với loa karaoke di động Birici NB-6889. Với thiết kế thời trang và công suất 1500W mạnh mẽ, loa này hoàn hảo cho các buổi tiệc, sự kiện hoặc các buổi biểu diễn chuyên nghiệp.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/304091/loa-keo-karaoke-birici-nb-6889-150323-022702-600x600.jpg",
                       quantity = 1000,
                       price = 11490000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 108,
                       Name = "Loa tháp Samsung MX-T70/XV",
                       Description = "Đắm chìm trong âm thanh chất lượng cao với loa tháp Samsung MX-T70/XV. Với công suất 1500W và thiết kế mềm mại, loa này mang đến âm thanh sắc nét, rõ ràng cho các buổi tiệc, sự kiện hoặc giải trí tại nhà.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/220699/loa-thap-samsung-mx-t70-xv-100323-044545-600x600.jpg",
                       quantity = 1000,
                       price = 7790000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 109,
                       Name = "Loa điện Dalton TS - 18A1500",
                       Description = "Trải nghiệm chất lượng âm thanh vượt trội với loa karaoke điện Dalton TS-18A1500. Với công suất 15.000W và các thành phần cao cấp, loa này hoàn hảo cho các buổi hòa nhạc, sự kiện hoặc địa điểm nơi âm thanh chất lượng cao là cần thiết.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/210260/dalton-ts-18a1500-270223-022539-600x600.jpg",
                       quantity = 1000,
                       price = 10390000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 110,
                       Name = "Loa kéo Mobell MK-5070",
                       Description = "Sẵn sàng cho bữa tiệc với loa karaoke di động Mobell MK-5070. Với thiết kế nhỏ gọn và công suất 400W mạnh mẽ, loa này mang lại âm thanh ấn tượng cho các buổi hát karaoke, sự kiện ngoài trời hoặc các buổi tụ tập với bạn bè.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2162/268876/loa-keo-karaoke-mobell-mk-5070-400w-270223-021421-600x600.jpg",
                       quantity = 1000,
                       price = 3470000,
                       WarrantyPeriod = 720,
                       CategoryID = 7,

                   },
                   new Product
                   {
                       Id = 111,
                       Name = "Sunhouse SHD7727 150W",
                       Description = "Quạt điều hòa Sunhouse SHD7727 với công suất 150W mang đến không gian mát mẻ và thoải mái cho căn phòng của bạn. Thiết kế hiện đại, hiệu suất cao và tiết kiệm năng lượng làm cho nó trở thành lựa chọn hoàn hảo cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/199117/sunhouse-shd7727-kg-040923-021104-600x600.jpg",
                       quantity = 1000,
                       price = 3990000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 112,
                       Name = "Daikiosan DM103 175W Mẫu mới",
                       Description = "Quạt điều hòa Daikiosan DM103 với công suất 175W, kiểu dáng mới, thiết kế thông minh và hiệu suất làm mát hiệu quả. Được thiết kế để đem lại sự thoải mái và tiết kiệm năng lượng cho mọi không gian sống.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-1a-1-600x600.jpg",
                       quantity = 1000,
                       price = 3990000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 113,
                       Name = "AVA RPD-80 130W",
                       Description = "Quạt điều hòa AVA RPD-80 với công suất 130W mang đến không khí mát mẻ và dễ chịu cho mọi phòng. Thiết kế hiện đại, tiết kiệm năng lượng và hiệu suất cao làm cho nó trở thành lựa chọn lý tưởng cho gia đình của bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/272138/ava-rpd-80-040923-025403-600x600.jpg",
                       quantity = 1000,
                       price = 2690000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 114,
                       Name = "Daikiosan DM102 110W Mẫu mới",
                       Description = "Quạt điều hòa Daikiosan DM102 với công suất 110W, kiểu dáng mới, hiệu suất cao và tiết kiệm năng lượng. Với khả năng làm mát hiệu quả, nó sẽ giúp bạn cảm thấy thoải mái trong mùa hè oi bức.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-0-600x600.jpg",
                       quantity = 1000,
                       price = 2990000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 115,
                       Name = "Kangaroo KG50F62 100W",
                       Description = "Máy làm mát không khí Kangaroo KG50F62 với công suất 100W mang lại không gian mát mẻ và thoải mái cho gia đình bạn. Với thiết kế nhỏ gọn, hiệu suất cao và tiết kiệm năng lượng, nó là lựa chọn lý tưởng cho các căn phòng nhỏ.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/218312/may-lam-mat-khong-khi-kangaroo-kg50f62-040923-021617-600x600.jpg",
                       quantity = 1000,
                       price = 1990000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 116,
                       Name = "Sunhouse SHD7745 125W Mẫu mới",
                       Description = "Quạt điều hòa Sunhouse SHD7745 với công suất 125W và thiết kế mới mang lại không gian mát mẻ và thoải mái cho căn phòng của bạn. Với hiệu suất cao và tiết kiệm năng lượng, nó là sự lựa chọn hoàn hảo cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-0-600x600.jpg",
                       quantity = 1000,
                       price = 2390000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 117,
                       Name = "Delites RPD-30 40W Mẫu mới",
                       Description = "Quạt điều hòa Delites RPD-30 với công suất 40W, thiết kế mới và hiệu suất làm mát hiệu quả. Với khả năng tạo ra không gian mát mẻ và dễ chịu, nó sẽ làm cho mùa hè của bạn trở nên dễ chịu hơn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-0-600x600.jpg",
                       quantity = 1000,
                       price = 1590000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 118,
                       Name = "Dmax RPD-90 200W Mẫu mới",
                       Description = "Quạt điều hòa Dmax RPD-90 với công suất 200W, thiết kế mới và hiệu suất làm mát cao. Với khả năng tạo ra không gian mát mẻ và thoải mái, nó là lựa chọn lý tưởng cho mọi không gian sống.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-0-600x600.jpg",
                       quantity = 1000,
                       price = 3590000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 119,
                       Name = "Kangaroo KG50F99 165W Mẫu mới",
                       Description = "Máy làm mát không khí Kangaroo KG50F99 với công suất 165W mang lại không gian mát mẻ và dễ chịu cho gia đình bạn. Với hiệu suất cao và tiết kiệm năng lượng, nó là lựa chọn lý tưởng cho các căn phòng lớn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-0-600x600.jpg",
                       quantity = 1000,
                       price = 3990000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 120,
                       Name = "Kangaroo KG50F95 120W Mẫu mới",
                       Description = "Máy làm mát không khí Kangaroo KG50F95 với công suất 120W và thiết kế mới mang lại không gian mát mẻ và dễ chịu cho gia đình bạn. Với hiệu suất cao và tiết kiệm năng lượng, nó là lựa chọn lý tưởng cho mọi không gian sống.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-0-600x600.jpg",
                       quantity = 1000,
                       price = 3470000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 121,
                       Name = "Hòa Phát HPCF1-012 165W",
                       Description = "Quạt điều hòa Hòa Phát HPCF1-012 với công suất 165W mang đến không gian mát mẻ và thoải mái cho mọi căn phòng. Với thiết kế hiện đại và tiết kiệm năng lượng, nó là sự lựa chọn tuyệt vời cho mùa hè.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/307875/quat-dieu-hoa-hoa-phat-hpcf1-012-040923-031050-600x600.jpg",
                       quantity = 1000,
                       price = 3550000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 122,
                       Name = "Sunhouse SHD7775 200W Mẫu mới",
                       Description = "Quạt điều hòa Sunhouse SHD7775 với công suất 200W và thiết kế mới mang lại không gian mát mẻ và dễ chịu cho mọi phòng. Với hiệu suất cao và tiết kiệm năng lượng, nó là sự lựa chọn lý tưởng cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-0-1-600x600.jpg",
                       quantity = 1000,
                       price = 4250000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 123,
                       Name = "Rapido 9000D 200W",
                       Description = "Quạt điều hòa Rapido 9000D với công suất 200W mang lại không gian mát mẻ và thoải mái cho mọi phòng. Với thiết kế hiện đại và hiệu suất cao, nó là lựa chọn lý tưởng cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/219138/quat-dieu-hoa-rapido-9000d-040923-023847-600x600.jpg",
                       quantity = 1000,
                       price = 4290000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 124,
                       Name = "Daikiosan DM202 210W Mẫu mới",
                       Description = "Quạt điều hòa Daikiosan DM202 với công suất 210W, kiểu dáng mới và hiệu suất làm mát cao. Với khả năng tạo ra không gian mát mẻ và thoải mái, nó là lựa chọn lý tưởng cho mọi không gian ",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-0-600x600.jpg",
                       quantity = 1000,
                       price = 4590000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 125,
                       Name = "Rapido 6000D 80W",
                       Description = "Quạt điều hòa Rapido 6000D với công suất 80W mang lại không gian mát mẻ và dễ chịu cho mọi phòng. Với thiết kế nhỏ gọn và hiệu suất cao, nó là lựa chọn lý tưởng cho các căn phòng nhỏ.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/7498/235380/rapido-6000d-040923-024256-600x600.jpg",
                       quantity = 1000,
                       price = 2750000,
                       WarrantyPeriod = 720,
                       CategoryID = 8,

                   },
                   new Product
                   {
                       Id = 126,
                       Name = "Nồi chiên không dầu Rapido SMART-7.0M 7 lít",
                       Description = "Nồi chiên không dầu Rapido SMART-7.0M với dung tích 7 lít là giải pháp hoàn hảo cho những bữa ăn ngon và lành mạnh. Với công nghệ tiên tiến, bạn có thể thưởng thức món ăn yêu thích mà không cần dầu mỡ, giúp giảm lượng calo và chất béo trong khẩu phần ăn hàng ngày.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/307646/noi-chien-khong-dau-rapido-smart-70m-7-lit-240523-094953-600x600.jpg",
                       quantity = 1000,
                       price = 1190000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 127,
                       Name = "Nồi chiên không dầu Sunhouse SHD4062 6 lít",
                       Description = "Nồi chiên không dầu Sunhouse SHD4062 với dung tích 6 lít mang lại sự tiện lợi và hiệu quả cho việc nấu ăn hàng ngày. Với công nghệ chiên không dầu, bạn có thể tận hưởng món ăn giòn ngon mà không cần lo lắng về sức khỏe.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/258338/Sunhouse-SHD4062-0-min-600x600.jpg",
                       quantity = 1000,
                       price = 1490000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 128,
                       Name = "Nồi chiên không dầu Rapido RAF-8.0M 8 lít",
                       Description = "Nồi chiên không dầu Rapido RAF-8.0M với dung tích 8 lít là lựa chọn lý tưởng cho việc chế biến các món ăn ngon mà không cần dầu mỡ. Với thiết kế thông minh và hiệu suất cao, bạn có thể thưởng thức những bữa ăn giòn ngon mà không cần lo lắng về sức khỏe.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/304773/noi-chien-khong-dau-rapido-raf-80m-8-lit-310323-110541-600x600.jpg",
                       quantity = 1000,
                       price = 1290000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 129,
                       Name = "Nồi chiên không dầu AVA KDF-593D 7.5 lít",
                       Description = "Nồi chiên không dầu AVA KDF-593D với dung tích 7.5 lít là giải pháp hoàn hảo cho những bữa ăn lành mạnh và ngon miệng. Với công nghệ chiên không dầu tiên tiến, bạn có thể thưởng thức món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe của gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/240313/ava-kdf-593d-0-600x600-1.jpg",
                       quantity = 1000,
                       price = 1290000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 130,
                       Name = "Nồi chiên không dầu AVA AF358T 4 lít",
                       Description = "Nồi chiên không dầu AVA AF358T với dung tích 4 lít là lựa chọn hoàn hảo cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/240297/Ava-AF358T-0-600x600.jpg",
                       quantity = 1000,
                       price = 990000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 131,
                       Name = "Nồi chiên không dầu Sunhouse SHD4035 9 lít",
                       Description = "Nồi chiên không dầu Sunhouse SHD4035 với dung tích 9 lít là giải pháp tiện lợi và hiệu quả cho việc nấu ăn hàng ngày. Với công nghệ chiên không dầu, bạn có thể chế biến những món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe và làm đẹp da dạng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/275125/275125-600x600-1.jpg",
                       quantity = 1000,
                       price = 1790000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 132,
                       Name = "Nồi chiên không dầu Sunhouse SHD4026 6 lít",
                       Description = "Nồi chiên không dầu Sunhouse SHD4026 với dung tích 6 lít là lựa chọn hoàn hảo cho việc nấu ăn hàng ngày một cách lành mạnh và tiện lợi. Với công nghệ tiên tiến, bạn có thể thưởng thức những món ăn giòn ngon mà không cần dầu mỡ, giữ cho sức khỏe của gia đình bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/249385/Sunhouse-SHD4026-0-min-600x600.jpg",
                       quantity = 1000,
                       price = 1390000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 133,
                       Name = "Lò chiên không dầu Ferroli FAF-12M 12 lít",
                       Description = "Lò chiên không dầu Ferroli FAF-12M với dung tích 12 lít là giải pháp tiện lợi và hiệu quả cho việc nấu ăn hàng ngày. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe của gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/309914/lo-chien-khong-dau-ferroli-faf-12m-12-lit-170823-112904-600x600.jpg",
                       quantity = 1000,
                       price = 1490000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 134,
                       Name = "Nồi chiên không dầu Toshiba AF-74CS2SRVN(B) 7.4 lít",
                       Description = "Nồi chiên không dầu Toshiba AF-74CS2SRVN(B) với dung tích 7.4 lít là lựa chọn lý tưởng cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/306722/noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-0-600x600.jpg",
                       quantity = 1000,
                       price = 2390000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 135,
                       Name = "Nồi chiên không dầu Kangaroo KG55AF1A 5.2 lít",
                       Description = "Nồi chiên không dầu Kangaroo KG55AF1A với dung tích 5.2 lít là giải pháp hoàn hảo cho việc chế biến những bữa ăn lành mạnh và ngon miệng. Với công nghệ chiên không dầu tiên tiến, bạn có thể thưởng thức món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe của gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/217595/Kangaroo-KG55AF1A-0-600x600.jpg",
                       quantity = 1000,
                       price = 1290000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 136,
                       Name = "Nồi chiên không dầu Hafele AF-T5A (535.43.712) 5 lít",
                       Description = "Nồi chiên không dầu Hafele AF-T5A với dung tích 5 lít là lựa chọn hoàn hảo cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/233494/Hafele-AF-T5A-0-600x600.jpg",
                       quantity = 1000,
                       price = 1990000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 137,
                       Name = "SẢN PHẨM CAO CẤP\r\nSẢN PHẨM CAO CẤP\r\nLò chiên không dầu Sunhouse Mama SHD4088 15 lít",
                       Description = "Lò chiên không dầu Sunhouse Mama SHD4088 với dung tích lớn 15 lít là lựa chọn lý tưởng cho việc chế biến những bữa ăn ngon mà không cần dầu mỡ. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/275124/275124-600x600-1.jpg",
                       quantity = 1000,
                       price = 2690000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 138,
                       Name = "Nồi chiên không dầu AVA AF40155D 5 lít",
                       Description = "Nồi chiên không dầu AVA AF40155D với dung tích 5 lít là lựa chọn lý tưởng cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/235357/AVA-AF40155D-0-600x600.jpg",
                       quantity = 1000,
                       price = 990000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 139,
                       Name = "Nồi chiên không dầu Philips HD9200/90 2.4 lít",
                       Description = "Nồi chiên không dầu Philips HD9200/90 với dung tích 2.4 lít là giải pháp hoàn hảo cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/231967/Philips-HD9200-90-0-600x600.jpg",
                       quantity = 1000,
                       price = 1490000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 140,
                       Name = "Lò chiên không dầu Kangaroo KG12AF1A 12 lít",
                       Description = "Lò chiên không dầu Kangaroo KG12AF1A với dung tích 12 lít là lựa chọn lý tưởng cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/9418/242418/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit-170423-120402-600x600.jpg",
                       quantity = 1000,
                       price = 2690000,
                       WarrantyPeriod = 720,
                       CategoryID = 9,

                   },
                   new Product
                   {
                       Id = 141,
                       Name = "Quạt đứng KDK 3 cánh M40K GY 50W",
                       Description = "Quạt đứng KDK M40K GY với 3 cánh và công suất 50W mang đến không gian mát mẻ và thoải mái cho không gian sống của bạn. Với thiết kế đẹp mắt và hiệu suất cao, quạt KDK là sự lựa chọn hoàn hảo cho ngôi nhà của bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/73337/kdk-m40k-xam-gy-290823-020333-600x600.jpg",
                       quantity = 1000,
                       price = 3690000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 142,
                       Name = "Quạt treo tường KDK 3 cánh M40M 51W",
                       Description = "Quạt treo tường KDK M40M với 3 cánh và công suất 51W mang đến không gian mát mẻ và thoải mái cho không gian sống của bạn. Với thiết kế tiện lợi và hiệu suất ổn định, quạt KDK là sự lựa chọn hoàn hảo cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/73339/kdk-m40m-290823-020422-600x600.jpg",
                       quantity = 1000,
                       price = 2770000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 143,
                       Name = "Quạt đứng Senko 3 cánh DH1600 47W",
                       Description = "Quạt đứng Senko DH1600 với 3 cánh và công suất 47W là lựa chọn hoàn hảo cho việc làm mát không gian sống hoặc làm việc của bạn. Với thiết kế hiện đại và tính năng tiện ích, quạt Senko làm cho mọi không gian trở nên thoải mái và dễ chịu.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/268450/268450-600x600.jpg",
                       quantity = 1000,
                       price = 570000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 144,
                       Name = "Quạt lửng Asia 5 cánh VY538990 55W",
                       Description = "Quạt lửng Asia VY538990 với 5 cánh và công suất 55W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến sự thoải mái và mát mẻ cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/275524/lung-asia-vy538990-290823-034344-600x600.jpg",
                       quantity = 1000,
                       price = 470000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 145,
                       Name = "Quạt đứng Toshiba 5 cánh F-LSA20(H)VN 60W",
                       Description = "Quạt đứng Toshiba F-LSA20(H)VN với 5 cánh và công suất 60W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đẹp mắt và hiệu suất cao, quạt Toshiba mang đến không khí thoải mái và dễ chịu.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/164540/toshiba-f-lsa20-h-vn-290823-022101-600x600.jpg",
                       quantity = 1000,
                       price = 1470000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 146,
                       Name = "Quạt đứng Toshiba 5 cánh F-LSA10(W)VN 50W",
                       Description = "Quạt đứng Toshiba F-LSA10(W)VN với 5 cánh và công suất 50W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Toshiba làm cho không gian của bạn trở nên thoải mái và dễ chịu.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/206027/quat-dung-toshiba-f-lsa10-w-vn-trang-290823-023754-600x600.jpg",
                       quantity = 1000,
                       price = 990000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 147,
                       Name = "Quạt lửng Senko 3 cánh L1638 47W",
                       Description = "Quạt lửng Senko L1638 với 3 cánh và công suất 47W là lựa chọn hoàn hảo cho việc làm mát không gian sống hoặc làm việc của bạn. Thiết kế đẹp mắt và hiệu suất cao, quạt Senko mang đến không khí mát mẻ và thoải mái cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/268452/lung-senko-l1638-290823-034304-600x600.jpg",
                       quantity = 1000,
                       price = 4390000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 148,
                       Name = "Quạt lửng Senko 7 cánh LTS1636 65W",
                       Description = "Quạt lửng Senko LTS1636 với 7 cánh và công suất 65W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đẹp mắt và hiệu suất ổn định, quạt Senko mang đến không khí thoải mái và dễ chịu cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/268453/lung-senko-lts1636-290823-034352-600x600.jpg",
                       quantity = 1000,
                       price = 490000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 149,
                       Name = "Quạt đứng Asia 5 cánh VY539790 55W",
                       Description = "Quạt đứng Asia VY539790 với 5 cánh và công suất 55W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến không khí thoải mái và dễ chịu.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/275185/dung-asia-vy539790-290823-035045-600x600.jpg",
                       quantity = 1000,
                       price = 590000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 150,
                       Name = "Quạt lửng Asia 5 cánh VY628890 75W",
                       Description = "Quạt lửng Asia VY628890 với 5 cánh và công suất 75W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến không khí mát mẻ và thoải mái cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-0-600x600.jpg",
                       quantity = 1000,
                       price = 490000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 151,
                       Name = "Quạt đứng Asia 6 cánh VY639990 80W",
                       Description = "Quạt đứng Asia VY639990 với 6 cánh và công suất 80W là lựa chọn hoàn hảo cho việc làm mát không gian sống hoặc làm việc của bạn. Thiết kế đẹp mắt và hiệu suất cao, quạt Asia mang đến không khí mát mẻ và dễ chịu cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/275186/dung-asia-vy639990-290823-035003-600x600.jpg",
                       quantity = 1000,
                       price = 790000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 152,
                       Name = "Quạt treo tường Asia 3 cánh VY377790 55W",
                       Description = "Quạt treo tường Asia VY377790 với 3 cánh và công suất 55W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến không khí mát mẻ và dễ chịu cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/275528/treo-asia-vy377790-290823-033942-600x600.jpg",
                       quantity = 1000,
                       price = 690000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 153,
                       Name = "Quạt bàn Senko 3 cánh B1213 40W",
                       Description = "Quạt bàn Senko B1213 với 3 cánh và công suất 40W là lựa chọn hoàn hảo cho việc làm mát không gian làm việc hoặc nơi làm việc của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Senko làm cho không gian của bạn trở nên thoải mái và dễ chịu.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/268448/ban-senko-b1213-290823-033550-600x600.jpg",
                       quantity = 1000,
                       price = 350000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 154,
                       Name = "Quạt treo tường Senko 7 cánh TC1622 65W",
                       Description = "Quạt treo tường Senko TC1622 với 7 cánh và công suất 65W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đẹp mắt và hiệu suất ổn định, quạt Senko mang đến không khí mát mẻ và dễ chịu cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/268462/quat-treo-tuong-senko-7-canh-tc1622-65w-290823-035015-600x600.jpg",
                       quantity = 1000,
                       price = 499000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 155,
                       Name = "Quạt hộp Midea 5 cánh KYT30-15A 40W",
                       Description = "Quạt hộp Midea KYT30-15A với 5 cánh và công suất 40W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đơn giản và hiệu suất ổn định, quạt Midea mang đến không khí mát mẻ và dễ chịu cho mọi không gian.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1992/207672/midea-kyt30-15a-thumb.jpg",
                       quantity = 1000,
                       price = 550000,
                       WarrantyPeriod = 720,
                       CategoryID = 10,

                   },
                   new Product
                   {
                       Id = 156,
                       Name = "Máy sấy thông hơi Galanz 7 Kg DV-70Q1C",
                       Description = "Máy sấy thông hơi Galanz DV-70Q1C với dung tích 7 kg là giải pháp hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng thông minh giúp tiết kiệm thời gian và năng lượng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/302178/may-say-thong-hoi-galanz-dv-70q1c-260323-083916-600x600.jpg",
                       quantity = 1000,
                       price = 4390000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 157,
                       Name = "Máy sấy thông hơi Galanz 7 Kg DV-70T5C(S)",
                       Description = "Máy sấy thông hơi Galanz DV-70T5C(S) với dung tích 7 kg là lựa chọn đáng tin cậy để làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng thông minh giúp tiết kiệm thời gian và năng lượng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/241930/may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-300x300.jpg",
                       quantity = 1000,
                       price = 4800000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 158,
                       Name = "Máy sấy thông hơi Galanz 7 Kg DV-70T5C(W)",
                       Description = "Máy sấy thông hơi Galanz DV-70T5C(W) với dung tích 7 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/241929/may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-270922-022611-600x600.jpg",
                       quantity = 1000,
                       price = 4700000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 159,
                       Name = "Máy sấy thông hơi Casper 7.2 Kg TD-72VWD",
                       Description = "Máy sấy thông hơi Casper TD-72VWD với dung tích 7.2 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/273320/may-say-casper-td-72vwd-fix-thumb-600x600.jpg",
                       quantity = 1000,
                       price = 4990000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 160,
                       Name = "Máy sấy thông hơi Electrolux 8.5 Kg EDV854J3WB",
                       Description = "Máy sấy thông hơi Electrolux EDV854J3WB với dung tích 8.5 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/272144/may-say-thong-hoi-electrolux-85-kg-edv854j3wb-1.-1-600x600.jpg",
                       quantity = 1000,
                       price = 9890000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 161,
                       Name = "Máy sấy thông hơi Toshiba 7 Kg TD-H80SEV(SK)",
                       Description = "Máy sấy thông hơi Toshiba TD-H80SEV(SK) với dung tích 7 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-070823-044325-600x600.jpg",
                       quantity = 1000,
                       price = 5690000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 162,
                       Name = "Máy sấy thông hơi Electrolux 7.5 Kg EDV754H3WB",
                       Description = "Máy sấy thông hơi Electrolux EDV754H3WB với dung tích 7.5 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/272143/may-say-thong-hoi-electrolux-75-kg-edv754h3wb-170223-031343-600x600.jpg",
                       quantity = 1000,
                       price = 7990000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 163,
                       Name = "Máy sấy bơm nhiệt Electrolux 9 Kg EDH903R9WB",
                       Description = "Máy sấy bơm nhiệt Electrolux EDH903R9WB với dung tích 9 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/284038/may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-061122-103202-600x600.jpg",
                       quantity = 1000,
                       price = 21990000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 164,
                       Name = "Máy sấy thông hơi Electrolux 8.5 Kg EDV854N3SB",
                       Description = "Máy sấy thông hơi Electrolux EDV854N3SB với dung tích 8.5 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/272145/may-say-thong-hoi-electrolux-85-kg-edv854n3sb-170223-034851-600x600.jpg",
                       quantity = 1000,
                       price = 10490000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 165,
                       Name = "Máy sấy bơm nhiệt Electrolux 8 Kg EDH804H5WB",
                       Description = "Máy sấy bơm nhiệt Electrolux EDH804H5WB với dung tích 8 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/284036/may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-041122-052059-600x600.jpg",
                       quantity = 1000,
                       price = 17990000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 166,
                       Name = "Máy sấy bơm nhiệt LG 10.5 Kg DVHP50B",
                       Description = "Máy sấy bơm nhiệt LG DVHP50B với dung tích 10.5 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/307973/may-say-bom-nhiet-lg-inverter-105-kg-dvhp50b-0.-600x600.jpg",
                       quantity = 1000,
                       price = 20970000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 167,
                       Name = "Máy sấy thông hơi Electrolux 8.5 Kg EDS854N3SB",
                       Description = "Máy sấy thông hơi Electrolux EDS854N3SB với dung tích 8.5 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/272142/may-say-thong-hoi-electrolux-85-kg-eds854n3sb-160222-072932-600x600.jpg",
                       quantity = 1000,
                       price = 10990000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 168,
                       Name = "Máy sấy ngưng tụ Toshiba 8 Kg TD-K90MEV(SK)",
                       Description = "Máy sấy ngưng tụ Toshiba TD-K90MEV(SK) với dung tích 8 kg là giải pháp tiện lợi và hiệu quả cho việc làm khô quần áo. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/310251/product-310251-070723-035006-600x600.jpg",
                       quantity = 1000,
                       price = 9900000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 169,
                       Name = "Máy sấy thông hơi Beko 8 Kg DA8112RX0W",
                       Description = "Máy sấy thông hơi Beko DA8112RX0W với dung tích 8 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế hiện đại và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/227250/may-say-beko-da8112rx0w-1-300x300.jpg",
                       quantity = 1000,
                       price = 6990000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 170,
                       Name = "Máy sấy ngưng tụ Candy 10 Kg CSO C10TE-S",
                       Description = "Máy sấy ngưng tụ Candy CSO C10TE-S với dung tích 10 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/2202/230073/may-say-candy-cso-c10te-s-300x300.jpg",
                       quantity = 1000,
                       price = 7190000,
                       WarrantyPeriod = 720,
                       CategoryID = 11,

                   },
                   new Product
                   {
                       Id = 171,
                       Name = "Electrolux 23 lít EMM23D22B",
                       Description = "Lò vi sóng Electrolux EMM23D22B có dung tích 23 lít, thiết kế hiện đại với nhiều chức năng thông minh, giúp bạn nấu nướng một cách dễ dàng và tiện lợi. Với công suất 800W, sản phẩm này đảm bảo bạn có thể chuẩn bị các món ăn ngon mỗi ngày.\r\nElectrolux 23 lít EMM23K22B:",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/299619/299619-600x600.jpg",
                       quantity = 1000,
                       price = 2390000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 172,
                       Name = "Electrolux 23 lít EMM23K22B",
                       Description = "Lò vi sóng Electrolux EMM23K22B với dung tích 23 lít, công suất 800W, và nhiều tính năng tiện ích. Thiết kế sang trọng và hiện đại, sản phẩm này là sự lựa chọn hoàn hảo cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/299620/lo-vi-song-electrolux-emm23k22b-23-lit-140423-115410-600x600.jpg",
                       quantity = 1000,
                       price = 2365000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 173,
                       Name = "Electrolux 20 lít EMM20K22W",
                       Description = "Lò vi sóng Electrolux EMM20K22W với dung tích 20 lít, công suất 700W, và các tính năng thông minh giúp bạn nấu nướng một cách dễ dàng và nhanh chóng. Thiết kế trang nhã và hiện đại, phù hợp với mọi không gian bếp.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/299616/299616-600x600.jpg",
                       quantity = 1000,
                       price = 1890000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 174,
                       Name = "Panasonic 25 lít NN-ST34NBYUE",
                       Description = "Lò vi sóng Panasonic NN-ST34NBYUE với dung tích 25 lít, công suất 800W, và nhiều chức năng nấu nướng đa dạng. Thiết kế tiện lợi và bền bỉ, sản phẩm này là lựa chọn lý tưởng cho các gia đình có nhu cầu sử dụng thường xuyên.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/303492/303492-min-600x600.jpg",
                       quantity = 1000,
                       price = 3590000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 175,
                       Name = "BlueStone 25 lít MOB-7733",
                       Description = "Lò vi sóng BlueStone MOB-7733 có dung tích 25 lít, công suất 900W, và các tính năng tiện ích giúp bạn nấu nướng một cách dễ dàng và nhanh chóng. Thiết kế hiện đại và tiết kiệm không gian, sản phẩm này là sự lựa chọn phù hợp cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/242774/bluestone-mob-7733-25-lit-0-600x600.jpg",
                       quantity = 1000,
                       price = 2799000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 176,
                       Name = "Panasonic 25 lít NN-SM33NBYUE",
                       Description = "Lò vi sóng Panasonic NN-SM33NBYUE với dung tích 25 lít, công suất 800W, và nhiều tính năng thông minh giúp bạn nấu nướng một cách dễ dàng và nhanh chóng. Thiết kế hiện đại và tiết kiệm không gian, sản phẩm này là sự lựa chọn phù hợp cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/303491/303491-min-600x600.jpg",
                       quantity = 1000,
                       price = 3070000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 177,
                       Name = "Panasonic 20 lít NN-ST25JWYUE",
                       Description = "Lò vi sóng Panasonic NN-ST25JWYUE có dung tích 20 lít, công suất 800W, và nhiều chức năng nấu nướng đa dạng. Thiết kế tiện lợi và bền bỉ, sản phẩm này là lựa chọn lý tưởng cho các gia đình cần một chiếc lò vi sóng đáng tin cậy.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/197818/panasonic-nn-st25jwyue-310723-025041-600x600.jpg",
                       quantity = 1000,
                       price = 2870000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 178,
                       Name = "BlueStone 20 lít MOB-7708B",
                       Description = "Lò vi sóng BlueStone MOB-7708B với dung tích 20 lít, công suất 700W, và các tính năng tiện ích giúp bạn nấu nướng một cách dễ dàng và nhanh chóng. Thiết kế hiện đại và tiết kiệm không gian, sản phẩm này là sự lựa chọn phù hợp cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/242766/bluestone-mob-7708b-20-lit-260723-103853-600x600.jpg",
                       quantity = 1000,
                       price = 1849000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 179,
                       Name = "Electrolux 30 lít EMG30D22BM",
                       Description = "Lò vi sóng Electrolux EMG30D22BM có dung tích lớn 30 lít, công suất 1000W, và nhiều chức năng thông minh giúp bạn nấu nướng một cách linh hoạt và tiện lợi. Thiết kế sang trọng và đẳng cấp, sản phẩm này phản ánh sự chuyên nghiệp và hiện đại trong không gian bếp của bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/305855/lo-vi-song-electrolux-emg30d22bm-30-lit-240423-095632-600x600.jpg",
                       quantity = 1000,
                       price = 4740000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 180,
                       Name = "Samsung 23 lít MS23K3513AS/SV-N",
                       Description = "Lò vi sóng Samsung MS23K3513AS/SV-N với dung tích 23 lít, công suất 800W, và nhiều tính năng thông minh giúp bạn nấu nướng một cách dễ dàng và tiện lợi. Thiết kế hiện đại và bền bỉ, sản phẩm này là lựa chọn phù hợp cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/203059/lo-vi-song-samsung-ms23k3513as-sv-n-23-lit-310723-031206-600x600.jpg",
                       quantity = 1000,
                       price = 1690000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 181,
                       Name = "Sharp 20 lít R-205VN(S)",
                       Description = "Lò vi sóng Sharp R-205VN(S) với dung tích 20 lít, công suất 800W, và nhiều tính năng thông minh giúp bạn nấu nướng một cách dễ dàng và tiện lợi. Thiết kế hiện đại và bền bỉ, sản phẩm này là sự lựa chọn phù hợp cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/69080/sharp-r-205vn-s-20-lit-020223-111427-600x600.jpg",
                       quantity = 1000,
                       price = 1590000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 182,
                       Name = "Sharp 20 lít R-209VN-SK",
                       Description = "Lò vi sóng Sharp R-209VN-SK có dung tích 20 lít, công suất 800W, và nhiều chức năng nấu nướng đa dạng. Thiết kế tiện lợi và đẳng cấp, sản phẩm này là lựa chọn lý tưởng cho các gia đình cần một chiếc lò vi sóng đáng tin cậy.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/235256/235256%20(1)-600x600.jpg",
                       quantity = 1000,
                       price = 1670000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 183,
                       Name = "Electrolux 20 lít EMG20K38GWP",
                       Description = " Lò vi sóng Electrolux EMG20K38GWP với dung tích 20 lít, công suất 800W, và các tính năng tiện ích giúp bạn nấu nướng một cách dễ dàng và nhanh chóng. Thiết kế hiện đại và tiết kiệm không gian, sản phẩm này là sự lựa chọn phù hợp cho mọi gia đình.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/203563/lo-vi-song-electrolux-emg20k38gwp-310723-031401-600x600.jpg",
                       quantity = 1000,
                       price = 1990000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 184,
                       Name = "Sharp 21 lít R-211TV-BK",
                       Description = " Lò vi sóng Sharp R-211TV-BK với dung tích 21 lít, công suất 800W, và nhiều tính năng thông minh giúp bạn nấu nướng một cách linh hoạt và tiện lợi. Thiết kế sang trọng và đẳng cấp, sản phẩm này phản ánh sự chuyên nghiệp và hiện đại trong không gian bếp của bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/316809/lo-vi-song-sharp-r-211tv-bk-21-lit-0-600x600.jpg",
                       quantity = 1000,
                       price = 1890000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   },
                   new Product
                   {
                       Id = 185,
                       Name = "Electrolux 23 lít EMG23D22B",
                       Description = " Lò vi sóng Electrolux EMG23D22B có dung tích lớn 23 lít, công suất 800W, và nhiều chức năng thông minh giúp bạn nấu nướng một cách linh hoạt và tiện lợi. Thiết kế sang trọng và đẳng cấp, sản phẩm này phản ánh sự chuyên nghiệp và hiện đại trong không gian bếp của bạn.",
                       ImageUrl = "https://cdn.tgdd.vn/Products/Images/1987/299618/299618-600x600-1.jpg",
                       quantity = 1000,
                       price = 2490000,
                       WarrantyPeriod = 720,
                       CategoryID = 12,

                   }
                );
            modelBuilder.Entity<ProductsDetail>().HasData(
                new ProductsDetail
                {
                    Id = 1,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 1,
                },
                new ProductsDetail
                {
                    Id = 2,
                    Name = "Watt",
                    Value = "30",
                    ProductId = 1,
                },
                new ProductsDetail
                {
                    Id = 3,
                    Name = "Producer",
                    Value = "Panasonic",
                    ProductId = 1,
                },
                new ProductsDetail
                {
                    Id = 4,
                    Name = "Volt",
                    Value = "110",
                    ProductId = 2,
                },
                new ProductsDetail
                {
                    Id = 5,
                    Name = "Watt",
                    Value = "50",
                    ProductId = 2,
                },
                new ProductsDetail
                {
                    Id = 6,
                    Name = "Producer",
                    Value = "Samsung",
                    ProductId = 2,
                },
                new ProductsDetail
                {
                    Id = 7,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 3,
                },
                new ProductsDetail
                {
                    Id = 8,
                    Name = "Watt",
                    Value = "50",
                    ProductId = 3,
                },
                new ProductsDetail
                {
                    Id = 9,
                    Name = "Producer",
                    Value = "Lucky Goldstar",
                    ProductId = 3,
                },
                new ProductsDetail
                {
                    Id = 10,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 4,
                },
                new ProductsDetail
                {
                    Id = 11,
                    Name = "Watt",
                    Value = "60",
                    ProductId = 4,
                },
                new ProductsDetail
                {
                    Id = 12,
                    Name = "Producer",
                    Value = "Sony",
                    ProductId = 4,
                },
                new ProductsDetail
                {
                    Id = 13,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 5,
                },
                new ProductsDetail
                {
                    Id = 14,
                    Name = "Watt",
                    Value = "55",
                    ProductId = 5,
                },
                new ProductsDetail
                {
                    Id = 15,
                    Name = "Producer",
                    Value = "Panasonic",
                    ProductId = 5,
                },
                new ProductsDetail
                {
                    Id = 16,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 6,
                },
                new ProductsDetail
                {
                    Id = 17,
                    Name = "Watt",
                    Value = "50",
                    ProductId = 6,
                },
                new ProductsDetail
                {
                    Id = 18,
                    Name = "Producer",
                    Value = "Philips",
                    ProductId = 6,
                },
                new ProductsDetail
                {
                    Id = 19,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 7,
                },
                new ProductsDetail
                {
                    Id = 20,
                    Name = "Watt",
                    Value = "55",
                    ProductId = 7,
                },
                new ProductsDetail
                {
                    Id = 21,
                    Name = "Producer",
                    Value = "Electrolux",
                    ProductId = 7,
                },
                new ProductsDetail
                {
                    Id = 22,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 8,
                },
                new ProductsDetail
                {
                    Id = 23,
                    Name = "Watt",
                    Value = "40",
                    ProductId = 8,
                },
                new ProductsDetail
                {
                    Id = 24,
                    Name = "Producer",
                    Value = "Whirlpool",
                    ProductId = 8,
                },
                new ProductsDetail
                {
                    Id = 25,
                    Name = "Volt",
                    Value = "110",
                    ProductId = 9,
                },
                new ProductsDetail
                {
                    Id = 26,
                    Name = "Watt",
                    Value = "60",
                    ProductId = 9,
                },
                new ProductsDetail
                {
                    Id = 27,
                    Name = "Producer",
                    Value = "Beko",
                    ProductId = 9,
                },
                new ProductsDetail
                {
                    Id = 28,
                    Name = "Volt",
                    Value = "220",
                    ProductId = 10,
                },
                new ProductsDetail
                {
                    Id = 29,
                    Name = "Watt",
                    Value = "60",
                    ProductId = 10,
                },
                new ProductsDetail
                {
                    Id = 30,
                    Name = "Producer",
                    Value = "Sharp",
                    ProductId = 10,
                }
                );
            modelBuilder.Entity<Images>().HasData(
                new Images
                {
                   Id = 1,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/vi-vn-1.jpg",
                    ProductId = 1,
                },
                new Images
                {
                    Id = 2,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433-1.jpg",
                    ProductId = 1
                },
                new Images
                {
                    Id = 3,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/Untitled-1-780x433.jpg",
                    ProductId = 1
                },
                new Images
                {
                    Id = 4,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-1.jpg",
                    ProductId = 2,

                },
                new Images
                {
                    Id = 5,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-2.jpg",
                    ProductId = 2,

                },
                new Images
                {
                    Id = 6,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-3.jpg",
                    ProductId = 2,

                },
                new Images
                {
                    Id = 7,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-thiet-ke-(1).jpg",
                    ProductId = 3,

                },
                new Images
                {
                    Id = 8,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-dung-tich-(1).jpg",
                    ProductId = 3,

                },
                new Images
                {
                    Id = 9,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/congsuat-780x433.jpg",
                    ProductId = 3,

                },
                new Images
                {
                    Id = 10,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-1.jpg",
                    ProductId = 4,

                },
                new Images
                {
                    Id = 11,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-2.jpg",
                    ProductId = 4,

                },
                new Images
                {
                    Id = 12,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-3.jpg",
                    ProductId = 4,

                },
                new Images
                {
                    Id = 13,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654167272451.jpg",
                    ProductId = 5,

                },
                new Images
                {
                    Id = 14,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654168202480.jpg",
                    ProductId = 5,

                },
                new Images
                {
                    Id = 15,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654169122563.jpg",
                    ProductId = 5,

                },
                new Images
                {
                    Id = 16,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-2.jpg",
                    ProductId = 6,

                },
                new Images
                {
                    Id = 17,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-3.jpg",
                    ProductId = 6,

                },
                new Images
                {
                    Id = 18,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-4.jpg",
                    ProductId = 6,

                },
                new Images
                {
                    Id = 19,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(2).jpg",
                    ProductId = 7,

                },
                new Images
                {
                    Id = 20,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(3).jpg",
                    ProductId = 7,

                },
                new Images
                {
                    Id = 21,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(4).jpg",
                    ProductId = 7,

                },
                new Images
                {
                    Id = 22,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923030465278.jpg",
                    ProductId = 8,

                },
                new Images
                {
                    Id = 23,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923031375346.jpg ",
                    ProductId = 8,

                },
                new Images
                {
                    Id = 24,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923032445291.jpgv",
                    ProductId = 8,

                },
                new Images
                {
                    Id = 25,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-2.jpg",
                    ProductId = 9,
                },
                new Images
                {
                    Id = 26,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-3.jpg",
                    ProductId = 9,

                },
                new Images
                {
                    Id = 27,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-4.jpg",
                    ProductId = 9,

                },
                new Images
                {
                    Id = 28,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-thiet-ke.jpg",
                    ProductId = 10,

                },
                new Images
                {
                    Id = 29,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/cong-suat-780x433.jpg",
                    ProductId = 10,

                },
                new Images
                {
                    Id = 30,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-dung-tich.jpg",
                    ProductId = 10,

                },
                new Images
                {
                    Id = 31,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-thietke.jpg",
                    ProductId = 11,

                },
                new Images
                {
                    Id = 32,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/-congsuat-1.jpg",
                    ProductId = 11,

                },
                new Images
                {
                    Id = 33,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-dungtich.jpg",
                    ProductId = 11,

                },
                new Images
                {
                    Id = 34,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-thietke.jpg",
                    ProductId = 12,

                },
                new Images
                {
                    Id = 35,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-congsuat.jpg",
                    ProductId = 12,

                },
                new Images
                {
                    Id = 36,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-dungtich.jpg",
                    ProductId = 12,

                },
                new Images
                {
                    Id = 37,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-1.jpg",
                    ProductId = 13,

                },
                new Images
                {
                    Id = 38,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/Untitled-2-780x433.jpg",
                    ProductId = 13,

                },
                new Images
                {
                    Id = 39,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-2.jpg",
                    ProductId = 13,

                },
                new Images
                {
                    Id = 40,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466480780750.jpg",
                    ProductId = 14,

                },
                new Images
                {
                    Id = 41,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466481600801.jpg",
                    ProductId = 14,

                },
                new Images
                {
                    Id = 42,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466485200682.jpg",
                    ProductId = 14,

                },
                new Images
                {
                    Id = 43,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/Untitled-2-780x433.jpg",
                    ProductId = 15,

                },
                new Images
                {
                    Id = 44,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-1.jpg",
                    ProductId = 15,

                },
                new Images
                {
                    Id = 45,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-3.jpg",
                    ProductId = 15,

                },
                new Images
                {
                    Id = 46,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-thietke.jpg",
                    ProductId = 16,

                },
                new Images
                {
                    Id = 47,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/a4-780x433.png",
                    ProductId = 16,

                },
                new Images
                {
                    Id = 48,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-dungtich.jpg",
                    ProductId = 16,

                },
                new Images
                {
                    Id = 49,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(6).jpg",
                    ProductId = 17,

                },
                new Images
                {
                    Id = 50,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(4).jpg",
                    ProductId = 17,

                },
                new Images
                {
                    Id = 51,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/a2-780x433.png",
                    ProductId = 17,

                },
                new Images
                {
                    Id = 52,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-7.jpg",
                    ProductId = 18,

                },
                new Images
                {
                    Id = 53,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-4.jpg",
                    ProductId = 18,

                },
                new Images
                {
                    Id = 54,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/thumb-780x433.jpg",
                    ProductId = 18,

                },
                new Images
                {
                    Id = 55,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-2.jpg",
                    ProductId = 19,

                },
                new Images
                {
                    Id = 56,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-3.jpg",
                    ProductId = 19,

                },
                new Images
                {
                    Id = 57,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-4.jpg",
                    ProductId = 19,

                },
                new Images
                {
                    Id = 58,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-thietke.jpg",
                    ProductId = 20,

                },
                new Images
                {
                    Id = 59,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-congsuat.jpg",
                    ProductId = 20,

                },
                new Images
                {
                    Id = 60,
                    Url = "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-dungtich.jpg",
                    ProductId = 20,
                },
                new Images
                {
                    Id = 61,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/2KG855i-1020x570.jpg",
                    ProductId = 21,

                },
                new Images
                {
                    Id = 62,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516149397546.jpg",
                    ProductId = 21,

                },
                new Images
                {
                    Id = 63,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516150627512.jpg",
                    ProductId = 21,

                },
                new Images
                {
                    Id = 64,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709265189907349.jpg",
                    ProductId = 22,

                },
                new Images
                {
                    Id = 65,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274051416304.jpg",
                    ProductId = 22,

                },
                new Images
                {
                    Id = 66,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274053406269.jpg",
                    ProductId = 22,

                },
                new Images
                {
                    Id = 67,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148159663228.jpg",
                    ProductId = 23,
                },
                new Images
                {
                    Id = 68,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148161073382.jpg",
                    ProductId = 23,

                },
                new Images
                {
                    Id = 69,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638277628983499420.jpg",
                    ProductId = 23,

                },
                new Images
                {
                    Id = 70,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208638306537136599246.jpg",
                    ProductId = 24,

                },
                new Images
                {
                    Id = 71,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/vi-vn-doi-pramie-2208-230721-0436562.jpg",
                    ProductId = 24,

                },
                new Images
                {
                    Id = 72,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208-230721-0436578.jpg",
                    ProductId = 24,

                },
                new Images
                {
                    Id = 73,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-3.jpg",
                    ProductId = 25,

                },
                new Images
                {
                    Id = 74,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-4.jpg",
                    ProductId = 25,

                },
                new Images
                {
                    Id = 75,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-9.jpg",
                    ProductId = 25,

                },
                new Images
                {
                    Id = 76,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-1-min.jpg",
                    ProductId = 26,
                },
                new Images
                {
                    Id = 77,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-2-min.jpg",
                    ProductId = 26,

                },
                new Images
                {
                    Id = 78,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-3-min.jpg",
                    ProductId = 26,

                },
                new Images
                {
                    Id = 79,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-2-780x433.jpg",
                    ProductId = 27,

                },
                new Images
                {
                    Id = 80,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-3-780x433.jpg",
                    ProductId = 27,

                },
                new Images
                {
                    Id = 81,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-4-780x433.jpg",
                    ProductId = 27,

                },
                new Images
                {
                    Id = 82,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157188439325.jpg",
                    ProductId = 28,

                },
                new Images
                {
                    Id = 83,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157187419347.jpg",
                    ProductId = 28,

                },
                new Images
                {
                    Id = 84,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157186249325.jpg",
                    ProductId = 28,

                },
                new Images
                {
                    Id = 85,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-4-1.jpg",
                    ProductId = 29,

                },
                new Images
                {
                    Id = 86,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-3-1.jpg",
                    ProductId = 29,

                },
                new Images
                {
                    Id = 87,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-9.jpg",
                    ProductId = 29,

                },
                new Images
                {
                    Id = 88,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-thietkefinal.jpg",
                    ProductId = 30,

                },
                new Images
                {
                    Id = 89,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/galanz-ch211e637701457133462016.jpg",
                    ProductId = 30,

                },
                new Images
                {
                    Id = 90,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-matbepfinal.jpg",
                    ProductId = 30,

                },
                new Images
                {
                    Id = 91,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-1.jpg",
                    ProductId = 31,

                },
                new Images
                {
                    Id = 92,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/-hong-ngoai-sanaky-at-2524hgn-780x433.jpg",
                    ProductId = 31,

                },
                new Images
                {
                    Id = 93,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-3.jpg",
                    ProductId = 31,

                },
                new Images
                {
                    Id = 94,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117081.jpg",
                    ProductId = 32,
                },
                new Images
                {
                    Id = 95,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117092.jpg",
                    ProductId = 32,

                },
                new Images
                {
                    Id = 96,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117113.jpg",
                    ProductId = 32,

                },
                new Images
                {
                    Id = 97,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/tongcongsuat-780x433.jpg",
                    ProductId = 33,

                },
                new Images
                {
                    Id = 98,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127511.jpg",
                    ProductId = 33,

                },
                new Images
                {
                    Id = 99,
                    Url = "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127500.jpg",
                    ProductId = 33,

                },
                new Images
                {
                    Id = 100,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-2-1.jpg",
                    ProductId = 34,

                },
                new Images
                {
                    Id = 101,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-3-1.jpg",
                    ProductId = 34,

                },
                new Images
                {
                    Id = 102,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-4-1.jpg",
                    ProductId = 34,

                },
                new Images
                {
                    Id = 103,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788887736001.jpg",
                    ProductId = 35,

                },
                new Images
                {
                    Id = 104,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788587167004.jpg",
                    ProductId = 35,

                },
                new Images
                {
                    Id = 105,
                    Url = "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788583007035.jpg",
                    ProductId = 35,

                },
                new Images
                {
                    Id = 106,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-02.gif",
                    ProductId = 36,

                },
                new Images
                {
                    Id = 107,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-3.jpg",
                    ProductId = 36,

                },
                new Images
                {
                    Id = 108,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-4.jpg",
                    ProductId = 36,

                },
                new Images
                {
                    Id = 109,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-02.png",
                    ProductId = 37,

                },
                new Images
                {
                    Id = 110,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-03.jpg",
                    ProductId = 37,

                },
                new Images
                {
                    Id = 111,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-05.jpg",
                    ProductId = 37,

                },
                new Images
                {
                    Id = 112,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761528510276.gif",
                    ProductId = 38,

                },
                new Images
                {
                    Id = 113,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761529460408.gif",
                    ProductId = 38,

                },
                new Images
                {
                    Id = 114,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761530420342.jpg",
                    ProductId = 38,

                },
                new Images
                {
                    Id = 115,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-2.jpg",
                    ProductId = 39,

                },
                new Images
                {
                    Id = 116,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-3.jpg",
                    ProductId = 39,

                },
                new Images
                {
                    Id = 117,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-4.jpg",
                    ProductId = 39,
                },
                new Images
                {
                    Id = 118,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/smart-samsung-4k-43-inch-ua43au7002638022060998318047.gif",
                    ProductId = 40,

                },
                new Images
                {
                    Id = 119,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-3.jpg",
                    ProductId = 40,

                },
                new Images
                {
                    Id = 120,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-5.jpg",
                    ProductId = 40,

                },
                new Images
                {
                    Id = 121,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-5.jpg",
                    ProductId = 41,

                },
                new Images
                {
                    Id = 122,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-006.jpg",
                    ProductId = 41,

                },
                new Images
                {
                    Id = 123,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-9.jpg",
                    ProductId = 41,

                },
                new Images
                {
                    Id = 124,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-2.png",
                    ProductId = 42,

                },
                new Images
                {
                    Id = 125,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-4.png",
                    ProductId = 42,

                },
                new Images
                {
                    Id = 126,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-8.png",
                    ProductId = 42,

                },
                new Images
                {
                    Id = 127,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-2.gif",
                    ProductId = 43,

                },
                new Images
                {
                    Id = 128,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-3.gif",
                    ProductId = 43,

                },
                new Images
                {
                    Id = 129,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-4.jpg",
                    ProductId = 43,

                },
                new Images
                {
                    Id = 130,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489862454084.jpg",
                    ProductId = 44,

                },
                new Images
                {
                    Id = 131,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489863354037.jpg",
                    ProductId = 44,

                },
                new Images
                {
                    Id = 132,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489864254065.jpg",
                    ProductId = 44,

                },
                new Images
                {
                    Id = 133,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-006.jpg",
                    ProductId = 45,

                },
                new Images
                {
                    Id = 134,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-9.jpg",
                    ProductId = 45,

                },
                new Images
                {
                    Id = 135,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-10.jpg",
                    ProductId = 45,

                },
                new Images
                {
                    Id = 136,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972278342842.jpg",
                    ProductId = 46,

                },
                new Images
                {
                    Id = 137,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972277412853.jpg",
                    ProductId = 46,
                },
                new Images
                {
                    Id = 138,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972276662851.jpg",
                    ProductId = 46,
                },
                new Images
                {
                    Id = 139,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490700146555.jpg",
                    ProductId = 47,

                },
                new Images
                {
                    Id = 140,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490701116452.jpg",
                    ProductId = 47,

                },
                new Images
                {
                    Id = 141,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490702106380.jpg",
                    ProductId = 47,

                },
                new Images
                {
                    Id = 142,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-2.gif",
                    ProductId = 48,

                },
                new Images
                {
                    Id = 143,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-3.gif",
                    ProductId = 48,

                },
                new Images
                {
                    Id = 144,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-4.jpg",
                    ProductId = 48,

                },
                new Images
                {
                    Id = 145,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996422198459.png",
                    ProductId = 49,

                },
                new Images
                {
                    Id = 146,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996422198459.png",
                    ProductId = 49,
                },
                new Images
                {
                    Id = 147,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996424168464.png",
                    ProductId = 49,

                },
                new Images
                {
                    Id = 148,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-2.png",
                    ProductId = 50,

                },
                new Images
                {
                    Id = 149,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-4.png",
                    ProductId = 50,

                },
                new Images
                {
                    Id = 150,
                    Url = "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-8.png",
                    ProductId = 50,

                },
                new Images
                {
                    Id = 151,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/02-1020x571.jpg",
                    ProductId = 51,

                },
                new Images
                {
                    Id = 152,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/03-1020x571.jpg",
                    ProductId = 51,

                },
                new Images
                {
                    Id = 153,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/06-1020x571.jpg",
                    ProductId = 51,

                },
                new Images
                {
                    Id = 154,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/1-1020x570.jpg",
                    ProductId = 52,

                },
                new Images
                {
                    Id = 155,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/2-1020x570.jpg",
                    ProductId = 52,

                },
                new Images
                {
                    Id = 156,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/4-1020x570-1.jpg",
                    ProductId = 52,

                },
                new Images
                {
                    Id = 157,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-050821-0710241.png",
                    ProductId = 53,

                },
                new Images
                {
                    Id = 158,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-100821-0218070.jpg",
                    ProductId = 53,

                },
                new Images
                {
                    Id = 159,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-210821-1005141.jpg",
                    ProductId = 53,

                },
                new Images
                {
                    Id = 160,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798790132815.jpg",
                    ProductId = 54,

                },
                new Images
                {
                    Id = 161,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798792382855.jpg",
                    ProductId = 54,

                },
                new Images
                {
                    Id = 162,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798793442838.jpg",
                    ProductId = 54,

                },
                new Images
                {
                    Id = 163,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/2-1020x570.png",
                    ProductId = 55,

                },
                new Images
                {
                    Id = 164,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/toshiba-gr-b22vu-ukg-050821-1121262.jpg",
                    ProductId = 55,

                },
                new Images
                {
                    Id = 165,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/198-1020x570.jpg",
                    ProductId = 55,

                },
                new Images
                {
                    Id = 166,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/2-1020x570.png",
                    ProductId = 56,

                },
                new Images
                {
                    Id = 167,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.png",
                    ProductId = 56,

                },
                new Images
                {
                    Id = 168,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.png",
                    ProductId = 56,

                },
                new Images
                {
                    Id = 169,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb2.jpg",
                    ProductId = 57,

                },
                new Images
                {
                    Id = 170,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb3.jpg",
                    ProductId = 57,

                },
                new Images
                {
                    Id = 171,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb4.jpg",
                    ProductId = 57,

                },
                new Images
                {
                    Id = 172,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-5.jpg",
                    ProductId = 58,

                },
                new Images
                {
                    Id = 173,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-6.jpg",
                    ProductId = 58,

                },
                new Images
                {
                    Id = 174,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-7.jpg",
                    ProductId = 58,

                },
                new Images
                {
                    Id = 175,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/samsung-rt20har8dbu-sv-080821-0639042.jpg",
                    ProductId = 59,

                },
                new Images
                {
                    Id = 176,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-2-1020x570.jpg",
                    ProductId = 59,

                },
                new Images
                {
                    Id = 177,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-4-1020x570.jpg",
                    ProductId = 59,

                },
                new Images
                {
                    Id = 178,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-080821-0341071.jpg",
                    ProductId = 60,

                },
                new Images
                {
                    Id = 179,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-210821-0601370.jpg",
                    ProductId = 60,

                },
                new Images
                {
                    Id = 180,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/225858-1020x570.png",
                    ProductId = 60,

                },
                new Images
                {
                    Id = 181,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667257173349.jpg",
                    ProductId =61,

                },
                new Images
                {
                    Id = 182,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258003283.jpg",
                    ProductId = 61,

                },
                new Images
                {
                    Id = 183,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258813389.jpg",
                    ProductId = 61,

                },
                new Images
                {
                    Id = 184,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007604134225944.jpg",
                    ProductId = 62,

                },
                new Images
                {
                    Id = 185,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603868094190.jpg",
                    ProductId = 62,

                },
                new Images
                {
                    Id = 186,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603817113795.jpg",
                    ProductId = 62,

                },
                new Images
                {
                    Id = 187,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760509272052.jpg",
                    ProductId = 63,

                },
                new Images
                {
                    Id = 188,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760510222056.jpg",
                    ProductId = 63,

                },
                new Images
                {
                    Id = 189,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760511042060.jpg",
                    ProductId = 63,

                },
                new Images
                {
                    Id = 190,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343064927731.jpg",
                    ProductId = 64,

                },
                new Images
                {
                    Id = 191,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343066856041.jpg",
                    ProductId = 64,

                },
                new Images
                {
                    Id = 192,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343067926248.jpg",
                    ProductId = 64,

                },
                new Images
                {
                    Id = 193,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404755929362-1020x571.jpg",
                    ProductId = 65,

                },
                new Images
                {
                    Id = 194,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404757959374.jpg",
                    ProductId = 65,

                },
                new Images
                {
                    Id = 195,
                    Url = "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404760909361.jpg",
                    ProductId = 65,

                },
                new Images
                {
                    Id = 196,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121296906251.jpg",
                    ProductId = 66,

                },
                new Images
                {
                    Id = 197,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121297826281.jpg",
                    ProductId = 66,

                },
                new Images
                {
                    Id = 198,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpg",
                    ProductId = 66,

                },
                new Images
                {
                    Id = 199,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpg",
                    ProductId = 67,

                },
                new Images
                {
                    Id = 200,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618087619203.jpg",
                    ProductId = 67,

                },
                new Images
                {
                    Id = 201,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpg",
                    ProductId = 67,

                },
                new Images
                {
                    Id = 202,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpg",
                    ProductId = 68,

                },
                new Images
                {
                    Id = 203,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-giat-nuoc-nong-panasonic-na-fd95v1brv-3.jpg",
                    ProductId = 68,

                },
                new Images
                {
                    Id = 204,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-bot-min-panasonic-na-fd95v1brv-4.jpg",
                    ProductId = 68,

                },
                new Images
                {
                    Id = 205,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-03.jpg",
                    ProductId = 69,

                },
                new Images
                {
                    Id = 206,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-04.jpg",
                    ProductId = 69,

                },
                new Images
                {
                    Id = 207,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-05.jpg",
                    ProductId = 69,

                },
                new Images
                {
                    Id = 208,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/vi-vn-toshiba-7-kg-aw-l805av-sg03.jpg",
                    ProductId = 70,

                },
                new Images
                {
                    Id = 209,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-4-1020x570.jpg",
                    ProductId = 70,

                },
                new Images
                {
                    Id = 210,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-3-1020x570.jpg",
                    ProductId = 70,

                },
                new Images
                {
                    Id = 211,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/chuong-trinh-giat-may-giat-samsung-12kg-wa12cg5745bvsv-1018x575.jpg",
                    ProductId = 71,

                },
                new Images
                {
                    Id = 212,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204011022314.jpg",
                    ProductId = 71,

                },
                new Images
                {
                    Id = 213,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204012042319.jpg",
                    ProductId = 71,

                },
                new Images
                {
                    Id = 214,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/3-1020x570.jpg",
                    ProductId = 72,

                },
                new Images
                {
                    Id = 215,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-giat-nuoc-nong--panasonic-na-fd10vr1bv-3.jpg",
                    ProductId = 72,

                },
                new Images
                {
                    Id = 216,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-bot-min-panasonic-na-fd10vr1bv-4.jpg",
                    ProductId = 72,

                },
                new Images
                {
                    Id = 217,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpg",
                    ProductId = 73,

                },
                new Images
                {
                    Id = 218,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpg",
                    ProductId = 73,

                },
                new Images
                {
                    Id = 219,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg",
                    ProductId = 73,

                },
                new Images
                {
                    Id = 220,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpg",
                    ProductId = 74,
                },
                new Images
                {
                    Id = 221,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpg",
                    ProductId = 74,

                },
                new Images
                {
                    Id = 222,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg",
                    ProductId = 74,

                },
                new Images
                {
                    Id = 223,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb2.jpg",
                    ProductId = 75,

                },
                new Images
                {
                    Id = 224,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb3.jpg",
                    ProductId = 75,

                },
                new Images
                {
                    Id = 225,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb4.jpg",
                    ProductId = 75,

                },
                new Images
                {
                    Id = 226,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528027737733.jpg",
                    ProductId = 76,

                },
                new Images
                {
                    Id = 227,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528028857718.jpg",
                    ProductId = 76,

                },
                new Images
                {
                    Id = 228,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/06-1020x570.jpg",
                    ProductId = 76,

                },
                new Images
                {
                    Id = 229,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/5-1020x570.jpg",
                    ProductId = 77,

                },
                new Images
                {
                    Id = 230,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/7-1020x570.jpg",
                    ProductId = 77,

                },
                new Images
                {
                    Id = 231,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/8-1020x570.jpg",
                    ProductId = 77,

                },
                new Images
                {
                    Id = 232,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/3-1020x570-1.jpg",
                    ProductId = 78,

                },
                new Images
                {
                    Id = 233,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpg",
                    ProductId = 78,

                },
                new Images
                {
                    Id = 234,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpg",
                    ProductId = 78,

                },
                new Images
                {
                    Id = 235,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734854518930.jpg",
                    ProductId = 79,

                },
                new Images
                {
                    Id = 236,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734855308947.jpg",
                    ProductId = 79,

                },
                new Images
                {
                    Id = 237,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734856288998.jpg",
                    ProductId = 79,

                },
                new Images
                {
                    Id = 238,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpg",
                    ProductId = 80,

                },
                new Images
                {
                    Id = 239,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/5-1018x575.jpg",
                    ProductId = 80,

                },
                new Images
                {
                    Id = 240,
                    Url = "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/may-giat-aqua-inverter-9-5-kg-aqd-a952j-bk638271882394422354.jpg",
                    ProductId = 80,

                },
                new Images
                {
                    Id = 241,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016161.jpg",
                    ProductId = 81,

                },
                new Images
                {
                    Id = 242,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016192.jpg",
                    ProductId = 81,

                },
                new Images
                {
                    Id = 243,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/a6-780x433.png",
                    ProductId = 81,

                },
                new Images
                {
                    Id = 244,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080436398647.gif",
                    ProductId = 82,

                },
                new Images
                {
                    Id = 245,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080743600911.jpg",
                    ProductId = 82,

                },
                new Images
                {
                    Id = 246,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpg",
                    ProductId = 82,

                },
                new Images
                {
                    Id = 247,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpg",
                    ProductId = 83,

                },
                new Images
                {
                    Id = 248,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/72067/Slider/vi-vn-cong-nghe-nau3d.jpg",
                    ProductId = 83,

                },
                new Images
                {
                    Id = 249,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/72067/Slider/NO2-780x433-A-780x433.jpg",
                    ProductId = 83,

                },
                new Images
                {
                    Id = 250,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921571.jpg",
                    ProductId = 84,

                },
                new Images
                {
                    Id = 251,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921572.jpg",
                    ProductId = 84,

                },
                new Images
                {
                    Id = 252,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpg",
                    ProductId = 84,

                },
                new Images
                {
                    Id = 253,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpg",
                    ProductId = 85,

                },
                new Images
                {
                    Id = 254,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-3.jpg",
                    ProductId = 85,

                },
                new Images
                {
                    Id = 255,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpg",
                    ProductId = 85,

                },
                new Images
                {
                    Id = 256,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpg",
                    ProductId = 86,

                },
                new Images
                {
                    Id = 257,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/203417/Slider/-dung-tich.jpg",
                    ProductId = 86,
                },
                new Images
                {
                    Id = 258,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/203417/Slider/vi-vn-cong-nghe-nau1d.jpg",
                    ProductId = 86,

                },
                new Images
                {
                    Id = 259,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-delites-ncr1502.jpg",
                    ProductId = 87,

                },
                new Images
                {
                    Id = 260,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/n%E1%BB%93i-c%C6%A1m-n%E1%BA%AFp-r%E1%BB%9Di-delites-ncr1502-111120-0416280.jpg",
                    ProductId = 87,

                },
                new Images
                {
                    Id = 261,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpg",
                    ProductId = 87,

                },
                new Images
                {
                    Id = 262,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpg",
                    ProductId = 88,

                },
                new Images
                {
                    Id = 263,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/275584/Slider/hinh-3-1020x570.jpg",
                    ProductId = 88,

                },
                new Images
                {
                    Id = 264,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/275584/Slider/vi-vn-sunhouse-12-lit-shd8217w-4.jpg",
                    ProductId = 88,

                },
                new Images
                {
                    Id = 265,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-thiet-ke.jpg",
                    ProductId = 89,

                },
                new Images
                {
                    Id = 266,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-dung-tich.jpg",
                    ProductId = 89,

                },
                new Images
                {
                    Id = 267,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-chat-lieu-long-noi.jpg",
                    ProductId = 89,

                },
                new Images
                {
                    Id = 268,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-noi-com-nap-gai-toshiba-rc-10jh2pv-b-1l-(1).png",
                    ProductId = 90,

                },
                new Images
                {
                    Id = 269,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-cong-nghe-nau1d-in-thuong.jpg",
                    ProductId = 90,

                },
                new Images
                {
                    Id = 270,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-bang-dieu-khien.jpg",
                    ProductId = 90,

                },
                new Images
                {
                    Id = 271,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928471.jpg",
                    ProductId = 91,

                },
                new Images
                {
                    Id = 272,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928482.jpg",
                    ProductId = 91,

                },
                new Images
                {
                    Id = 273,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928483.jpg",
                    ProductId = 91,

                },
                new Images
                {
                    Id = 274,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-2.jpg",
                    ProductId = 92,

                },
                 new Images
                 {
                     Id = 275,
                     Url = "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-10.jpg",
                     ProductId = 92,

                 },
                  new Images
                  {
                      Id = 276,
                      Url = "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-cong-nghe-nau3d.jpg",
                      ProductId = 92,

                  },
                new Images
                {
                    Id = 277,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-thiet-ke.jpg",
                    ProductId = 93,

                },
                new Images
                {
                    Id = 278,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-dung-tich-1.jpg",
                    ProductId = 93,

                },
                new Images
                {
                    Id = 279,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/vi-vn-cong-nghe-nau1d.jpg",
                    ProductId = 93,

                },
                new Images
                {
                    Id = 280,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720211.jpg",
                    ProductId = 94,

                },
                new Images
                {
                    Id = 281,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpg",
                    ProductId = 94,

                },
                new Images
                {
                    Id = 282,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpg",
                    ProductId = 94,

                },

                new Images
                {
                    Id = 283,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-thietke2.jpg",
                    ProductId = 95,

                },
                new Images
                {
                    Id = 284,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-dung-tich.jpg",
                    ProductId = 95,

                },
                new Images
                {
                    Id = 285,
                    Url = "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-cong-nghe-nau3d.jpg",
                    ProductId = 95,

                },
                new Images
                {
                    Id = 286,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-18.jpg",
                    ProductId = 96,

                },
                new Images
                {
                    Id = 287,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/1-780x433-780x433.jpg",
                    ProductId = 96,

                },
                new Images
                {
                    Id = 288,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-13.jpg",
                    ProductId = 96,

                },
                new Images
                {
                    Id = 289,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311729789327.jpg",
                    ProductId = 97,

                },
                new Images
                {
                    Id = 290,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311732449371.jpg",
                    ProductId = 97,

                },
                new Images
                {
                    Id = 291,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311734499431.jpg",
                    ProductId = 97,

                },
                new Images
                {
                    Id = 292,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-2.jpg",
                    ProductId = 98,

                },
                new Images
                {
                    Id = 293,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-3.jpg",
                    ProductId = 98,

                },
                new Images
                {
                    Id = 294,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-4.jpg",
                    ProductId = 98,

                },
                new Images
                {
                    Id = 295,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(2).jpg",
                    ProductId = 99,

                },
                new Images
                {
                    Id = 296,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(3).jpg",
                    ProductId = 99,

                },
                new Images
                {
                    Id = 297,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(4).jpg",
                    ProductId = 99,

                },
                
                new Images
                {
                    Id = 298,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-2.jpg",
                    ProductId = 100,

                },
                new Images
                {
                    Id = 299,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-3.jpg",
                    ProductId = 100,

                },
                new Images
                {
                    Id = 300,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpg",
                    ProductId = 100,

                },
                new Images
                {
                    Id = 301,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpg",
                    ProductId = 101,

                },
                new Images
                {
                    Id = 302,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014372-780x433.jpg",
                    ProductId = 101,

                },
                new Images
                {
                    Id = 303,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014340.jpg",
                    ProductId = 101,

                },
                new Images
                {
                    Id = 304,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208261.jpg",
                    ProductId = 102,

                },
                new Images
                {
                    Id = 305,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208272.jpg",
                    ProductId = 102,

                },
                new Images
                {
                    Id = 306,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208283.jpg",
                    ProductId = 102,

                },
                new Images
                {
                    Id = 307,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-2.jpg",
                    ProductId = 103,

                },
                new Images
                {
                    Id = 308,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-3.jpg",
                    ProductId = 103,

                },
                new Images
                {
                    Id = 309,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpg",
                    ProductId = 103,

                },
                new Images
                {
                    Id = 310,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpg",
                    ProductId = 104,

                },
                new Images
                {
                    Id = 311,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556233422401.jpg",

                    ProductId = 104,

                },
                new Images
                {
                    Id = 312,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556232132456.jpg",
                    ProductId = 104,

                },
                new Images
                {
                    Id = 313,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142290.jpg",
                    ProductId = 105,

                },
                new Images
                {
                    Id = 314,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142311.jpg",
                    ProductId = 105,

                },
                new Images
                {
                    Id = 315,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142322.jpg",
                    ProductId = 105,

                },
                new Images
                {
                    Id = 316,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220311.jpg",
                    ProductId = 106,

                },
                new Images
                {
                    Id = 317,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220322.jpg",
                    ProductId = 106,

                },
                new Images
                {
                    Id = 318,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220333.jpg",
                    ProductId = 106,

                },
                new Images
                {
                    Id = 319,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-2.jpg",
                    ProductId = 107,

                },
                new Images
                {
                    Id = 320,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpg",
                    ProductId = 107,

                },
                new Images
                {
                    Id = 321,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpg",
                    ProductId = 107,

                },
                new Images
                {
                    Id = 322,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325321.jpg",
                    ProductId = 108,

                },
                new Images
                {
                    Id = 323,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325332.jpg",
                    ProductId = 108,

                },
                new Images
                {
                    Id = 324,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325344.jpg",
                    ProductId = 108,

                },
                new Images
                {
                    Id = 325,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042071.jpg",
                    ProductId = 109,

                },
                new Images
                {
                    Id = 326,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042082.jpg",
                    ProductId = 109,

                },
                new Images
                {
                    Id = 327,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042093.jpg",
                    ProductId = 109,

                },
                new Images
                {
                    Id = 328,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988717215598.jpg",
                    ProductId = 110,

                },
                new Images
                {
                    Id = 329,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988715785825.jpg",
                    ProductId = 110,

                },
                new Images
                {
                    Id = 330,
                    Url = "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988720605323.jpg",
                    ProductId = 110,

                },
                new Images
                {
                    Id = 331,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(1).jpg",
                    ProductId = 111,

                },
                new Images
                {
                    Id = 332,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-vi-vn-vi-vn-vi-vn-sunhouse-shd7727-kg--(4).jpg",
                    ProductId = 111,

                },
                new Images
                {
                    Id = 333,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpg",
                    ProductId = 111,

                },
                new Images
                {
                    Id = 334,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpg",
                    ProductId = 112,

                },
                new Images
                {
                    Id = 335,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpg",
                    ProductId = 112,

                },
                new Images
                {
                    Id = 336,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpg",
                    ProductId = 112,

                },
                new Images
                {
                    Id = 337,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556893691639.jpg",
                    ProductId = 113,

                },
                new Images
                {
                    Id = 338,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556894541546.jpg",
                    ProductId = 113,

                },
                new Images
                {
                    Id = 339,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556899521529.gif",
                    ProductId = 113,

                },
                new Images
                {
                    Id = 340,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-2.jpg",
                    ProductId = 114,

                },
                new Images
                {
                    Id = 341,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-3.jpg",
                    ProductId = 114,

                },
                new Images
                {
                    Id = 342,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-4.jpg",
                    ProductId = 114,

                },
                new Images
                {
                    Id = 343,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpg",
                    ProductId = 115,

                },
                new Images
                {
                    Id = 344,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpg",
                    ProductId = 115,

                },
                new Images
                {
                    Id = 345,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/-vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(1)-copy.jpg",
                    ProductId = 115,

                },
                new Images
                {
                    Id = 346,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-2.jpg",
                    ProductId = 116,

                },
                new Images
                {
                    Id = 347,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-3.jpg",
                    ProductId = 116,

                },
                new Images
                {
                    Id = 348,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-4.jpg",
                    ProductId = 116,

                },
                new Images
                {
                    Id = 349,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-12.jpg",
                    ProductId = 117,

                },
                new Images
                {
                    Id = 350,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-2.jpg",
                    ProductId = 117,

                },
                new Images
                {
                    Id = 351,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-7.jpg",
                    ProductId = 117,

                },
                new Images
                {
                    Id = 352,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-2.jpg",
                    ProductId = 118,

                },
                new Images
                {
                    Id = 353,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-3.jpg",
                    ProductId = 118,

                },
                new Images
                {
                    Id = 354,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-4.jpg",
                    ProductId = 118,

                },
                new Images
                {
                    Id = 355,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-2.jpg",
                    ProductId = 119,

                },
                new Images
                {
                    Id = 356,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-3.jpg",
                    ProductId = 119,

                },
                new Images
                {
                    Id = 357,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpg",
                    ProductId = 119,

                },
                new Images
                {
                    Id = 358,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpg",
                    ProductId = 120,

                },
                new Images
                {
                    Id = 359,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-3.jpg",
                    ProductId = 120,

                },
                new Images
                {
                    Id = 360,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-4.jpg",
                    ProductId = 120,

                },
                new Images
                {
                    Id = 361,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085709130066.jpg",
                    ProductId = 121,

                },
                new Images
                {
                    Id = 362,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085710240063.jpg",
                    ProductId = 121,

                },
                new Images
                {
                    Id = 363,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085711406269.jpg",
                    ProductId = 121,

                },
                new Images
                {
                    Id = 364,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-1.jpg",
                    ProductId = 122,

                },
                new Images
                {
                    Id = 365,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-8.jpg",
                    ProductId = 122,

                },
                new Images
                {
                    Id = 366,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-9.jpg",
                    ProductId = 122,

                },
                new Images
                {
                    Id = 367,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/vi-vn-quat-dieu-hoa-khong-khi-rapido-9000d-(1).jpg",
                    ProductId = 123,

                },
                new Images
                {
                    Id = 368,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/Untitled-2-780x433.jpg",
                    ProductId = 123,

                },
                new Images
                {
                    Id = 369,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/quat-dieu-hoa-khong-khi-rapido-9000d-190821-0759520.jpg",
                    ProductId = 123,

                },
                new Images
                {
                    Id = 370,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-2.jpg",
                    ProductId = 124,

                },
                new Images
                {
                    Id = 371,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-3.jpg",
                    ProductId = 124,

                },
                new Images
                {
                    Id = 372,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-4.jpg",
                    ProductId = 124,

                },
                new Images
                {
                    Id = 373,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/thietke-780x433.jpg",
                    ProductId = 125,

                },
                new Images
                {
                    Id = 374,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/congsuat-780x433-1.jpg",
                    ProductId = 125,

                },
                new Images
                {
                    Id = 375,
                    Url = "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/dakho-780x433-1.jpg",
                    ProductId = 125,

                },
                new Images
                {
                    Id = 376,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750178906564.jpg",
                    ProductId = 126,

                },
                new Images
                {
                    Id = 377,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750177976576.jpg",
                    ProductId = 126,

                },
                new Images
                {
                    Id = 378,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750176666568.jpg",
                    ProductId = 126,

                },
                new Images
                {
                    Id = 379,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit-1a-min-1020x570.jpg",
                    ProductId = 127,

                },
                new Images
                {
                    Id = 380,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342257456180.jpg",
                    ProductId = 127,

                },
                new Images
                {
                    Id = 381,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342256156195-1020x570--2--1020x570.jpg",
                    ProductId = 127,

                },
                new Images
                {
                    Id = 382,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662592506879.gif",
                    ProductId = 128,

                },
                new Images
                {
                    Id = 383,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638318407391409045.jpg",
                    ProductId = 128,

                },
                new Images
                {
                    Id = 384,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662590086953.jpg",
                    ProductId = 128,

                },
                new Images
                {
                    Id = 385,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/ava-kdf-593d-75lit637956538234543296.jpg",
                    ProductId = 129,

                },
                new Images
                {
                    Id = 386,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-3-(1).jpg",
                    ProductId = 129,

                },
                new Images
                {
                    Id = 387,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-5-(2).jpg",
                    ProductId = 129,

                },
                new Images
                {
                    Id = 388,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/ava-af358t-4-lit637956536037141108.jpg",
                    ProductId = 130,

                },
                new Images
                {
                    Id = 389,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/3-1020x573.jpg",
                    ProductId = 130,

                },
                new Images
                {
                    Id = 390,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/5-1020x570.jpg",
                    ProductId = 130,

                },
                new Images
                {
                    Id = 391,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-2.gif",
                    ProductId = 131,

                },
                new Images
                {
                    Id = 392,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-3.jpg",
                    ProductId = 131,

                },
                new Images
                {
                    Id = 393,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-4--2--1020x570.jpg",
                    ProductId = 131,

                },
                new Images
                {
                    Id = 394,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit-2-min-1020x570.jpg",
                    ProductId = 132,

                },
                new Images
                {
                    Id = 395,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474989859767-1020x570.jpg",
                    ProductId = 132,

                },
                new Images
                {
                    Id = 396,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474988859626-1020x570.jpg",
                    ProductId = 132,

                },
                new Images
                {
                    Id = 397,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194027111283.jpg",
                    ProductId = 133,

                },
                new Images
                {
                    Id = 398,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194028841288.gif",
                    ProductId = 133,

                },
                new Images
                {
                    Id = 399,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194036871330.jpg",
                    ProductId = 133,

                },
                new Images
                {
                    Id = 400,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-2.jpg",
                    ProductId = 134,

                },
                new Images
                {
                    Id = 401,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-3.jpg",
                    ProductId = 134,

                },
                new Images
                {
                    Id = 402,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpg",
                    ProductId = 134,

                },
                new Images
                {
                    Id = 403,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpg",
                    ProductId = 135,

                },
                new Images
                {
                    Id = 404,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/217595/Slider/3-1020x570.jpg",
                    ProductId = 135,

                },
                new Images
                {
                    Id = 405,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/217595/Slider/noi-chien-khong-dau-kangaroo-kg55af1a-2-1020x570.jpg",
                    ProductId = 135,

                },
                new Images
                {
                    Id = 406,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/hafele-af-t5a-2-1020x570-1.jpg",
                    ProductId = 136,

                },
                new Images
                {
                    Id = 407,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/3-1020x570.jpg",
                    ProductId = 136,

                },
                new Images
                {
                    Id = 408,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/5-1020x570.jpg",
                    ProductId = 136,

                },
                new Images
                {
                    Id = 409,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035764079802.jpg",
                    ProductId = 137,

                },
                new Images
                {
                    Id = 410,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit-6-1020x570.jpg",
                    ProductId = 137,

                },
                new Images
                {
                    Id = 411,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035762639897.jpg",
                    ProductId = 137,

                },
                new Images
                {
                    Id = 412,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/ava-af40155d-5-lit637956537558080659.jpg",
                    ProductId = 138,

                },
                new Images
                {
                    Id = 413,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/3-1020x570.jpg",
                    ProductId = 138,

                },
                new Images
                {
                    Id = 414,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/tinh-nang-5.jpg",
                    ProductId = 138,

                },
                new Images
                {
                    Id = 415,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-2-1020x570-1.jpg",
                    ProductId = 139,

                },
                new Images
                {
                    Id = 416,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047016485840.jpg",
                    ProductId = 139,

                },
                new Images
                {
                    Id = 417,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047018855747.jpg",
                    ProductId = 139,

                },
                new Images
                {
                    Id = 418,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018751589262.jpg",
                    ProductId = 140,

                },
                new Images
                {
                    Id = 419,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018737269189.gif",
                    ProductId = 140,

                },
                new Images
                {
                    Id = 420,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpg",
                    ProductId = 140,

                },
                new Images
                {
                    Id = 421,
                    Url = "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpg",
                    ProductId = 141,

                },
                new Images
                {
                    Id = 422,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(2).jpg",
                    ProductId = 141,

                },
                new Images
                {
                    Id = 423,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(4).jpg",
                    ProductId = 141,

                },
                new Images
                {
                    Id = 424,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(2).jpg",
                    ProductId = 142,

                },
                new Images
                {
                    Id = 425,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(3).jpg",
                    ProductId = 142,

                },
                new Images
                {
                    Id = 426,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(4).jpg",
                    ProductId = 142,

                },
                new Images
                {
                    Id = 427,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409519551001.jpg",
                    ProductId = 143,

                },
                new Images
                {
                    Id = 428,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409520581014.jpg",
                    ProductId = 143,

                },
                new Images
                {
                    Id = 429,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409521621105.jpg",
                    ProductId = 143,

                },
                new Images
                {
                    Id = 430,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221087301321.gif",
                    ProductId = 144,

                },
                new Images
                {
                    Id = 431,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221081601265.gif",
                    ProductId = 144,

                },
                new Images
                {
                    Id = 432,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221096181354.jpg",
                    ProductId = 144,

                },
                new Images
                {
                    Id = 433,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-1.jpg",
                    ProductId = 145,

                },
                new Images
                {
                    Id = 434,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-3.jpg",
                    ProductId = 145,

                },
                new Images
                {
                    Id = 435,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-2.jpg",
                    ProductId = 145,

                },
                new Images
                {
                    Id = 436,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/-artboard-3-(1).jpg",
                    ProductId = 146,

                },
                new Images
                {
                    Id = 437,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-2.jpg",
                    ProductId = 146,

                },
                new Images
                {
                    Id = 438,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-1-(1).jpg",
                    ProductId = 146,

                },
                new Images
                {
                    Id = 439,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861153767.jpg",
                    ProductId = 147,

                },
                new Images
                {
                    Id = 440,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861983811.jpg",
                    ProductId = 147,

                },
                new Images
                {
                    Id = 441,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/vi-vn-lung-senko-l1638637962675862923843-copy.jpg",
                    ProductId = 147,

                },
                new Images
                {
                    Id = 442,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831920187882.gif",
                    ProductId = 148,

                },
                new Images
                {
                    Id = 443,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831923127883.jpg",
                    ProductId = 148,

                },
                new Images
                {
                    Id = 444,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831922237870.jpg",
                    ProductId = 148,

                },
                new Images
                {
                    Id = 445,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792400586624.gif",
                    ProductId = 149,

                },
                new Images
                {
                    Id = 446,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792399526428.jpg",
                    ProductId = 149,

                },
                new Images
                {
                    Id = 447,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpg",
                    ProductId = 149,

                },
                new Images
                {
                    Id = 448,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpg",
                    ProductId = 150,

                },
                new Images
                {
                    Id = 449,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-3.jpg",
                    ProductId = 150,

                },
                new Images
                {
                    Id = 450,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-4.jpg",
                    ProductId = 150,

                },
                new Images
                {
                    Id = 451,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784521558850.gif",
                    ProductId = 151,

                },
                new Images
                {
                    Id = 452,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784530598927.jpg",
                    ProductId = 151,

                },
                new Images
                {
                    Id = 453,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784498602706.jpg",
                    ProductId = 151,

                },
                new Images
                {
                    Id = 454,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpg",
                    ProductId = 152,

                },
                new Images
                {
                    Id = 455,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpg",
                    ProductId = 152,

                },
                new Images
                {
                    Id = 456,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777905.jpg",
                    ProductId = 152,

                },
                new Images
                {
                    Id = 457,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426805242552.jpg",
                    ProductId = 153,

                },
                new Images
                {
                    Id = 458,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426806303120.jpg",
                    ProductId = 153,

                },
                new Images
                {
                    Id = 459,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426807332619.gif",
                    ProductId = 153,

                },
                new Images
                {
                    Id = 460,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270747742066.jpg",
                    ProductId = 154,

                },
                new Images
                {
                    Id = 461,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270748552124.jpg",
                    ProductId = 154,

                },
                new Images
                {
                    Id = 462,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270750642154.jpg",
                    ProductId = 154,

                },
                new Images
                {
                    Id = 463,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-1.jpg",
                    ProductId = 155,

                },
                new Images
                {
                    Id = 464,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-5.jpg",
                    ProductId = 155,

                },
                new Images
                {
                    Id = 465,
                    Url = "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-canh-quat.jpg",
                    ProductId = 155,

                },
                new Images
                {
                    Id = 466,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-may-say-thong-hoi-galanz-dv-70q1c-2.jpg",
                    ProductId = 156,

                },
                new Images
                {
                    Id = 467,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-khoi-luong-may-say-thong-hoi-galanz-dv-70q1c-3.jpg",
                    ProductId = 156,

                },
                new Images
                {
                    Id = 468,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-chuong-trinh-say-may-say-thong-hoi-galanz-dv-70q1c-4.jpg",
                    ProductId = 156,

                },
                new Images
                {
                    Id = 469,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128165.jpg",
                    ProductId = 157,

                },
                new Images
                {
                    Id = 470,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128178-(1).jpg",
                    ProductId = 157,

                },
                new Images
                {
                    Id = 471,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128160.jpg",
                    ProductId = 157,

                },
                new Images
                {
                    Id = 472,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-19.png",
                    ProductId = 158,

                },
                new Images
                {
                    Id = 473,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-20.png",
                    ProductId = 158,

                },
                new Images
                {
                    Id = 474,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-21.png",
                    ProductId = 158,

                },
                new Images
                {
                    Id = 475,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253873168169.jpg",
                    ProductId = 159,

                },
                new Images
                {
                    Id = 476,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874088441.jpg",
                    ProductId = 159,

                },
                new Images
                {
                    Id = 477,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874968425.jpg",
                    ProductId = 159,

                },
                new Images
                {
                    Id = 478,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/2-1028x578.jpg",
                    ProductId = 160,

                },
                new Images
                {
                    Id = 479,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/3-1020x570.jpg",
                    ProductId = 160,

                },
                new Images
                {
                    Id = 480,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/4-1020x570.jpg",
                    ProductId = 160,

                },
                new Images
                {
                    Id = 481,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023825.jpg",
                    ProductId = 161,

                },
                new Images
                {
                    Id = 482,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023856.jpg",
                    ProductId = 161,

                },
                new Images
                {
                    Id = 483,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-130723-113516.jpg",
                    ProductId = 161,

                },
                new Images
                {
                    Id = 484,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175913318814.jpg",
                    ProductId = 162,

                },
                new Images
                {
                    Id = 485,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175914328840.jpg",
                    ProductId = 162,

                },
                new Images
                {
                    Id = 486,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175915268944.jpg",
                    ProductId = 162,

                },
                new Images
                {
                    Id = 487,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-2.jpg",
                    ProductId = 163,

                },
                new Images
                {
                    Id = 488,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-3.jpg",
                    ProductId = 163,

                },
                new Images
                {
                    Id = 489,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-4.jpg",
                    ProductId = 163,

                },
                new Images
                {
                    Id = 490,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087530263383.jpg",
                    ProductId = 164,

                },
                new Images
                {
                    Id = 491,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087531273334.jpg",
                    ProductId = 164,

                },
                new Images
                {
                    Id = 492,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087532343348.jpg",
                    ProductId = 164,

                },
                new Images
                {
                    Id = 493,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-2.jpg",
                    ProductId = 165,

                },
                new Images
                {
                    Id = 494,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-3.jpg",
                    ProductId = 165,

                },
                new Images
                {
                    Id = 495,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-4.jpg",
                    ProductId = 165,

                },
                new Images
                {
                    Id = 496,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620147203825.jpg",
                    ProductId = 166,

                },
                new Images
                {
                    Id = 497,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620148293832.jpg",
                    ProductId = 166,

                },
                new Images
                {
                    Id = 498,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620149193805.jpg",
                    ProductId = 166,

                },
                new Images
                {
                    Id = 499,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpg",
                    ProductId = 167,

                },
                new Images
                {
                    Id = 500,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpg",
                    ProductId = 167,

                },
                new Images
                {
                    Id = 501,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701396132621.jpg",
                    ProductId = 167,

                },
                new Images
                {
                    Id = 502,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-110955.jpg",
                    ProductId = 168,

                },
                new Images
                {
                    Id = 503,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111058.jpg",
                    ProductId = 168,

                },
                new Images
                {
                    Id = 504,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111131.jpg",
                    ProductId = 168,

                },
                new Images
                {
                    Id = 505,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745148.jpg",
                    ProductId = 169,

                },
                new Images
                {
                    Id = 506,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745116.jpg",
                    ProductId = 169,

                },
                new Images
                {
                    Id = 507,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745083.jpg",
                    ProductId = 169,

                },
                new Images
                {
                    Id = 508,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344524.jpg",
                    ProductId = 170,

                },
                new Images
                {
                    Id = 509,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344545.jpg",
                    ProductId = 170,

                },
                new Images
                {
                    Id = 510,
                    Url = "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344492.jpg",
                    ProductId = 170,

                },
                new Images
                {
                    Id = 511,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpg",
                    ProductId = 171,

                },
                new Images
                {
                    Id = 512,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpg",
                    ProductId = 171,

                },
                new Images
                {
                    Id = 513,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg",
                    ProductId = 171,

                },
                new Images
                {
                    Id = 514,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpg",
                    ProductId = 172,

                },
                new Images
                {
                    Id = 515,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpg",
                    ProductId = 172,

                },
                new Images
                {
                    Id = 516,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg",
                    ProductId = 172,

                },
                new Images
                {
                    Id = 517,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533255389572.jpg",
                    ProductId = 173,

                },
                new Images
                {
                    Id = 518,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533254489493.jpg",
                    ProductId = 173,

                },
                new Images
                {
                    Id = 519,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533251179393.jpg",
                    ProductId = 173,

                },
                new Images
                {
                    Id = 520,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362669326069.jpg",
                    ProductId = 174,

                },
                new Images
                {
                    Id = 521,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667866005.jpg",
                    ProductId = 174,

                },
                new Images
                {
                    Id = 522,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667026013.jpg",
                    ProductId = 174,

                },
                new Images
                {
                    Id = 523,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/bluestone-mob-7733-25-lit637688001563014937.jpg",
                    ProductId = 175,

                },
                new Images
                {
                    Id = 524,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/3-1020x570.jpg",
                    ProductId = 175,

                },
                new Images
                {
                    Id = 525,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/4-1020x570.jpg",
                    ProductId = 175,

                },
                new Images
                {
                    Id = 526,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082498421640.jpg",
                    ProductId = 176,

                },
                new Images
                {
                    Id = 527,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082497591644.jpg",
                    ProductId = 176,

                },
                new Images
                {
                    Id = 528,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082496741625.jpg",
                    ProductId = 176,

                },
                new Images
                {
                    Id = 529,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/2-min.jpg",
                    ProductId = 177,

                },
                new Images
                {
                    Id = 530,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/3.jpg",
                    ProductId = 177,

                },
                new Images
                {
                    Id = 531,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/4.jpg",
                    ProductId = 177,

                },
                new Images
                {
                    Id = 532,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882448995926.jpg",
                    ProductId = 178,

                },
                new Images
                {
                    Id = 533,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882450315945.jpg",
                    ProductId = 178,

                },
                new Images
                {
                    Id = 534,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882451896008.jpg",
                    ProductId = 178,

                },
                new Images
                {
                    Id = 535,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053426432333.jpg",
                    ProductId = 179,

                },
                new Images
                {
                    Id = 536,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053425522315.jpg",
                    ProductId = 179,

                },
                new Images
                {
                    Id = 537,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053424072423.jpg",
                    ProductId = 179,

                },
                new Images
                {
                    Id = 538,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/2.jpg",
                    ProductId = 180,

                },
                new Images
                {
                    Id = 539,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/3.jpg",
                    ProductId = 180,

                },
                new Images
                {
                    Id = 540,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/4.jpg",
                    ProductId = 180,

                },
                new Images
                {
                    Id = 541,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102501.jpg",
                    ProductId = 181,

                },
                new Images
                {
                    Id = 542,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102512.jpg",
                    ProductId = 181,

                },
                new Images
                {
                    Id = 543,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-0653220.jpg",
                    ProductId = 181,

                },
                new Images
                {
                    Id = 544,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642354.jpg",
                    ProductId = 182,

                },
                new Images
                {
                    Id = 545,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642396.jpg",
                    ProductId = 182,

                },
                new Images
                {
                    Id = 546,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642322.jpg",
                    ProductId = 182,

                },
                new Images
                {
                    Id = 547,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742187747662.jpg",
                    ProductId = 183,

                },
                new Images
                {
                    Id = 548,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742188627552.jpg",
                    ProductId = 183,

                },
                new Images
                {
                    Id = 549,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742189537562.jpg",
                    ProductId = 183,

                },
                new Images
                {
                    Id = 550,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333812797881.jpg",
                    ProductId = 184,
                },
                new Images
                {
                    Id = 551,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333811900019.jpg",
                    ProductId = 184,
                },
                new Images
                {
                    Id = 552,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333810992534.jpg",
                    ProductId = 184,
                },
                new Images
                {
                    Id = 553,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777980886164.jpg",
                    ProductId = 185,

                },
                new Images
                {
                    Id = 554,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777979636127.jpg",
                    ProductId = 185,

                },
                new Images
                {
                    Id = 555,
                    Url = "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777978286125.jpg",
                    ProductId = 185,

                }
                );
            modelBuilder.Entity<CategoryBlog>().HasData(
                    new CategoryBlog
                    {
                        Id=1,
                        Name= "Tủ lạnh",

                    },
                    new CategoryBlog
                    {
                        Id = 2,
                        Name = "Máy giặt",

                    },
                    new CategoryBlog
                    {
                        Id = 3,
                        Name = "Máy điều hòa",

                    },
                    new CategoryBlog
                    {
                        Id = 4,
                        Name = "Ti vi",

                    },
                    new CategoryBlog
                    {
                        Id = 5,
                        Name = "Đồ gia dụng nhà bếp",

                    },
                    new CategoryBlog
                    {
                        Id = 6,
                        Name = "Máy lọc không khí",

                    },
                    new CategoryBlog
                    {
                        Id = 7,
                        Name = "Máy sấy quần áo",

                    },
                    new CategoryBlog
                    {
                        Id = 8,
                        Name = "Máy rửa chén",

                    },
                    new CategoryBlog
                    {
                        Id = 9,
                        Name = "Máy xay sinh tố",

                    },
                    new CategoryBlog
                    {
                        Id = 10,
                        Name = "Nồi chiên Không dầu",

                    }
                );
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id= 1,
                    Title= "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content= "<p>\r\n    Chào mừng bạn đến với bài viết này, nơi chúng tôi sẽ giới thiệu về loạt tủ lạnh tiết kiệm năng lượng hàng đầu từ ELICTRICITY STORE. Khám phá sức mạnh của công nghệ tiên tiến kết hợp với hiệu suất vượt trội, mang lại sự tiện ích và tiết kiệm năng lượng không ngờ tới.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/400.webp 400w,https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/480.webp 480w,https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/500.webp 500w\" type=\"image/webp\" sizes=\"(max-width: 500px) 100vw, 500px\"><img class=\"image_resized\" style=\"width:50.85%;\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/ip64EguHXw0W/images/500.png\" data-ckbox-resource-id=\"ip64EguHXw0W\" width=\"500\" height=\"500\"></picture>\r\n</p>\r\n<p>\r\n    Đa dạng và Phong Phú\r\n</p>\r\n<p>\r\n    Tủ lạnh của ELICTRICITY STORE không chỉ đơn thuần là một thiết bị lưu trữ thực phẩm, mà còn là biểu tượng của sự hiện đại và tiện nghi trong không gian bếp của bạn. Với một loạt các loại tủ lạnh từ các thương hiệu hàng đầu thế giới, bạn có thể dễ dàng tìm thấy lựa chọn phù hợp với nhu cầu và phong cách của gia đình bạn.\r\n</p>\r\n<p>\r\n    Tiết Kiệm Năng Lượng - Bảo Vệ Môi Trường\r\n</p>\r\n<p>\r\n    Với mục tiêu hướng tới sự bền vững và tiết kiệm năng lượng, các dòng tủ lạnh từ ELICTRICITY STORE được thiết kế với công nghệ tiên tiến nhằm giảm thiểu tiêu thụ điện năng mà vẫn đảm bảo hiệu suất hoạt động tối ưu. Bằng cách chọn một chiếc tủ lạnh tiết kiệm năng lượng, bạn không chỉ giúp giảm chi phí hoạt động mà còn đóng góp tích cực vào việc bảo vệ môi trường.\r\n</p>\r\n<p>\r\n    Tính Tiện Lợi và Thân Thiện Người Dùng\r\n</p>\r\n<p>\r\n    Điện Máy Xanh cam kết mang lại trải nghiệm mua sắm tuyệt vời nhất cho khách hàng. Từ quá trình tư vấn chuyên nghiệp đến dịch vụ giao hàng nhanh chóng và hậu mãi chăm sóc khách hàng đáng tin cậy, chúng tôi luôn lắng nghe và đáp ứng mọi nhu cầu của bạn, giúp bạn có được chiếc tủ lạnh hoàn hảo nhất cho gia đình và không gian sống của mình.\r\n</p>\r\n<p>\r\n    Khám Phá Sự Khác Biệt Ngay Hôm Nay\r\n</p>\r\n<p>\r\n    Hãy đến với ELICTRICITY STORE và khám phá thế giới đa dạng và phong phú của các dòng tủ lạnh hàng đầu từ các thương hiệu uy tín trên thị trường. Hãy để chúng tôi cùng bạn tạo nên một không gian bếp hoàn hảo, tiện nghi và thân thiện với môi trường. Đến ELICTRICITY STORE - nơi bạn tìm thấy sự hiện đại và tiết kiệm năng lượng trong từng chiếc tủ lạnh!\r\n</p>\r\n<p>\r\n    &nbsp;\r\n</p>",
                    ImageUrl = "https://tse1.mm.bing.net/th?id=OIP.iLUXbVbhpa2l7FNsrjpgBwHaE7&pid=Api&P=0&h=220",
                    UserId= 1,
                    CategoryBlogID= 1,

                },
                new Blog
                {
                    Id = 2,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới của ELICTRICITY STORE - nơi bạn có thể khám phá và trải nghiệm sự tiện nghi và hiệu suất vượt trội của các dòng máy giặt hàng đầu. Với cam kết mang đến những giải pháp giặt đồ hiện đại, tiết kiệm năng lượng và thuận tiện nhất, Điện Máy Xanh là địa chỉ tin cậy cho mọi gia đình.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/400.webp 400w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/480.webp 480w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/560.webp 560w,https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/571.webp 571w\" sizes=\"(max-width: 571px) 100vw, 571px\" type=\"image/webp\"><img data-ckbox-resource-id=\"rBzobdxkhIDw\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/rBzobdxkhIDw/images/571.png\" width=\"571\" height=\"529\"></picture>\r\n</p>\r\n<p>\r\n    **Đa dạng và Phong Phú**\r\n</p>\r\n<p>\r\n    Từ các máy giặt công nghệ cao đến những dòng máy giặt tiết kiệm nước và năng lượng,ELICTRICITY STORE &nbsp;cung cấp một loạt các lựa chọn đa dạng để đáp ứng mọi nhu cầu và phong cách sử dụng. Dù bạn cần một máy giặt nhỏ gọn cho căn hộ nhỏ hoặc một chiếc máy giặt lớn để phục vụ cho gia đình đông thành viên, chúng tôi đều có sản phẩm phù hợp.\r\n</p>\r\n<p>\r\n    **Tiết Kiệm Năng Lượng - Bảo Vệ Môi Trường**\r\n</p>\r\n<p>\r\n    Với nhận thức về vai trò của việc bảo vệ môi trường, các dòng máy giặt từ ELICTRICITY STORE &nbsp;được thiết kế với công nghệ tiên tiến nhằm giảm thiểu tiêu thụ nước và điện năng mà vẫn đảm bảo hiệu suất giặt tối ưu. Bằng cách chọn một máy giặt tiết kiệm năng lượng, bạn không chỉ giúp giảm chi phí hoạt động mà còn góp phần tích cực vào việc bảo vệ môi trường.\r\n</p>\r\n<p>\r\n    **Tính Tiện Lợi và Thân Thiện Người Dùng**\r\n</p>\r\n<p>\r\n    ELICTRICITY STORE &nbsp;cam kết mang lại trải nghiệm mua sắm tuyệt vời nhất cho khách hàng. Từ quá trình tư vấn chuyên nghiệp đến dịch vụ giao hàng nhanh chóng và hậu mãi chăm sóc khách hàng đáng tin cậy, chúng tôi luôn lắng nghe và đáp ứng mọi nhu cầu của bạn, giúp bạn có được chiếc máy giặt hoàn hảo nhất cho gia đình và cuộc sống hàng ngày.\r\n</p>\r\n<p>\r\n    **Khám Phá Sự Khác Biệt Ngay Hôm Nay**\r\n</p>\r\n<p>\r\n    Hãy đến với ELICTRICITY STORE &nbsp;và khám phá thế giới của các dòng máy giặt hiện đại và tiết kiệm năng lượng. Hãy để chúng tôi cùng bạn tạo nên một không gian giặt đồ tiện nghi và thân thiện với môi trường. Đến ELICTRICITY STORE &nbsp;- nơi bạn tìm thấy sự hiện đại và tiết kiệm năng lượng trong từng chiếc máy giặt!\r\n</p>\r\n<p>\r\n    ---\r\n</p>\r\n<p>\r\n    Hy vọng bài viết này giúp bạn hiểu rõ hơn về sự tiện nghi và hiệu suất của máy giặt từ ELICTRICITY STORE !\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl= "https://www.shutterstock.com/shutterstock/photos/2288129115/display_1500/stock-photo-basket-with-dirty-clothes-near-washing-machines-in-laundry-room-2288129115.jpg",
                    UserId = 21,
                    CategoryBlogID = 2,

                },
                new Blog
                {
                    Id = 3,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới của ELICTRICITY STORE - nơi bạn có thể khám phá và trải nghiệm sự thoải mái và hiệu quả của các dòng máy điều hòa hàng đầu. Với cam kết mang lại không gian sống mát mẻ và thoải mái nhất, ELICTRICITY STORE là địa chỉ tin cậy cho mọi gia đình.<br>\r\n    .\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/jHr_xG2LU6OM/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/jHr_xG2LU6OM/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/jHr_xG2LU6OM/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/jHr_xG2LU6OM/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/jHr_xG2LU6OM/images/372.webp 372w\" sizes=\"(max-width: 372px) 100vw, 372px\" type=\"image/webp\"><img data-ckbox-resource-id=\"jHr_xG2LU6OM\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/jHr_xG2LU6OM/images/372.png\" width=\"372\" height=\"213\"></picture>\r\n</p>\r\n<p>\r\n    Đa Dạng và Phong Phú\r\n</p>\r\n<p>\r\n    Từ máy điều hòa treo tường cho căn hộ nhỏ đến máy điều hòa dàn nóng dàn lạnh cho không gian lớn, ELICTRICITY STORE cung cấp một loạt các lựa chọn đa dạng để đáp ứng mọi nhu cầu và kích thước không gian. Bạn có thể dễ dàng tìm thấy máy điều hòa phù hợp với phòng ngủ, phòng khách, hoặc văn phòng làm việc của bạn.\r\n</p>\r\n<p>\r\n    Tiết Kiệm Năng Lượng - Bảo Vệ Môi Trường\r\n</p>\r\n<p>\r\n    Với nhận thức về vai trò của việc bảo vệ môi trường, các dòng máy điều hòa từ ELICTRICITY STORE được thiết kế với công nghệ tiên tiến nhằm giảm thiểu tiêu thụ điện năng mà vẫn đảm bảo hiệu suất làm lạnh tối ưu. Bằng cách chọn một máy điều hòa tiết kiệm năng lượng, bạn không chỉ giúp giảm chi phí điện mà còn giảm thiểu tác động tiêu cực lên môi trường.\r\n</p>\r\n<p>\r\n    Tính Tiện Lợi và Thân Thiện Người Dùng\r\n</p>\r\n<p>\r\n    ELICTRICITY STORE cam kết mang lại trải nghiệm mua sắm tuyệt vời nhất cho khách hàng. Từ quá trình tư vấn chuyên nghiệp đến dịch vụ giao hàng nhanh chóng và hậu mãi chăm sóc khách hàng đáng tin cậy, chúng tôi luôn lắng nghe và đáp ứng mọi nhu cầu của bạn, giúp bạn có được chiếc máy điều hòa hoàn hảo nhất cho gia đình và không gian sống của mình.\r\n</p>\r\n<p>\r\n    Khám Phá Sự Khác Biệt Ngay Hôm Nay\r\n</p>\r\n<p>\r\n    Hãy đến với ELICTRICITY STORE và khám phá thế giới của các dòng máy điều hòa hiện đại và tiết kiệm năng lượng. Hãy để chúng tôi cùng bạn tạo nên một không gian sống mát mẻ và thoải mái. Đến ELICTRICITY STORE - nơi bạn tìm thấy sự hiện đại và tiết kiệm năng lượng trong từng chiếc máy điều hòa!<br>\r\n    &nbsp;\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl= "https://banhangtaikho.com.vn/Images/Upload/download/2018-6/1-ZHZH6L.jpg",
                    UserId = 22,
                    CategoryBlogID = 3,

                },
                new Blog
                {
                    Id = 4,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới giải trí tuyệt vời từ ELICTRICITY STORE - nơi bạn có thể khám phá và trải nghiệm sự phong phú và tiện ích của các dòng ti vi hàng đầu. Với cam kết mang lại trải nghiệm giải trí hoàn hảo nhất, ELICTRICITY STORE là địa chỉ đáng tin cậy cho mọi gia đình.<br>\r\n    .\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/519EvNyfRK7N/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/519EvNyfRK7N/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/519EvNyfRK7N/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/519EvNyfRK7N/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/519EvNyfRK7N/images/357.webp 357w\" sizes=\"(max-width: 357px) 100vw, 357px\" type=\"image/webp\"><img data-ckbox-resource-id=\"519EvNyfRK7N\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/519EvNyfRK7N/images/357.png\" width=\"357\" height=\"235\"></picture>\r\n</p>\r\n<p>\r\n    Đa Dạng và Phong Phú\r\n</p>\r\n<p>\r\n    Từ các dòng ti vi LED mỏng nhẹ cho phòng khách đến các dòng ti vi thông minh với công nghệ hiện đại, ELICTRICITY STORE cung cấp một loạt các lựa chọn đa dạng để đáp ứng mọi nhu cầu và phong cách sử dụng. Với độ phân giải cao, âm thanh sống động và thiết kế tinh tế, bạn có thể tận hưởng trải nghiệm giải trí tốt nhất trong không gian sống của mình.\r\n</p>\r\n<p>\r\n    Công Nghệ Tiên Tiến và Tiện Ích\r\n</p>\r\n<p>\r\n    Các dòng ti vi từ ELICTRICITY STORE được trang bị công nghệ tiên tiến như hệ điều hành thông minh, kết nối internet và tích hợp các ứng dụng giải trí phong phú như Netflix, YouTube, và Spotify. Bạn có thể dễ dàng truy cập và tận hưởng hàng ngàn nội dung giải trí phong phú chỉ bằng một cú nhấn nút từ chiếc ti vi của mình.\r\n</p>\r\n<p>\r\n    Thiết Kế Tinh Tế và Sang Trọng\r\n</p>\r\n<p>\r\n    Không chỉ là thiết bị điện tử, mỗi chiếc ti vi từ ELICTRICITY STORE còn là một tác phẩm nghệ thuật với thiết kế tinh tế và sang trọng. Với các lựa chọn kích thước màn hình và kiểu dáng đa dạng, bạn có thể dễ dàng lựa chọn chiếc ti vi phù hợp với không gian và phong cách trang trí của bạn.\r\n</p>\r\n<p>\r\n    Dịch Vụ Hậu Mãi Chuyên Nghiệp\r\n</p>\r\n<p>\r\n    ELICTRICITY STORE cam kết mang lại dịch vụ hậu mãi chuyên nghiệp và đáng tin cậy. Từ quá trình mua sắm, giao hàng đến lắp đặt và bảo dưỡng, chúng tôi luôn đồng hành cùng bạn để đảm bảo bạn có được trải nghiệm mua sắm và sử dụng tốt nhất từ sản phẩm của chúng tôi.\r\n</p>\r\n<p>\r\n    Khám Phá Sự Khác Biệt Ngay Hôm Nay\r\n</p>\r\n<p>\r\n    Hãy đến với ELICTRICITY STORE và khám phá thế giới của các dòng ti vi hiện đại và tiện ích. Hãy để chúng tôi cùng bạn tạo nên một không gian giải trí tuyệt vời và đẳng cấp trong gia đình của bạn. Đến ELICTRICITY STORE - nơi bạn tìm thấy sự phong phú và tiện ích trong từng chiếc ti vi!<br>\r\n    <br>\r\n    &nbsp;\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://samnec.com.vn/uploads/images/2017/tivi-samsung-co-tot-khong-1.jpg",
                    UserId = 23,
                    CategoryBlogID = 4,

                },
                new Blog
                {
                    Id = 5,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới của ELICTRICITY STORE - nơi bạn có thể tìm thấy những giải pháp độc đáo và hiện đại để nâng cao tiện ích và sự tiện lợi trong không gian bếp của mình. Với một loạt các sản phẩm đồ gia dụng nhà bếp hàng đầu, ELICTRICITY STORE cam kết mang lại trải nghiệm mua sắm đáng tin cậy và đầy đủ cho mọi gia đình.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/3_2AZE2_OJUA/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/3_2AZE2_OJUA/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/3_2AZE2_OJUA/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/3_2AZE2_OJUA/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/3_2AZE2_OJUA/images/371.webp 371w\" sizes=\"(max-width: 371px) 100vw, 371px\" type=\"image/webp\"><img data-ckbox-resource-id=\"3_2AZE2_OJUA\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/3_2AZE2_OJUA/images/371.png\" width=\"371\" height=\"177\"></picture>\r\n</p>\r\n<p>\r\n    Đa Dạng và Phong Phú\r\n</p>\r\n<p>\r\n    Từ các loại máy xay thực phẩm đa năng đến máy làm bánh và nồi cơm điện tự động, ELICTRICITY STORE cung cấp một loạt các sản phẩm đồ gia dụng nhà bếp để đáp ứng mọi nhu cầu và phong cách sử dụng. Với công nghệ tiên tiến và thiết kế thông minh, các sản phẩm này giúp bạn tiết kiệm thời gian và công sức trong việc chuẩn bị và nấu nướng.\r\n</p>\r\n<p>\r\n    Tiết Kiệm Năng Lượng và Tiện Ích\r\n</p>\r\n<p>\r\n    Các dòng sản phẩm đồ gia dụng nhà bếp từ ELICTRICITY STORE được thiết kế với mục tiêu tiết kiệm năng lượng và tối ưu hóa tiện ích. Từ máy làm bánh thông minh đến máy xay thực phẩm tiện lợi, bạn có thể dễ dàng tận hưởng những công cụ hiện đại giúp bạn tạo ra các món ăn ngon và đa dạng một cách nhanh chóng và tiện lợi.\r\n</p>\r\n<p>\r\n    Thiết Kế Sang Trọng và Tiện Dụng\r\n</p>\r\n<p>\r\n    Không chỉ là các sản phẩm chức năng, mỗi sản phẩm đồ gia dụng nhà bếp từ ELICTRICITY STORE còn được thiết kế với phong cách sang trọng và tiện dụng. Với các lựa chọn kiểu dáng và màu sắc đa dạng, bạn có thể dễ dàng lựa chọn sản phẩm phù hợp với không gian và phong cách trang trí của bếp nhà bạn.\r\n</p>\r\n<p>\r\n    Dịch Vụ Hậu Mãi Chuyên Nghiệp\r\n</p>\r\n<p>\r\n    ELICTRICITY STORE cam kết mang lại dịch vụ hậu mãi chuyên nghi\r\n</p>\r\n<p>\r\n    Khám Phá Sự Khác Biệt Ngay Hôm Nay\r\n</p>\r\n<p>\r\n    Hãy đến với ELICTRICITY STORE và khám phá thế giới của các sản phẩm đồ gia dụng nhà bếp hiện đại và tiện ích. Hãy để chúng tôi cùng bạn tạo nên một không gian bếp hoàn hảo, tiện nghi và đẳng cấp trong gia đình của bạn. Đến ELICTRICITY STORE - nơi bạn tìm thấy sự phong phú và tiện ích trong từng sản phẩm!<br>\r\n    <br>\r\n    <br>\r\n    &nbsp;\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://tse3.mm.bing.net/th?id=OIP.-2O6YwzFwTDh9qot5ixybgHaCl&pid=Api&P=0&h=220",
                    UserId = 24,
                    CategoryBlogID = 5,

                },
                new Blog
                {
                    Id = 6,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới của Electricity Store - nơi bạn có thể tìm thấy những giải pháp hiện đại và hiệu quả nhất để cải thiện chất lượng không khí trong nhà. Với mục tiêu mang lại không gian sống khỏe mạnh và sạch sẽ cho gia đình bạn, máy lọc không khí từ Electricity Store là lựa chọn lý tưởng.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/8QkQJQgo3nFp/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/8QkQJQgo3nFp/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/8QkQJQgo3nFp/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/8QkQJQgo3nFp/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/8QkQJQgo3nFp/images/370.webp 370w\" sizes=\"(max-width: 370px) 100vw, 370px\" type=\"image/webp\"><img data-ckbox-resource-id=\"8QkQJQgo3nFp\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/8QkQJQgo3nFp/images/370.png\" width=\"370\" height=\"205\"></picture>\r\n</p>\r\n<p>\r\n    **Chất Lượng Không Khí Tốt Nhất cho Gia Đình Bạn**\r\n</p>\r\n<p>\r\n    Máy lọc không khí của Electricity Store được thiết kế để loại bỏ các hạt bụi, vi khuẩn, virus, phấn hoa và các chất gây hại khác từ không khí. Với các bộ lọc hiệu quả, máy lọc không khí giúp cải thiện chất lượng không khí trong nhà, giúp bạn và gia đình có một môi trường sống sạch sẽ và thoải mái.\r\n</p>\r\n<p>\r\n    **Thiết Kế Tiện Lợi và Hiện Đại**\r\n</p>\r\n<p>\r\n    Máy lọc không khí của Electricity Store có thiết kế nhỏ gọn và hiện đại, phù hợp với mọi không gian trong nhà. Với các tính năng tiện ích như điều khiển từ xa, chế độ tự động và đèn hiển thị chất lượng không khí, bạn có thể dễ dàng điều chỉnh và kiểm soát máy lọc không khí một cách thuận tiện.\r\n</p>\r\n<p>\r\n    **Tiết Kiệm Năng Lượng và Bền Bỉ**\r\n</p>\r\n<p>\r\n    Máy lọc không khí từ Electricity Store được thiết kế để tiết kiệm năng lượng, giúp giảm thiểu chi phí điện hàng tháng. Với công nghệ tiên tiến và bộ lọc lâu dài, máy lọc không khí có tuổi thọ cao và hoạt động ổn định trong thời gian dài, mang lại giá trị lâu dài cho gia đình bạn.\r\n</p>\r\n<p>\r\n    **Dịch Vụ Hậu Mãi Chuyên Nghiệp**\r\n</p>\r\n<p>\r\n    Electricity Store cam kết mang lại dịch vụ hậu mãi chuyên nghiệp và đáng tin cậy. Từ quá trình mua sắm, giao hàng đến lắp đặt và hướng dẫn sử dụng, chúng tôi luôn đồng hành cùng bạn để đảm bảo bạn có được trải nghiệm mua sắm và sử dụng tốt nhất từ sản phẩm của chúng tôi.\r\n</p>\r\n<p>\r\n    **Khám Phá Sự Khác Biệt Ngay Hôm Nay**\r\n</p>\r\n<p>\r\n    Hãy đến với Electricity Store và khám phá thế giới của các dòng máy lọc không khí hiện đại và hiệu quả. Hãy để chúng tôi cùng bạn tạo nên một không gian sống khỏe mạnh và sạch sẽ cho gia đình của bạn. Đến Electricity Store - nơi bạn tìm thấy sự chất lượng và tiện ích trong từng sản phẩm!\r\n</p>\r\n<p>\r\n    ---\r\n</p>\r\n<p>\r\n    Hy vọng bài viết này giúp bạn hiểu rõ hơn về sự hiện đại và hiệu quả của máy lọc không khí từ Electricity Store!\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://cdn.tgdd.vn/Files/2018/01/25/1061757/may-loc-khong-khi-va-may-lanh-co-gi-giong-va-khac-nhau--3.jpg",
                    UserId = 25,
                    CategoryBlogID = 6,

                },
                new Blog
                {
                    Id = 7,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với Electricity Store - nơi bạn có thể tìm thấy những giải pháp hiện đại và tiện lợi nhất để giữ cho quần áo của bạn luôn khô ráo và sạch sẽ. Với mục tiêu mang lại sự thoải mái và tiện ích cho gia đình của bạn, máy sấy quần áo từ Electricity Store là lựa chọn lý tưởng.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/pY_HT7GoKiVQ/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/pY_HT7GoKiVQ/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/pY_HT7GoKiVQ/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/pY_HT7GoKiVQ/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/pY_HT7GoKiVQ/images/378.webp 378w\" sizes=\"(max-width: 378px) 100vw, 378px\" type=\"image/webp\"><img data-ckbox-resource-id=\"pY_HT7GoKiVQ\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/pY_HT7GoKiVQ/images/378.png\" width=\"378\" height=\"205\"></picture>\r\n</p>\r\n<p>\r\n    **Hiệu Suất và Tiết Kiệm Thời Gian**\r\n</p>\r\n<p>\r\n    Máy sấy quần áo của Electricity Store được thiết kế để cung cấp hiệu suất sấy khô nhanh chóng và hiệu quả. Với các chế độ sấy đa dạng và công nghệ tiên tiến, máy sấy quần áo giúp bạn tiết kiệm thời gian và công sức trong việc làm khô quần áo, để bạn có thêm thời gian cho những việc khác trong ngày.\r\n</p>\r\n<p>\r\n    **Bảo Vệ và Bảo Dưỡng Quần Áo**\r\n</p>\r\n<p>\r\n    Máy sấy quần áo từ Electricity Store không chỉ giúp làm khô quần áo mà còn bảo vệ và duy trì chất lượng của chúng. Các chế độ sấy nhẹ nhàng và cài đặt nhiệt độ thấp giúp giảm thiểu tổn hại cho sợi vải và màu sắc, giữ cho quần áo của bạn luôn mới và bền đẹp.\r\n</p>\r\n<p>\r\n    **Thiết Kế Tiện Lợi và Thân Thiện Người Dùng**\r\n</p>\r\n<p>\r\n    Máy sấy quần áo từ Electricity Store có thiết kế thông minh và tiện ích, phù hợp với mọi không gian trong nhà. Với các tính năng như bộ lọc bụi, chế độ làm mềm và đèn hiển thị trạng thái sấy, bạn có thể dễ dàng điều chỉnh và kiểm soát quá trình sấy quần áo một cách thuận tiện.\r\n</p>\r\n<p>\r\n    **Dịch Vụ Hậu Mãi Chuyên Nghiệp**\r\n</p>\r\n<p>\r\n    Electricity Store cam kết mang lại dịch vụ hậu mãi chuyên nghiệp và đáng tin cậy. Từ quá trình mua sắm, giao hàng đến lắp đặt và hướng dẫn sử dụng, chúng tôi luôn đồng hành cùng bạn để đảm bảo bạn có được trải nghiệm mua sắm và sử dụng tốt nhất từ sản phẩm của chúng tôi.\r\n</p>\r\n<p>\r\n    **Khám Phá Sự Khác Biệt Ngay Hôm Nay**\r\n</p>\r\n<p>\r\n    Hãy đến với Electricity Store và khám phá thế giới của các dòng máy sấy quần áo hiện đại và tiện lợi. Hãy để chúng tôi cùng bạn tạo nên một không gian sống thoải mái và tiện lợi cho gia đình của bạn. Đến Electricity Store - nơi bạn tìm thấy sự chất lượng và tiện ích trong từng sản phẩm!\r\n</p>\r\n<p>\r\n    ---\r\n</p>\r\n<p>\r\n    Hy vọng bài viết này giúp bạn hiểu rõ hơn về sự hiện đại và tiện lợi của máy sấy quần áo từ Electricity Store!\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://toplist.vn/images/800px/may-say-quan-ao-aqua-718939.jpg",
                    UserId = 26,
                    CategoryBlogID = 7,

                },
                new Blog
                {
                    Id = 8,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với Electricity Store - nơi bạn có thể tìm thấy những giải pháp hiện đại và tiện ích nhất để giữ cho nhà bếp của bạn luôn sạch sẽ và tiện nghi. Máy rửa chén từ Electricity Store không chỉ là một thiết bị gia dụng thông thường mà còn là một đồng minh đáng tin cậy, giúp giảm bớt công việc vặt và mang lại sự thuận tiện cho cuộc sống hàng ngày của bạn.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/3ThnJSm4D-dS/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/3ThnJSm4D-dS/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/3ThnJSm4D-dS/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/3ThnJSm4D-dS/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/3ThnJSm4D-dS/images/374.webp 374w\" sizes=\"(max-width: 374px) 100vw, 374px\" type=\"image/webp\"><img data-ckbox-resource-id=\"3ThnJSm4D-dS\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/3ThnJSm4D-dS/images/374.png\"></picture>\r\n</p>\r\n<p>\r\n    **Hiệu Suất Vượt Trội và Tiết Kiệm Nước**\r\n</p>\r\n<p>\r\n    Máy rửa chén của Electricity Store được thiết kế với công nghệ tiên tiến nhằm cung cấp hiệu suất vượt trội và tiết kiệm nước. Với các chế độ rửa đa dạng và các cảm biến thông minh, máy rửa chén tự động điều chỉnh lượng nước và thời gian rửa phù hợp, giúp bạn tiết kiệm nước và năng lượng mỗi lần sử dụng.\r\n</p>\r\n<p>\r\n    **Chất Lượng Rửa Tốt Nhất cho Chén Đĩa và Đồ Dùng Bếp Khác**\r\n</p>\r\n<p>\r\n    Máy rửa chén của Electricity Store mang lại chất lượng rửa tốt nhất cho chén đĩa và đồ dùng bếp khác của bạn. Với các cánh phun nước đa chiều và các bộ lọc hiệu quả, máy rửa chén loại bỏ mọi vết bẩn và mảnh vỡ, để lại chén đĩa sáng bóng và sạch sẽ mỗi lần rửa.\r\n</p>\r\n<p>\r\n    **Thiết Kế Tiện Lợi và Hiện Đại**\r\n</p>\r\n<p>\r\n    Máy rửa chén của Electricity Store có thiết kế thông minh và hiện đại, phù hợp với mọi không gian nhà bếp. Với các tính năng như chế độ tiết kiệm năng lượng, bảng điều khiển dễ sử dụng và khoang chứa linh hoạt, máy rửa chén giúp bạn dễ dàng quản lý và tối ưu hóa quá trình rửa chén.\r\n</p>\r\n<p>\r\n    **Dịch Vụ Hậu Mãi Chuyên Nghiệp**\r\n</p>\r\n<p>\r\n    Electricity Store cam kết mang lại dịch vụ hậu mãi chuyên nghiệp và đáng tin cậy. Từ quá trình mua sắm, giao hàng đến lắp đặt và hướng dẫn sử dụng, chúng tôi luôn đồng hành cùng bạn để đảm bảo bạn có được trải nghiệm mua sắm và sử dụng tốt nhất từ sản phẩm của chúng tôi.\r\n</p>\r\n<p>\r\n    **Khám Phá Sự Khác Biệt Ngay Hôm Nay**\r\n</p>\r\n<p>\r\n    Hãy đến với Electricity Store và khám phá thế giới của các dòng máy rửa chén hiện đại và tiện lợi. Hãy để chúng tôi cùng bạn tạo nên một không gian nhà bếp sạch sẽ và tiện nghi cho gia đình của bạn. Đến Electricity Store - nơi bạn tìm thấy sự chất lượng và tiện ích trong từng sản phẩm!\r\n</p>\r\n<p>\r\n    ---\r\n</p>\r\n<p>\r\n    Hy vọng bài viết này sẽ giúp bạn hiểu rõ hơn về máy rửa chén từ Electricity Store và lợi ích mà nó mang lại cho gia đình bạn!\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://phongreviews.com/wp-content/uploads/2020/12/may-rua-bat-loai-nao-tot-10.jpg",  
                    UserId = 27,
                    CategoryBlogID = 8,

                },
                new Blog
                {
                    Id = 9,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới của Electricity Store - nơi bạn có thể tìm thấy những giải pháp hiện đại và tiện lợi nhất để tạo ra những thức uống sinh tố tươi ngon và bổ dưỡng ngay tại nhà. Với mục tiêu mang lại sự tiện ích và sức khỏe cho gia đình bạn, máy xay sinh tố từ Electricity Store là lựa chọn hoàn hảo.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/sm8UPvGVKfef/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/sm8UPvGVKfef/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/sm8UPvGVKfef/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/sm8UPvGVKfef/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/sm8UPvGVKfef/images/371.webp 371w\" sizes=\"(max-width: 371px) 100vw, 371px\" type=\"image/webp\"><img data-ckbox-resource-id=\"sm8UPvGVKfef\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/sm8UPvGVKfef/images/371.png\"></picture>\r\n</p>\r\n<p>\r\n    **Tạo Ra Sinh Tố Ngon và Bổ Dưỡng Mỗi Ngày**\r\n</p>\r\n<p>\r\n    Máy xay sinh tố của Electricity Store được thiết kế để giúp bạn tạo ra những thức uống sinh tố tươi ngon và bổ dưỡng mỗi ngày, từ trái cây, rau củ đến hạt giống và các loại ngũ cốc. Với lưỡi dao sắc bén và động cơ mạnh mẽ, máy xay sinh tố đảm bảo bạn có được một ly sinh tố mịn màng và ngon miệng trong tích tắc.\r\n</p>\r\n<p>\r\n    **Thiết Kế Tiện Lợi và Đa Năng**\r\n</p>\r\n<p>\r\n    Máy xay sinh tố của Electricity Store có thiết kế nhỏ gọn và đa năng, phù hợp với mọi không gian bếp của bạn. Với nhiều chế độ xay khác nhau và dung tích đa dạng, bạn có thể dễ dàng chế biến các loại sinh tố, nước ép và món pha chế khác một cách linh hoạt và tiện lợi.\r\n</p>\r\n<p>\r\n    **Sức Khỏe và Sự An Toàn Được Đảm Bảo**\r\n</p>\r\n<p>\r\n    Electricity Store luôn chú trọng đến sức khỏe và sự an toàn của người tiêu dùng. Vì vậy, máy xay sinh tố được chế tạo từ các vật liệu an toàn cho thực phẩm và không chứa BPA, đảm bảo bạn có được những thức uống an toàn và bổ dưỡng cho cả gia đình.\r\n</p>\r\n<p>\r\n    **Dịch Vụ Hậu Mãi Chuyên Nghiệp**\r\n</p>\r\n<p>\r\n    Electricity Store cam kết mang lại dịch vụ hậu mãi chuyên nghiệp và đáng tin cậy. Từ quá trình mua sắm, giao hàng đến hướng dẫn sử dụng và bảo trì, chúng tôi luôn ở đây để hỗ trợ bạn mọi lúc, mọi nơi.\r\n</p>\r\n<p>\r\n    **Khám Phá Sự Khác Biệt Ngay Hôm Nay**\r\n</p>\r\n<p>\r\n    Hãy đến với Electricity Store và khám phá thế giới của các dòng máy xay sinh tố hiện đại và tiện lợi. Hãy để chúng tôi giúp bạn tạo ra những thức uống tươi ngon và bổ dưỡng mỗi ngày, đồng hành cùng bạn trên hành trình sức khỏe và dinh dưỡng.\r\n</p>\r\n<p>\r\n    ---\r\n</p>\r\n<p>\r\n    Hy vọng bài viết này sẽ giúp bạn hiểu rõ hơn về sự tiện lợi và sức khỏe mà máy xay sinh tố từ Electricity Store mang lại!\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://img.websosanh.vn/v2/users/dclimg/images/2jrpiqpns04d5.jpg?compress=85",
                    UserId = 28,
                    CategoryBlogID = 9,

                },
                new Blog
                {
                    Id = 10,
                    Title = "<h2>\r\n    Chào Mừng Bạn Đến với ELICTRICITY STORE.\r\n</h2>",
                    content = "<p>\r\n    Chào mừng bạn đến với thế giới của Electricity Store - nơi bạn có thể khám phá những giải pháp tiên tiến nhất cho việc nấu ăn, đặc biệt là nồi chiên không dầu. Với mục tiêu tạo ra những bữa ăn sạch sẽ và lành mạnh cho gia đình của bạn, nồi chiên không dầu từ Electricity Store là sự lựa chọn sáng suốt.\r\n</p>\r\n<p>\r\n    <picture><source srcset=\"https://ckbox.cloud/83b9804952ef428d9155/assets/R4zerl1BZ-uV/images/80.webp 80w,https://ckbox.cloud/83b9804952ef428d9155/assets/R4zerl1BZ-uV/images/160.webp 160w,https://ckbox.cloud/83b9804952ef428d9155/assets/R4zerl1BZ-uV/images/240.webp 240w,https://ckbox.cloud/83b9804952ef428d9155/assets/R4zerl1BZ-uV/images/320.webp 320w,https://ckbox.cloud/83b9804952ef428d9155/assets/R4zerl1BZ-uV/images/370.webp 370w\" sizes=\"(max-width: 370px) 100vw, 370px\" type=\"image/webp\"><img data-ckbox-resource-id=\"R4zerl1BZ-uV\" src=\"https://ckbox.cloud/83b9804952ef428d9155/assets/R4zerl1BZ-uV/images/370.png\"></picture>\r\n</p>\r\n<p>\r\n    **Sức Khỏe và Sự An Toàn Được Đảm Bảo**\r\n</p>\r\n<p>\r\n    Nồi chiên không dầu từ Electricity Store được thiết kế để nấu ăn một cách an toàn và lành mạnh nhất cho gia đình bạn. Với công nghệ nấu không dầu, nồi chiên giúp giảm lượng dầu mỡ sử dụng trong món ăn, giữ cho thực phẩm được nấu giữ lại độ tươi ngon và dinh dưỡng mà không tăng cường lượng chất béo và cholesterol.\r\n</p>\r\n<p>\r\n    **Thiết Kế Tiện Lợi và Hiện Đại**\r\n</p>\r\n<p>\r\n    Nồi chiên không dầu từ Electricity Store có thiết kế thông minh và tiện ích, phù hợp với mọi không gian bếp của bạn. Với các tính năng như màn hình điều khiển cảm ứng, các chế độ nấu tự động và khả năng điều chỉnh nhiệt độ linh hoạt, bạn có thể dễ dàng nấu ăn một cách hiệu quả và tiện lợi.\r\n</p>\r\n<p>\r\n    **Tiết Kiệm Thời Gian và Năng Lượng**\r\n</p>\r\n<p>\r\n    Nồi chiên không dầu không chỉ giúp bạn tiết kiệm dầu mỡ mà còn giảm thiểu thời gian nấu ăn và tiêu tốn năng lượng. Với công nghệ nấu nhanh và hiệu quả, bạn có thể chuẩn bị các món ăn ngon lành trong thời gian ngắn mà không cần phải lo lắng về việc mất thời gian hay lượng năng lượng tiêu hao.\r\n</p>\r\n<p>\r\n    **Dịch Vụ Hậu Mãi Chuyên Nghiệp**\r\n</p>\r\n<p>\r\n    Electricity Store cam kết mang lại dịch vụ hậu mãi chuyên nghiệp và đáng tin cậy. Từ quá trình mua sắm, giao hàng đến hướng dẫn sử dụng và bảo dưỡng, chúng tôi luôn ở đây để hỗ trợ bạn và đảm bảo bạn có được trải nghiệm mua sắm tốt nhất.\r\n</p>\r\n<p>\r\n    **Khám Phá Sự Khác Biệt Ngay Hôm Nay**\r\n</p>\r\n<p>\r\n    Hãy đến với Electricity Store và khám phá thế giới của nồi chiên không dầu hiện đại và tiện lợi. Hãy để chúng tôi cùng bạn tạo ra những bữa ăn ngon lành và đầy dinh dưỡng cho gia đình của bạn. Đến Electricity Store - nơi bạn tìm thấy sự chất lượng và tiện ích trong từng sản phẩm!\r\n</p>\r\n<p>\r\n    ---\r\n</p>\r\n<p>\r\n    Hy vọng bài viết này sẽ giúp bạn hiểu rõ hơn về sự tiện ích và hiệu quả của nồi chiên không dầu từ Electricity Store!\r\n</p>\r\n<figure class=\"image\">\r\n    <img>\r\n</figure>",
                    ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.qIxntG-jeZ3f4jTJSFXVjAHaE7&pid=Api&P=0&h=220",
                    UserId = 29,
                    CategoryBlogID = 10,

                }
                );


        }
    }
}
