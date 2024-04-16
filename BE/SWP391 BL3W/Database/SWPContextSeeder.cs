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
                    CategoryID= 3,
                    CategoryName = "Điện thoại"
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
                    DateOfBirth = new DateTime(2002,05,23),
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
                    DateOfBirth = new DateTime(1999,03,25),
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
                    DateOfBirth = new DateTime(1995,07,20),
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
        }
    }
}
