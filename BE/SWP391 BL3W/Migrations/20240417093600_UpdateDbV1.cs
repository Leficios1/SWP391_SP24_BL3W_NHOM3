﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDbV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CategoryName",
                value: "Tivi");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 4, "Tủ Lạnh" },
                    { 5, "Máy Giặt" },
                    { 6, "Nồi Cơm Điện" },
                    { 7, "Loa" },
                    { 8, "Quạt Điều Hòa" },
                    { 9, "Nồi Chiên" },
                    { 10, "Máy Quạt" },
                    { 11, "Máy Sấy" },
                    { 12, "Lò Vi Sóng" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "Description", "ImageUrl", "Name", "WarrantyPeriod", "price", "quantity", "status" },
                values: new object[,]
                {
                    { 1, 1, "Thiết kế bắt mắt, vỏ ngoài bằng nhựa bền đẹp, dung tích 1.7 lít Bình đun siêu tốc Electrolux EEK3505 cung cấp đủ nước nóng đáp ứng cho nhu cầu sử dụng của gia đình có từ 3 - 4 thành viên, đồng thời kích cỡ nhỏ gọn và không choán chỗ khi đặt trên gian bếp.Bình đun có kiểu dáng hiện đại, trang trí cho gian bếp gia đình.Mâm nhiệt inox phẳng, công suất 2200W dẫn nhiệt tốt để nấu nước mau sôiBình đun siêu tốc Electrolux nấu nước sôi từ 4 - 6 phút, tiết kiệm điện năng tối đa cho gia đình bạn.Cách sử dụng bình đun siêu tốc tốt nhất Mâm nhiệt to bằng thép không gỉ, Vòi nước có lưới lọc cặn để nước rót ra sạch sẽ và tinh khiết hơnNgười dùng dễ dàng tháo lắp lưới lọc cặn khi cần vệ sinh bình đun nước.Lưới lọc cặn giúp nước rót ra luôn sạchHai cột hiển thị mực nước trong suốt ở cả hai bên thân bình tiện dụng Giúp đo lường nước đổ vào bình dễ dàng.Cửa sổ hiển thị mực nước trang bị 2 bên thân ấm Đế tiếp điện Strix cao cấp, hoạt động tốt, qay 360 độ Giúp bạn nhấc và đặt bình vào đế dễ dàng, tăng thêm sự thoải mái cho người sử dụng. Lợi ích của việc sử dụng bình đun siêu tốc Dễ dàng nhấc ấm lên xuống Đế tiếp điện có ngăn chứa dây điện Tránh rối dây, vướng víu khi cần di chuyển hay cất giữ ấm đun.Dây điện được quấn gọn gàng vào chân đế Nhấn công tắc để nấu nước, khi bình bắt đầu đun đèn báo sẽ phát sáng Khi nước sôi, khi bình cạn nước hoặc nhấc bình khỏi đế tiếp điện thì bình đun siêu tốc sẽ tự động ngắt điện và đèn báo sẽ tắt. Nhờ đó, người dùng có thể yên tâm làm nhiều công việc khác trong khi nấu nước. electrolux-eek3505-1Mở nắp bình nhanh chóng bằng cách bấm nút trên tay cầm Người dùng dễ dàng châm nước và rót nước sôi một cách an toàn, nhẹ nhàng. Nút mở nắp trên tay cầm, dễ dàng rót nước bằng một tay Bình đun siêu tốc Electrolux 1.7 lít EEK3505 thiết kế sang trọng, đun nước hiệu quả, an toàn, sử dụng bền lâu.", "https://cdn.tgdd.vn/Products/Images/1989/73312/Slider/binh-sieu-toc-electrolux-1-780x433.jpg", "Bình đun siêu tốc Electrolux 1.7 lít EEK3505", 180, 312000m, 1000, null },
                    { 2, 1, "Bình đun siêu tốc ST15S01 - Hàng ngon giá rẻDung tích bình cung cấp đủ nước nóng cho gia đình 2 - 3 người.Bạn có thể nhanh chóng nấu nước để nấu mì, pha trà, cà phê, hoặc pha sữa bất cứ khi nào cần.Để đun nước, bạn chỉ cần một thao tác nhấn công tắc trên tay cầm. Tay cầm được thiết kế vừa vặn lòng bàn tay, làm bằng nhựa cách nhiệt, không gây bỏng cho người sử dụng.Bình siêu tốc Delites ST15S01 – Công tắc đơn trên tay cầm\r\n\r\nĐế tiếp điện xoay 360 độ, tiện lợi khi di chuyển, bảo quản delites-st15s01-2 Đèn báo hiệu để người dùng dễ quan sát delites-st15s01-4 An toàn khi dùng delites-st15s01-1 Lưới lọc bã trà giúp nước ra sạch hơn Lưới lọc ST15S01. Bình siêu tốc Delites ST15S01 thiết kế đơn giản, tiện dụng, đun nước sôi nhanh, tiết kiệm thời gian, công sức cho người nội trợ. ", "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/tq-780x433.jpg", "Bình đun siêu tốc Delites 1.5 lít ST15S01", 180, 80000m, 1000, null },
                    { 3, 1, "Bình đun siêu tốc Delites kiểu dáng đơn giản, gọn đẹp, dễ dùng trong mọi không gian, Dung tích 1.8 lít phù hợp sử dụng tại gia đình, văn phòng nhỏ ít người...Chất liệu bình đun bằng inox 201 sáng bóng, bền tốt, nấu nước an toàn, hạn chế han gỉ, mới lâu, dễ làm sạch.Chất liệu inox cùng với mâm nhiệt rộng giúp bình làm nóng nhanh hơn, giữ nhiệt lâu, gia tăng hiệu quả sử dụng.Bình có đèn báo hoạt động giúp người dùng tiện theo dõi khi đang đun nước.Đế xoay 360 độ dễ dàng đặt, nhấc bình lên xuống. Chế độ tự ngắt khi nước sôi hay khi bình cạn nước tránh cháy nổ, hư hại và bảo vệ an toàn cho người sử dụng.Lưới lọc bã trà cho nước dùng sạch hơn, ngăn côn trùng gây hại xâm nhập vào bên trong bình.Bình đun siêu tốc Delites 1.8 lít ST18S05 sản phẩm đẹp, dùng tốt, đơn giản, tiện dụng cho nhu cầu của mọi gia đình.", "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/Tongquan-1-780x433.jpg", "Bình đun siêu tốc Delites 1.8 lít ST18S05", 180, 195000m, 1000, null },
                    { 4, 1, "Bình siêu tốc Sunhouse có tính năng tự ngắt khi nước sôi và khi cạn nước đảm bảo an toàn khi sử dụngCung cấp đủ nước nóng cho gia đình có từ 4 - 6 thành viên với dung tích lớn 1.8 lítThân bình sang trọng, đẹp mắt, vệ sinh dễ dàng sau khi dùng. Công suất lớn, mâm nhiệt phẳng to giúp đun nước nhanh sôiBình siêu tốc Sunhouse 1.8 lít SHD1182 thiết kế gọn nhẹ, tiện di chuyển, công suất lớn, là vật dụng không thể thiếu cho gian bếp mọi nhà.", "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/tq-780x433.jpg", "Bình đun siêu tốc Sunhouse 1.8 lít SHD1182", 180, 200000m, 1000, null },
                    { 5, 1, "Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL có kiểu dáng đơn giản, gọn đẹp, ruột bình làm từ inox 201 với công suất 1500W hoạt động ổn định, cùng với nhiều tiện ích và chế độ an toàn, đáp ứng tốt nhu cầu sử dụng nước nóng của mỗi gia đình trong việc pha trà, cà phê,...Thiết kế- Vỏ và ruột bình làm từ inox 201 bền đẹp, hạn chế gỉ sét, nấu nước an toàn, dễ dàng vệ sinh.- Thao tác đóng/mở nhẹ nhàng, thuận tiện với nút nhấn trên nắp bình, dễ dàng đổ nước vào và thuận tiện làm sạch.- Trang bị thang đo mực nước bên trong lòng bình, thuận tiện theo dõi lượng nước rót vào bình cho phù hợp với nhu cầu sử dụng. Mẫu bình đun siêu tốc Điện Quang này có thêm lưới lọc giúp ngăn chặn côn trùng xâm nhập và giữ lại phần bã trà để nước rót ra được sạch, trong trẻo.- Bình đun siêu tốc sử dụng đế tiếp điện Chaserr/Gutng hoạt động ổn định, cho tuổi thọ lên tới 5000 lần đun sôi.- Sử dụng gọn gàng, tiện lợi nhờ có rãnh cuốn dây điện bên dưới đế tiếp điện, tránh gây vướng víu.Dung tích - Công suất - Công tắc- Bình đun có dung tích 1.8 lít, cung cấp đủ nước nóng cho những nhu cầu sử dụng hằng ngày trong gia đình hoặc văn phòng ít người.- Công suất 1500W hoạt động ổn định, đun nước sôi trong khoảng 7 phút, giúp tiết kiệm thời gian và điện năng tiêu thụ hiệu quả.- Đun nước dễ dàng chỉ với 1 nút nhấn tích hợp trên tay cầm, thao tác đơn giản, tiện lợi ngay cả người lớn tuổi cũng có thể sử dụng được, có đèn báo hoạt động.Chế độ an toàn. Tự động ngắt điện khi nước sôi hoặc cạn nước, tráng gây lãng phí điện năng, hạn chế cháy nổ, đảm bảo an toàn khi sử dụng.Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL thiết kế đơn giản, nhỏ gọn dễ dùng, chất liệu an toàn, bền tốt, đến từ thương hiệu Việt uy tín - Điện Quang, là thiết bị nhà bếp hữu ích cho mọi gia đình.", "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654163373807.jpg", "Bình đun siêu tốc Điện Quang 1.8 lít ĐQ EKT06 1518 BL", 180, 200000m, 1000, null },
                    { 6, 1, "Thiết kế dạng hình trụ gọn đẹp, màu xanh pastel trang nhã, chỉ có 1.07 kg, dễ dàng di chuyển và sử dụng ở mọi nơiThân bình đun siêu tốc Sunhouse dày 2 lớp chất lượng tốt. Ruột bình làm bằng inox 304 hạn chế rỉ sét, an toàn cho sức khỏe. Trong khi vỏ bình bằng nhựa PP cho khả năng cách nhiệt tốt, giảm nguy cơ bị bỏng khi chạm vào bình lúc nước sôi.Chất liệu nhựa PP có đặc tính không mùi, không vị, không độc, độ bóng bề mặt cao, chịu nhiệt tốt nên được sử dụng rất phổ biến trong thiết kế đồ gia dụng, cho bạn an tâm khi sử dụng Sunhouse SHD1351.Dung tích 1.8 lít đáp ứng tốt nhu cầu nước nóng pha chế đồ uống, nấu mì,... cho 2 - 4 người dùngĐèn báo hoạt động thiết kế ở thân bình, cho ánh sáng xanh bắt mắt, dễ quan sát quá trình đunHướng dẫn sử dụng bình đun siêu tốc​:- Đổ nước vào bình đun siêu tốc không dưới mức MIN và quá mức MAX của cột hiển thị mực nước.- Đặt bình vào đế tiếp điện, kết nối phích cắm với ổ điện.- Nhấn nút công tắc ON/OFF để đun nước, khi đèn báo hiệu phát sáng thì bình đang đun.- 10 giây sau khi nước sôi bình sẽ tự ngắt điện, bạn cũng có thể chủ động ngắt điện khi nhấn vào nút ON/OFF.- Sau đó, bạn có thể nhấc bình ra khỏi đế tiếp điện và bắt đầu sử dụng tùy ý.Bình đun siêu tốc Sunhouse 1.8 lít SHD1351 của thương hiệu Việt Nam - Sunhouse, mẫu mã đẹp mắt, dung tích 1.8 lít, công suất 1500W, đế tiếp điện độ bền cao, đun nước an toàn, lựa chọn cho gia đình. ", "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-1.jpg", "Bình đun siêu tốc Sunhouse 1.8 lít SHD1351 ", 180, 299000m, 1000, null },
                    { 7, 1, "Bình đun siêu tốc kiểu dáng hình trụ hiện đại, màu xanh lá tông pastel trang nhã làm đẹp không gian sử dụngBình đun siêu tốc Sunhouse thiết kế 2 lớp bền đẹp, sử dụng an toàn với chất liệu cao cấp.Ruột bình bằng inox 304 hạn chế gỉ sét tốt, an toàn sức khỏe, dễ làm sạch.Vỏ bình bằng nhựa PP cách nhiệt giúp giảm nguy cơ bị bỏng khi chạm vào bình lúc nước sôi. Dung tích 1.8 lít đáp ứng tốt nhu cầu nước nóng pha chế đồ uống, nấu mì,... cho 2 - 4 người dùng.Công suất 1500W đun sôi nước trong 4 - 6 phút Sử dụng bình đun siêu tốc bền bỉ:- Không mở nắp khi đang đun nước.- Châm nước theo vạch mức hướng dẫn trên thân bình, tránh châm nước quá đầy hay quá ít.- Không nên trữ nước thừa trong bình đun để phòng tránh rò rỉ nguy hiểm và tình trạng đóng cặn.- Cần vệ sinh bình đun thường xuyên để tránh đóng cặn.Bình đun siêu tốc Sunhouse 1.8 lít SHD1353 sang đẹp, công suất lớn nấu nước nhanh sôi, sử dụng bền bỉ, dung tích 1.8 lít đáp ứng tốt nhu cầu nước nóng cho 2 - 4 người dùng.", "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(1).jpg", "Bình đun siêu tốc Sunhouse 1.8 lít SHD1353", 180, 340000m, 500, null },
                    { 8, 1, "Bình đun siêu tốc Sunhouse Mama 1.8 lít SHD1389 công suất 1850W đun nước sôi nhanh chóng, tiết kiệm thời gian, ruột bình bằng inox 304 an toàn cho sức khỏe, dung tích 1.8 lít phục vụ tốt cho nhu cầu dùng nước nóng thường nhật của gia đình. ", "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923028275241.jpg", "Bình đun siêu tốc Sunhouse Mama 1.8 lít SHD1389 ", 180, 490000m, 100, null },
                    { 9, 1, "Bình đun siêu tốc Bear 1.5 lít BEK-E153W2 công suất 1500W đun nước sôi nhanh chóng, tiết kiệm thời gian, ruột bình bằng inox 304 an toàn cho sức khỏe, dung tích 1.5 lít phục vụ tốt cho nhu cầu dùng nước nóng thường nhật của gia đình. ", "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-1.jpg", "Bình đun siêu tốc Bear 1.5 lít BEK-E153W2", 180, 350000m, 1000, null },
                    { 10, 1, "Bình đun siêu tốc Delites kiểu dáng đơn giản, chất liệu inox với viền nhựa đen tinh tế, dùng đẹp trong mọi không gian, từ nhà ở đến văn phòng, khách sạn, bệnh viện,… Dung tích 1.8 lít đủ dùng cho gia đình 3 – 4 người, pha trà, cà phê, nấu mì, pha nước tắm trẻ… nhanh gọn, tiện lợi.", "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/Untitled-1-780x433.jpg", "Bình đun siêu tốc Delites 1.8 lít ST18S04", 180, 315000m, 1000, null },
                    { 11, 1, "Bình đun siêu tốc Toshiba 1.7 lít KT-17SH2NV, sản phẩm thương hiệu Nhật Bản uy tín, thiết kế đơn giản, dễ sử dụng. Đun nước sôi nhanh, tiết kiệm thời gian công sức cho người nội trợ.", "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/-tongquan.jpg", "Bình đun siêu tốc Toshiba 1.7 lít KT-17SH2NV", 180, 550000m, 80, null },
                    { 12, 1, "Bình đun siêu tốc Sunhouse thiết kế sang trọng, hiện đại, dung tích 1.7 lít cung cấp đủ nước nóng cho gia đình 3 - 4 thành viên sử dụng", "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/Untitled-1-780x433.jpg", "Bình đun siêu tốc thủy tinh Sunhouse 1.7 lít SHD1217 Đen", 180, 425000m, 200, null },
                    { 13, 1, "Bình đun siêu tốc Delites kiểu dáng mềm mại, trang nhã, màu sắc rất nhẹ nhàng, tươi mát nhưng không kém phần ấn tượng, tạo cảm giác tươi mới cho không gian dùng. Dung tích 1.8 lít đủ dùng cho nhu cầu sử dụng gia đình 3 – 4 người: pha trà, cà phê, sữa, nấu mì, nấu nước tắm bé,… tiện dụng.", "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/-45.jpg", "Bình đun siêu tốc Delites 1.8 lít ST18DB01 ", 180, 355000m, 1000, null },
                    { 14, 1, "Bình đun siêu tốc Sunhouse SHD1330 dung tích 1.7 lít, công suất lớn 1850W, có thể tự ngắt khi nước sôi, khi cạn nước hoặc quá nhiệt, có lưới lọc cặn an toàn,... đáp ứng tốt nhu cầu sử dụng nước nóng trong việc pha trà, cà phê, nấu mì,...", "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/Tong-quan-1020x570.jpg", "Bình đun siêu tốc Sunhouse Mama 1.7 lít SHD1330", 180, 510000m, 150, null },
                    { 15, 1, "Bình đun nước siêu tốc Delites thiết kế đơn giản mà sang trọng và tinh tế, dung tích 1.7 lít dạng phổ thông dễ dùng tại gia đình, văn phòng nhỏ ít người,…", "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/a3-780x433.png", "Bình đun siêu tốc Delites 1.7 lít FD-625", 180, 535000m, 1000, null },
                    { 16, 1, "Bình đun siêu tốc Sunhouse SHD1382B màu sắc nổi bật, hoa văn nhẹ nhàng, dễ dùng cho mọi không gian gia đình.Bình dung tích 1.7 lít đủ dùng cho nhu cầu sử dụng gia đình 3 – 4 người: pha trà, cà phê, sữa, nấu mì, nấu nước tắm cho bé,… tiện dụng.", "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-binh-dun-sieu-toc-sunhouse-shd1382b.jpg", "Bình đun siêu tốc Sunhouse 1.7 lít SHD1382B", 180, 499000m, 1000, null },
                    { 17, 1, "Bình đun siêu tốc Toshiba vỏ ngoài sáng bóng, kiểu dáng sang trọng, dung tích 1.7 lít sử dụng thuận tiện tại gia đình, văn phòng nhỏ,...Công suất 1800 - 2150W đun nước nhanh sôi, chỉ chờ 6 - 7 phút nước nóng đã sẵn sàng cho nhu cầu sử dụng.", "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/a3-780x433.png", "Bình đun siêu tốc Toshiba 1.7 lít KT-17DR1NV", 180, 1115000m, 60, null },
                    { 18, 1, "Bình đun siêu tốc BlueStone màu đen sang trọng, dung tích 1.7 lít tiện dùng cho nhu cầu sử dụng thường nhật tại gia đình", "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/B4-780x433.jpg", "Bình đun siêu tốc BlueStone 1.7 lít KTB-3417", 180, 449000m, 1000, null },
                    { 19, 1, "Bình đun siêu tốc Rapido 1.7 lít RK1717 màu xanh đen trung tính, sang trọng, bình có dung tích 1.7 lít, công suất 1700W, ruột bình chất liệu inox 304 bền bỉ, không gây hại khi đun sôi, giúp người dùng đun nước an toàn.", "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-1.jpg", "Bình đun siêu tốc Rapido 1.7 lít RK1717", 180, 320000m, 1000, null },
                    { 20, 1, "Bình đun siêu tốc Toshiba màu đen mạnh mẽ, kết cấu chắc chắn, góp phần làm tăng tính thẩm mỹ cho gian bếp gia đình. Có dung tích 1.5 lít, tương đương với 8 ly nước, bình đun cung cấp đủ nước nóng mỗi ngày cho 1 người dùng.", "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/-tong-quan.jpg", "Bình đun siêu tốc Toshiba 1.5 lít KT-15DS1NV", 180, 849000m, 500, null },
                    { 21, 2, "Bếp từ Kangaroo sở hữu nhiều tính năng an toàn, đảm bảo yên tâm khi sử dụng:- Cảnh báo khi không có nồi trên bếp thông tin đến người dùng kịp thời xử lý.- Tính năng dừng bếp tạm thời khi bận rộn, khi kích hoạt lại bếp vẫn giữ nguyên chế độ đã cài đặt trước đó, tiết kiệm thời gian khởi động.- Tự ngắt khi bếp nóng quá tải bảo vệ động cơ, hạn chế các sự cố cháy nổ.- Tự ngắt khi không có nồi tránh lãng phí điện năng cho gia đình.- Tự nhận diện kích cỡ đáy nồi để phân bổ nhiệt lượng phù hợp.", "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516146987500.jpg", "Bếp từ đôi lắp âm Kangaroo KG855i", 720, 4990000m, 750, null },
                    { 22, 2, "Bếp từ thương hiệu Hafele của Đức, sản xuất và nhập khẩu nguyên chiếc từ Malaysia đảm bảo chất lượng, mẫu mã", "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/vi-vn-doi-hafele-hc-i2712a637983280837848266.jpg", "Bếp từ đôi lắp âm Hafele HC-I2712A (536.61.716)", 720, 8990000m, 1000, null },
                    { 23, 2, "Điểm qua những thông tin chung của bếp từ đôi Hafele HC-I2732A. Đây là sản phẩm thuộc dòng bếp từ đôi được thiết kế lắp âm hoặc lắp dương giúp sử dụng linh hoạt trong gian bếp. Đến từ thương hiệu 100 năm - Hafele (Đức), sản xuất và nhập khẩu nguyên chiếc từ Malaysia đảm bảo chất lượng, mẫu mã. Bếp từ sở hữu công suất tổng 4400W, mỗi vùng 2000W và có thể đạt 2200W khi sử dụng chức năng Booster gia nhiệt nhanh giúp rút ngắn thời gian đun sôi chất lỏng. Bếp được tích hợp bảng điều khiển cảm ứng trượt điều chỉnh linh hoạt 9 mức công suất chỉ với thao tác lướt nhẹ ngón tay. Đồng thời bếp từ Hafele được trang bị công nghệ Inverter tiết kiệm điện năng hiệu quả, giúp bếp hoạt động ổn định. Không thể bỏ qua chức năng hẹn giờ tắt bếp trong khoảng 1 - 99 phút giúp người dùng tiện nấu các món ninh, hầm mà không cần canh chừng tắt bếp. Ngoài ra bếp còn sở hữu những tính năng an toàn giúp người dùng an tâm sử dụng: khóa bảng điều khiển, cảnh báo mặt bếp nóng, tự nhận diện kích cỡ đáy nồi, dừng bếp tạm thời.\r\n\r\nNhìn chung, Hafele HC-I2732A sẽ là sự lựa chọn đáng tiền và hứa hẹn mang lại những trải nghiệm tích cực cho căn bếp gia đình. Lưu ý khi sử dụng bếp từ:- Chỉ sử dụng nồi/chảo có đáy nhiễm từ: inox 430, gang,... khi sử dụng bếp. Lưu ý: bếp phù hợp với nồi/chảo có đường kính đáy 12 - 26 cm.\r\n\r\nXem thêm: Những nồi sử dụng được trên bếp từ\r\n\r\n- Đảm bảo chỉ dùng bếp khi nguồn điện ổn định, điện áp không quá cao hoặc quá thấp. \r\n\r\n- Không sử dụng các vật sắc nhọn để cạy các vết bẩn bám trên mặt bếp, dễ gây trầy xước. - Nên dùng khăn vải mềm, miếng bọt biển khi làm sạch mặt bếp.", "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/vi-vn-hafele-hc-i2732a638277633375209456.jpg", "Bếp từ đôi lắp âm Hafele HC-I2732A", 720, 10900000m, 1000, null },
                    { 24, 2, "Yên tâm về mẫu mã và chất lượng khi sản phẩm đến từ thương hiệu Pramie - Đức, sản xuất tại Malaysia", "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/vi-vn-doi-pramie-2208-230721-04365710-copy-copy.jpg", "Bếp từ đôi lắp âm Pramie 2208", 720, 6890000m, 1000, null },
                    { 25, 2, "Bếp từ AVA AI-32 thiết kế 1 vùng nấu gọn đẹp, dễ đặt ở nhiều nơi, công suất lớn 2000W nấu ăn nhanh, có 6 chế độ nấu cài đặt sẵn, bảng điều khiển cảm ứng hiện đại, dễ tùy chỉnh và sử dụng nấu ăn thuận tiện trong gia đình hằng ngày.", "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-2.jpg", "Bếp từ AVA AI-32", 720, 900000m, 1000, null },
                    { 26, 2, "Bếp từ đôi Sunhouse thiết kế lắp âm hiện đại, có hai vùng nấu rộng rãi .Cho bạn chế biến được nhiều món ăn cùng lúc. Bạn có thể vừa nấu canh, vừa chiên xào thực phẩm một cách thoải mái và tiện lợi.", "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/doi-sunhouse-shb9111mt638017768064342909.jpg", "Bếp từ đôi lắp âm Sunhouse SHB9111MT", 720, 29990000m, 1000, null },
                    { 27, 2, "Bếp hồng ngoại đơn thiết kế hiện đại, màu sắc bắt mắt, nhỏ gọn thích hợp cho nhiều không gian dùng", "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/vi-vn-sunhouse-shd-6015-o-780x433.jpg", "Bếp hồng ngoại Sunhouse SHD 6015(EMC)", 720, 7490000m, 1000, null },
                    { 28, 2, "Bếp từ hồng ngoại lắp âm Hafele HC-H7321B là sản phẩm mới ra mắt năm 2023, của thương hiệu Đức, được sản xuất tại Malaysia. Bếp có thiết kế tinh tế, hiện đại, được trang bị công nghệ Inverter, bảng điều khiển độc lập cho từng vùng nấu tiện lợi cùng nhiều tiện ích, chức năng an toàn khác.", "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/317824-1020x570.jpg", "Bếp từ hồng ngoại lắp âm Hafele HC-H7321B", 720, 890000m, 1000, null },
                    { 29, 2, "Công suất tối đa 2000W có thể tùy chỉnh 10 mức linh hoạt theo món ăn", "https://cdn.tgdd.vn/Products/Images/1982/279571/ava-fym20-71-1.jpg", "Bếp từ AVA FYM20-71", 720, 990000m, 1000, null },
                    { 30, 2, "Bếp từ đơn gọn đẹp, mỏng, tiết kiệm không gian, phù hợp với những căn bếp có diện tích nhỏ", "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/galanz-ch211e-030821-0423500.jpg", "Bếp từ Galanz CH211E", 720, 7990000m, 1000, null },
                    { 31, 2, "Mặt bếp hồng ngoại bằng kính Ceramic - Kanger, dễ vệ sinh", "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-be%CC%82%CC%81p-ho%CC%82%CC%80ng-ngoa%CC%A3i-sanaky-snk-2524hgn.jpg", "Bếp hồng ngoại Sanaky SNK-2524HGN", 720, 1390000m, 1000, null },
                    { 32, 2, "Bếp hồng ngoại đơn thiết kế tinh tế, nhỏ gọn với 1 vùng nấu", "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117060.jpg", "Bếp hồng ngoại Rapido RC2000ES", 720, 790000m, 1000, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "Description", "ImageUrl", "Name", "WarrantyPeriod", "price", "quantity", "status" },
                values: new object[,]
                {
                    { 33, 2, "Bếp hồng ngoại thiết kế lắp đặt âm hiện đại, tiết kiệm không gian", "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/BeptudoiTQ-780x433.jpg", "Bếp hồng ngoại 3 vùng nấu lắp âm Hafele HC-R603D", 720, 12390000m, 1000, null },
                    { 34, 2, "Bếp từ 4 vùng nấu lắp âm Bosch PVQ731F15E tích hợp tính năng hút mùi siêu tiện lợi, nhập khẩu từ Tây Ban Nha, có 4 vùng nấu giúp thuận tiện chế biến nhiều món ăn cùng lúc, có tính năng liên kết vùng nấu để tạo ra vùng nấu lớn, cùng các tiện ích: hẹn giờ, chức năng Booster làm nóng nhanh,... là thiết bị gia dụng hiện đại, bền tốt cho căn bếp gia đình.", "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-1-1.jpg", "Bếp từ 4 vùng nấu lắp âm tích hợp hút mùi Bosch PVQ731F15E", 720, 44790000m, 1000, null },
                    { 35, 2, "Yên tâm về mẫu mã và chất lượng khi sản phẩm đến từ thương hiệu Pramie - Đức, sản xuất tại Malaysia", "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405789578258494.jpg", "Bếp từ 3 vùng nấu lắp âm Bosch PUJ611BB5E", 720, 11689000m, 1000, null },
                    { 36, 3, "Smart Tivi Samsung 4K 55 inch UA55AU7002 nâng tầm trải nghiệm xem với khung hình 4K sắc nét, bộ xử lý Crystal 4K cho màu sắc tái tạo sống động, các chi tiết rõ ràng nhờ công nghệ Contrast Enhancer, hệ điều hành Tizen OS 6.0 thân thiện, làm việc tại nhà thuận tiện cùng chế độ máy tính PC trên tivi.\r\n\r\n", "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-1.jpg", "Smart Tivi Samsung 4K 55 inch UA55AU7002", 720, 10400000m, 1000, null },
                    { 37, 3, "Google Tivi QLED TCL 4K 65 inch 65Q646 sở hữu màn hình 65 inch độ phân giải 4K sắc nét. Trang bị các công nghệ hình ảnh và âm thanh nổi bật như Dolby Vision cho độ sáng vượt trội, hình ảnh chi tiết và trung thực, Micro Dimming kiểm soát đèn nền hay âm thanh vòm Dolby Atmos nâng cấp trải nghiệm nghe nhìn. Bên cạnh đó, tivi TCL được trang bị hệ điều hành Google TV với giao diện thân thiện, dễ sử dụng cùng kho ứng dụng phong phú.", "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-01.jpg", "Google Tivi QLED TCL 4K 65 inch 65Q646", 720, 11990000m, 1000, null },
                    { 38, 3, "Smart Tivi Samsung 4K Crystal UHD 55 inch UA55BU8000 sở hữu thiết kế tinh tế, màn hình LED viền (Edge LED), VA LCD siêu mỏng đi cùng chất lượng hình ảnh 4K cực nét, công nghệ OTS Lite điều chỉnh âm thanh theo chuyển động của vật thể, hệ điều hành Tizen™ trực quan, thân thiện và vô số các tiện ích giải trí đi kèm chắc chắn đáp ứng nhu cầu giải trí cơ bản của gia đình bạn.", "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761440968453.jpg", "Smart Tivi Samsung 4K Crystal UHD 55 inch UA55BU8000", 720, 11690000m, 1000, null },
                    { 39, 3, "Smart Tivi LG 4K 65 inch 65UQ8000PSC mang đến cảm xúc đắm chìm khi trải nghiệm nghe nhìn, với khung hình 4K tương phản rực rỡ từ HDR10 Pro, âm thanh chân thực tinh chỉnh theo nội dung qua AI Sound, cùng với 1 thiết kế tinh giản đầy sang chảnh, và kho ứng dụng khổng lồ từ webOS 22 đáp ứng hoàn hảo nhu cầu giải trí của người dùng.", "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/smart-lg-4k-65-inch-65uq8000psc638043668474988583.jpg", "Smart Tivi LG 4K 65 inch 65UQ8000PSC", 720, 13490000m, 1000, null },
                    { 40, 3, "Smart Tivi Samsung 4K 43 inch UA43AU7002 tái tạo khung hình 4K sắc nét, chân thực và sống động nhờ bộ xử lý Crystal 4K, màu sắc rực rỡ cùng PurColor và âm thanh mạnh mẽ, sống động Q-Symphony, Adaptive Sound, mang đến trải nghiệm xem thích thú, cùng kho ứng dụng Tizen™ phong phú thỏa mãn khung giờ giải trí của mọi thành viên trong gia đình.", "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-1.jpg", "Smart Tivi Samsung 4K 43 inch UA43AU7002", 720, 6990000m, 1000, null },
                    { 41, 3, "Smart Tivi QLED 4K 55 inch Samsung QA55Q60C tinh giản trong thiết kế, khung hình 55 inch với độ phân giải 4K sắc nét, bộ xử lý Quantum 4K Lite, công nghệ OTS Lite mang đến trải nghiệm hình ảnh và âm thanh chân thật, hệ điều hành Tizen™ giao diện trực quan dễ sử dụng, tìm kiếm bằng giọng nói tiếng Việt, gọi video qua Google Duo,…", "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-1.jpg", "Smart Tivi QLED 4K 55 inch Samsung QA55Q60C", 720, 14550000m, 1000, null },
                    { 42, 3, "Smart Tivi Samsung 4K 55 inch UA55CU8000 đem đến trải nghiệm tuyệt đỉnh nhờ màn hình 55 inch độ phân giải 4K với hơn 8 triệu điểm ảnh, khung hình sống động nhờ bộ vi xử lý Crystal 4K, âm thanh chuyển động theo hình ảnh OTS Lite, hệ điều hành Tizen™ đa nhiệm, dễ sử dụng cùng nhiều tiện ích thông minh khác.", "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-1.jpg", "Smart Tivi Samsung 4K 55 inch UA55CU8000", 720, 13400000m, 1000, null },
                    { 43, 3, "Smart Tivi NanoCell LG 4K 65 inch 65NANO76SQA cuốn hút tầm nhìn nhờ màn hình 65 inch thanh mảnh, nội dung hiển thị sắc nét với độ phân giải 4K, tối ưu qua bộ xử lý α5 Gen5 AI 4K, âm thanh sống động cùng công nghệ AI Sound, kho ứng dụng webOS 22 phong phú và điều khiển đầy thông minh qua Magic Remote, AI ThinQ mang đến trải nghiệm tuyệt vời.", "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-001.jpg", "Smart Tivi NanoCell LG 4K 65 inch 65NANO76SQA", 720, 13990000m, 1000, null },
                    { 44, 3, "Google Tivi TCL 43 inch 43S5400 tái tạo hình ảnh chân thực với độ phân giải Full HD, công nghệ HDR10, khung hình có độ tương phản cao nhờ hỗ trợ công nghệ Micro Dimming, giả lập âm thanh vòm sống động với công nghệ Dolby Audio, hệ điều hành Google TV với kho ứng dụng đa dạng. ", "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489860884025.jpg", "Google Tivi TCL 43 inch 43S5400", 720, 5890000m, 1000, null },
                    { 45, 3, "Smart Tivi QLED 4K 65 inch Samsung QA65Q60C sở hữu thiết kế thanh lịch, cung cấp màn hình trải nghiệm tuyệt đẹp với độ phân giải 4K sắc nét, khung hình sống động nhờ bộ vi xử lý Quantum 4K Lite, tận hưởng trải nghiệm đắm chìm đa dạng tỷ lệ màn hình với Super Ultra Wide Game View & Game Bar, âm thanh chuyển động theo hình ảnh OTS Lite, hỗ trợ tìm kiếm bằng giọng nói tiếng Việt,… cùng nhiều tiện ích thông minh khác.", "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-01.jpg", "Smart Tivi QLED 4K 65 inch Samsung QA65Q60C", 720, 17800000m, 1000, null },
                    { 46, 3, "Google Tivi Sony 4K KD-43X77L có kích thước màn hình 43 inch, viền tivi được thiết kế mỏng, đen, giúp bạn dễ dàng tập trung vào màn hình, hình ảnh sắc nét chuẩn 4K với bộ xử lý hình ảnh chuẩn 4K kết hợp cùng với âm thanh vòm Dolby Audio cho bạn trải nghiệm xem phim đầy lôi cuốn.", "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/vi-vn-google-tivi-sony-4k-43-inch-kd-43x77l-01.jpg", "Google Tivi Sony 4K 43 inch KD-43X77L", 720, 11090000m, 1000, null },
                    { 47, 3, "Google Tivi TCL 32 inch 32S5400 có vẻ ngoài tối giản, kích thước nhỏ gọn phù hợp cho các không gian nhỏ hẹp, hiển thị khung hình giàu sắc thái, chi tiết nhờ công nghệ HDR10, HLG, hình ảnh rõ ràng, sống động với công nghệ Micro Dimming, công nghệ Dolby Audio cho trải nghiệm âm thanh sâu lắng, lôi cuốn, tìm kiếm bằng giọng nói tiếng Việt với remote tích hợp micro và Google Assistant.", "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490697986708.jpg", "Google Tivi TCL 32 inch 32S5400", 720, 3990000m, 1000, null },
                    { 48, 3, "Smart Tivi NanoCell LG 4K 55 inch 55NANO76SQA, một tuyệt tác đến từ LG với thiết kế đơn giản, tinh tế, tái hiện sống động cuộc sống thực lên màn hình 4K trên dải màu Nano Color, tối ưu hiển thị và âm thanh nhờ bộ xử α5 Gen5 AI 4K, AI Sound Pro tinh chỉnh âm thanh lôi cuốn, cùng mang lại trải nghiệm nghe nhìn hoàn hảo trên các lựa chọn phong phú từ hệ điều hành WebOS 22.", "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-001-1020x570.jpg", "Smart Tivi NanoCell LG 4K 55 inch 55NANO76SQA", 720, 21090000m, 1000, null },
                    { 49, 3, "Smart Tivi Toshiba 43 inch 43V31MP mang đến hình ảnh Full HD rõ đẹp, sống động với bộ xử lý Regza Engine HG, công nghệ Essential PQ tái tạo chi tiết, màu sắc trung thực, công nghệ Dolby Audio cho âm thanh vòm mạnh mẽ, hệ điều hành Vidaa U7 cùng thư viện ứng dụng đa dạng, dễ dàng sử dụng.", "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996430698528.jpg", "Smart Tivi Toshiba 43 inch 43V31MP", 720, 7350000m, 1000, null },
                    { 50, 3, "Smart Tivi Samsung 4K 65 inch UA65CU8000 sở hữu thiết kế trang nhã, tinh giản nhưng sang đẹp, màn hình UHD 4K cùng tấm nền VA LCD cho hình ảnh sắc nét, sống động với công nghệ Dynamic Crystal Color, bộ xử lý Crystal 4K hỗ trợ cải thiện màu sắc hiển thị kết hợp với tính năng chống nhiễu, tái tạo hình ảnh vượt trội.", "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-1.jpg", "Smart Tivi Samsung 4K 65 inch UA65CU8000", 720, 14490000m, 1000, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 17, 16, 36, 0, 404, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "Description", "ImageUrl", "Name", "WarrantyPeriod", "price", "quantity", "status" },
                values: new object[,]
                {
                    { 51, 4, "", "", "Tủ lạnh Samsung Inverter 236 lít RT22M4032BY/SV", 720, 6890000m, 1000, null },
                    { 52, 4, "Tủ lạnh Samsung Inverter 256 lít RT25M4032BU/SV được trang bị ngăn đông mềm -1 độ C Optimal Fresh Zone có tác dụng giữ thực phẩm tươi sống còn trọn dưỡng chất, hoàn toàn không đông đá ở nhiệt độ đông mềm lý tưởng -1°C. Như thế, thịt cá hoàn toàn không bị đông đá giúp bạn có thể nấu ăn ngay không cần rã đông, dễ dàng cắt thái và chế biến trong ngày.", "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/samsung-rt25m4032bu-sv-140821-0914220.png", "Tủ lạnh Samsung Inverter 256 lít RT25M4032BU/SV", 720, 6890000m, 1000, null },
                    { 53, 4, "Công nghệ Nano Fresh Ag+ ứng dụng tính chất của các ion Ag+, giúp diệt khuẩn và ngăn ngừa sự phát triển của vi khuẩn nấm mốc, giữ bầu không khí luôn sạch khuẩn và thoáng mát. Với sự hỗ trợ này, chúng ta có thể thoải mái lưu trữ thực phẩm cho gia đình nhiều ngày mà không phải lo đến việc ám mùi. ", "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-210821-1005140.jpg", "Tủ lạnh Aqua 130 lít AQR-T150FA(BS)", 720, 4590000m, 1000, null },
                    { 54, 4, "Tủ lạnh Aqua Inverter 189 lít AQR-T220FA(FB) có khả năng làm lạnh đa chiều, giúp bảo quản thực phẩm tối ưu, giảm thiểu tỷ lệ hư hỏng. Ngoài ra, tủ lạnh cũng mang lại hiệu quả tiết kiệm điện nhờ sử dụng công nghệ Twin Inverter.", "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798785782753.jpg", "Tủ lạnh Aqua Inverter 189 lít AQR-T220FA(FB)", 720, 5090000m, 1000, null },
                    { 55, 4, "Với kiểu tủ ngăn đá trên, chiếc tủ lạnh Toshiba Inverter 180 lít GR-B22VU UKG được thiết kế nhỏ gọn nhưng vẫn toát lên vẻ đẹp hiện đại bởi tông màu đen tuyền sang trọng. Dễ dàng đặt ở bất kì vị trí nào trong nhà, từ phòng khách đến phòng bếp.", "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/1-1020x570.jpg", "Tủ lạnh Toshiba Inverter 180 lít GR-B22VU UKG ", 720, 4990000m, 1000, null },
                    { 56, 4, "Tủ lạnh Panasonic Inverter 170 lít NR-BA190PPVN sử dụng công nghệ biến tần Inverter có khả năng điều chỉnh vòng quay của máy nén giúp duy trì làm lạnh ổn định, hoạt động êm ái, ít gây tiếng ồn hơn và tiết kiệm được điện năng hiệu quả. ", "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/panasonic-nr-ba190ppvn-150821-0310380.jpg", "Tủ lạnh Panasonic Inverter 170 lít NR-BA190PPVN", 720, 6790000m, 1000, null },
                    { 57, 4, "Tủ lạnh LG Inverter 217 Lít GV-B212WB có khả năng tiết kiệm điện và duy trì nhiệt độ ổn định giúp thực phẩm luôn tươi ngon. Hơn nữa, tủ lạnh còn có thể làm lạnh nhanh và duy trì các loại đồ uống ở vị trí cánh cửa tủ một cách tối ưu.", "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb1.jpg", "Tủ lạnh LG Inverter 217 Lít GV-B212WB", 720, 5590000m, 1000, null },
                    { 58, 4, "Tủ lạnh Samsung Inverter 382 lít RT38CG6584B1SV được trang bị ngăn đông mềm linh hoạt 4 chế độ Optimal Fresh+ chế biến thực phẩm không cần rã đông, mở rộng không gian bảo quản thực phẩm thêm 20 lít với công nghệ SpaceMax, giảm hao phí điện năng với công nghệ Digital Inverter, hệ thống lọc diệt khuẩn Active Fresh Filter khử khuẩn, ngăn mùi hôi trong tủ, chế độ làm lạnh nhanh Power Cool cùng công nghệ làm lạnh vòm All-around Cooling giữ được độ tươi ngon của thực phẩm.", "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-1.jpg", "Tủ lạnh Samsung Inverter 382 lít RT38CG6584B1SV", 720, 14390000m, 1000, null },
                    { 59, 4, "Bộ lọc than hoạt tính Deodorizer trên tủ lạnh Samsung Inverter 208 lít RT20HAR8DBU/SV giúp loại bỏ hoàn toàn những mùi hôi khó chịu, các nấm mốc và vi khuẩn phát sinh bên trong tủ, để không khí trong tủ lạnh luôn tươi mát và thực phẩm trọn vị tươi ngon.", "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/samsung-rt20har8dbu-sv-140821-0959250.jpg", "Tủ lạnh Samsung Inverter 208 lít RT20HAR8DBU/SV", 720, 6290000m, 1000, null },
                    { 60, 4, "Tủ lạnh Samsung Inverter 280 lít RB27N4010BU/SV được thiết kế theo phong cách châu Âu, tối giản chi tiết mang lại sự thanh nhã, giúp cho không gian bếp của bạn có một dấu ấn riêng. Chất liệu cửa tủ là kim loại phủ sơn bóng giả gương làm nổi bật, tôn lên vẻ sang trọng cho tổng thể.", "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/1-1020x570-1020x570.jpg", "Tủ lạnh Samsung Inverter 280 lít RB27N4010BU/SV", 720, 9290000m, 1000, null },
                    { 61, 4, "Tủ lạnh LG Inverter 519 lít GR-B256JDS thuộc dòng tủ lạnh side by side được trang bị công nghệ Smart Inverter giúp tiết kiệm điện năng. Bên cạnh đó, công nghệ làm lạnh đa chiều mang hơi lạnh lan tỏa khắp các ngăn.", "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667253103233.jpg", "Tủ lạnh LG Inverter 519 lít Side By Side GR-B256JDS", 720, 14990000m, 1000, null },
                    { 62, 4, "Tủ lạnh Aqua Inverter 456 lít AQR-M525XA(FB) thiết kế có thể bảo quản thực phẩm khô và ẩm riêng biệt nhờ công nghệ cân bằng độ ẩm HCS, giúp duy trì được độ tươi ngon cũng như kéo dài thời gian bảo quản thực phẩm lâu hơn. Chưa hết, tủ lạnh này còn có khả năng tiết kiệm điện và khử mùi hôi tối ưu.", "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007604187206283.jpg", "Tủ lạnh Aqua Inverter 456 lít Multi Door AQR-M525XA(FB)", 720, 14990000m, 1000, null },
                    { 63, 4, "Tủ lạnh Toshiba Inverter 460 lít GR-RS600WI-PMV(37)-SG có khả năng kết nối mạng, giúp người dùng điều khiển và kiểm soát tủ lạnh từ xa một cách thuận tiện qua ứng dụng trên điện thoại. Không những thế, tủ lạnh Toshiba 460 lít còn cho khả năng làm lạnh nhanh chóng và đều, giúp bảo quản thực phẩm được tốt hơn.", "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760502471984.jpg", "Tủ lạnh Toshiba Inverter 460 lít Side By Side GR-RS600WI-PMV(37)-SG", 720, 11490000m, 1000, null },
                    { 64, 4, "Tủ lạnh Aqua Inverter 347 lít AQR-T400FA(WFB) được thiết kế màu đen ánh kim sang trọng, có trang bị ngăn lấy nước bên ngoài tiện lợi. Hơn nữa, tủ lạnh còn được trang bị ngăn đông mềm Magic Zone -3°C, giúp duy trì độ tươi ngon và dưỡng chất của thực phẩm tối ưu, thậm chí có thể chế biến thực phẩm nhanh chóng mà không cần chờ rã đông.", "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404751829339.jpg", "Tủ lạnh Aqua Inverter 347 lít AQR-T400FA(WFB)", 720, 9290000m, 1000, null },
                    { 65, 4, "Tủ lạnh Aqua Inverter 279 lít AQR-T300FA(WFB) thiết kế màu đen sang trọng, công nghệ làm lạnh đa chiều giữ thực phẩm tươi lâu hơn, công nghệ làm lạnh gián tiếp giúp thực phẩm trong tủ không bị đóng tuyết, giữ thực phẩm tươi ngon. Ngoài ra, công nghệ Twin Inverter giúp tủ lạnh tiết kiệm điện năng hiệu quả.", "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343059097613.jpg", "Tủ lạnh Aqua Inverter 279 lít AQR-T300FA(WFB)", 720, 7690000m, 1000, null },
                    { 66, 4, "Thịt cá tươi ngon, ăn trong ngày không cần rã đông với ngăn đông mềm -1 độ C Optimal Fresh Zone", "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/samsung-rt22m4032by-sv-140821-0917590.jpg", "", 720, 5990000m, 1000, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "CategoryName",
                value: "Điện thoại");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 17, 15, 39, 27, 221, DateTimeKind.Local).AddTicks(7347));
        }
    }
}
