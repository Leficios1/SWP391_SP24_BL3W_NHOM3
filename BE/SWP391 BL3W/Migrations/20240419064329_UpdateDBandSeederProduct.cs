using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBandSeederProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ImageUrl", "price" },
                values: new object[] { "Thịt cá tươi ngon, ăn trong ngày không cần rã đông với ngăn đông mềm -1 độ C Optimal Fresh Zone", "https://cdn.tgdd.vn/Products/Images/1943/220325/TimerThumb/Frame-1-600x600.png ", 5990000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Name", "price" },
                values: new object[] { 5, "Máy giặt Sharp 7.5 kg ES-Y75HV-S có khối lượng giặt 7.5 kg phù hợp với gia đình có 2 - 3 thành viên, được trang bị 4 chương trình giặt đáp ứng được nhu cầu giặt giũ cơ bản của gia đình.", "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/6-1020x570.jpg", "Máy    Sharp 7.5 Kg ES-Y75HV-S", 3690000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "Description", "ImageUrl", "Name", "WarrantyPeriod", "price", "quantity", "status" },
                values: new object[,]
                {
                    { 67, 5, "Máy giặt Samsung Inverter 9 kg WW90T3040WW/SV tích hợp công nghệ giặt nước nóng Hot Wash giúp dễ dàng đánh bay các vết bẩn cứng đầu khó loại bỏ, đồng thời giúp diệt khuẩn, ngừa dị ứng, cùng các tiện ích đi kèm khác.", "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618083819165.jpg", "Máy giặt Samsung Inverter 9 kg WW90T3040WW/SV", 720, 6490000m, 1000, null },
                    { 68, 5, "Máy giặt Panasonic Inverter 9.5 Kg NA-FD95V1BRV được tích hợp công nghệ nước nóng StainMaster+ có khả năng xử lý các vết bẩn hiệu quả với nhiệt độ nước thích hợp, loại bỏ các vi khuẩn gây hại giúp bảo vệ làn da tốt hơn, đồng thời còn giúp đánh bật các vết bẩn cứng đầu dễ dàng nhờ các chương trình giặt chuyên biệt.", "https://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-tong-quan-panasonic-na-fd95v1brv-1.jpg", "Máy giặt Panasonic Inverter 9.5 Kg NA-FD95V1BRV", 720, 10690000m, 1000, null },
                    { 69, 5, "Máy giặt được trang bị động cơ Digital Inverter với nam châm vĩnh cửu, giảm tối đa ma sát khi máy giặt vận hành, giúp tiết kiệm điện năng, vận hành êm ái hơn so với động cơ thông thường sử dụng chổi than. Đặc biệt, động cơ Digital Inverter có độ bền vượt trội và được bảo hành đến 11 năm.", "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-01.jpg", "Máy giặt Samsung Inverter 8kg WW80T3020WW/SV", 720, 4990000m, 1000, null },
                    { 70, 5, "Máy giặt Toshiba 7 Kg AW-L805AV (SG) có màu xám bạc vừa toát lên vẻ sang trọng, hiện đại vừa đảm bảo vệ sinh hơn trong quá trình sử dụng. ", "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-2-1020x570.jpg", "Máy giặt Toshiba 7 Kg AW-L805AV (SG)", 720, 3990000m, 1000, null },
                    { 71, 5, "Máy giặt Samsung Inverter 12 kg WA12CG5745BVSV có khả năng đánh bay vết bẩn cứng đầu hiệu quả nhờ công nghệ giặt bong bóng siêu mịn Eco Bubble, công nghệ Digital Inverter tiết kiệm điện năng, vận hành êm ái, giặt sạch siêu tốc 29 phút đảm bảo hiệu quả sạch sâu.", "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204008922288.jpg", "Máy giặt Samsung Inverter 12 kg WA12CG5745BVSV", 720, 8990000m, 1000, null },
                    { 72, 5, "Máy giặt Panasonic Inverter 10.5 Kg NA-FD10VR1BV tích hợp công nghệ giặt nước nóng StainMaster Plus với nhiệt độ nước giặt có thể lên đến 60 độ C, máy giặt có công nghệ giặt nước nóng này không chỉ đánh bay các vết bẩn cứng đầu như: Bùn đất, dầu mỡ, nước sốt,... mà còn có thể tiêu diệt các loại vi khuẩn và tác nhân gây dị ứng có trên quần áo, bảo vệ sức khỏe cho cả gia đình bạn.", "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/tong-quan-panasonic-na-fd10vr1bv-1-1020x570.jpg", "Máy giặt Panasonic Inverter 10.5 Kg NA-FD10VR1BV", 720, 12090000m, 1000, null },
                    { 73, 5, "Với kháng sinh kháng khuẩn ABT, mâm giặt được phun một dung dịch đặc biệt, kháng khuẩn đến 99,99% và ngăn nấm mốc phát triển bên trong lồng giặt. Bảo vệ sức khỏe toàn diện cho người sử dụng. Sản phẩm thích hợp cho các gia đình có con nhỏ, người dễ bị kích ứng với vi khuẩn, bụi bẩn.", "https://cdn.tgdd.vn/Products/Images/1944/242732/Slider/1-1020x570-1.jpg", "Máy giặt Aqua 8.8 KG AQW-FR88GT.BK", 720, 5990000m, 1000, null },
                    { 74, 5, "Máy giặt Samsung Inverter 14kg WA14CG5745BVSV có khả năng đánh bay vết bẩn cứng đầu hiệu quả nhờ công nghệ giặt bong bóng siêu mịn Eco Bubble, công nghệ Digital Inverter tiết kiệm điện năng vận hành êm ái, giặt sạch siêu tốc 29 phút đảm bảo hiệu quả sạch sâu.", "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800871763098-1020x570.jpg", "Máy giặt Samsung Inverter 14 kg WA14CG5745BVSV", 720, 10090000m, 1000, null },
                    { 75, 5, "Máy giặt Electrolux UltimateCare 100 Inverter 9 kg EWF9025DQWB có khả năng tiết kiệm điện nhờ sử dụng công nghệ Inverter. Hơn nữa, máy giặt còn giảm thiểu tác nhân gây dị ứng trên làn da người với công nghệ giặt nước nóng và công nghệ giặt hơi nước tiện lợi.", "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb1.jpg", "Máy giặt Electrolux UltimateCare 100 Inverter 9 kg EWF9025DQWB", 720, 7990000m, 1000, null },
                    { 76, 5, "Máy giặt Aqua Inverter 9 kg AQD- D902G BK sở hữu động cơ truyền động trực tiếp DD Inverter giúp máy vận hành êm ái và tiết kiệm điện năng. Chương trình giặt thông minh AI tự động cân chỉnh lượng nước và thời gian dựa trên khối lượng giặt giúp tối ưu chu trình giặt giũ.", "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/01-1020x571.jpg", "Máy giặt Aqua Inverter 9 kg AQD- D902G BK", 720, 6990000m, 1000, null },
                    { 77, 5, "Máy giặt LG TurboDrum Inverter 9 kg T2109VSAB thuộc kiểu máy giặt lồng đứng cùng với bảng điều khiển nằm ở phía trước quen thuộc, chất liệu vỏ máy được làm bằng kim loại sơn tĩnh điện bền bỉ và giảm thiểu tình trạng trầy xước trong quá trình sử dụng. ", "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/may-giat-lg-t2109vsab637679232549430455.jpg", "Máy giặt LG TurboDrum Inverter 9 kg T2109VSAB", 720, 5990000m, 1000, null },
                    { 78, 5, "Máy giặt Samsung AI Inverter 9 kg WW90TP44DSB/SV ứng dụng công nghệ AI Wash hiện đại với 4 cảm biến có thể cảm nhận khối lượng và độ bẩn áo quần, từ đó tối ưu lượng nước, lượng nước giặt, nước xả và thời gian giặt sao cho giặt sạch hiệu quả mà không tốn nhiều công sức.", "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/01-1020x570.jpg", "Máy giặt Samsung AI Inverter 9kg WW90TP44DSB/SV", 720, 9490000m, 1000, null },
                    { 79, 5, "Máy giặt Casper 7.5 kg WT-75NG1 có khả năng tiết kiệm điện và nước hiệu quả nhờ tích hợp công nghệ suy luận ảo Fuzzy Logic hiện đại. Không những thế, mẫu máy giặt Casper này còn lần đầu tiên được trang bị chế độ sấy gió AirDry, giúp rút ngắn thời gian phơi quần áo đáng kể.", "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638356597640417536.png", "Máy giặt Casper 7.5 kg WT-75NG1 ", 720, 3990000m, 1000, null },
                    { 80, 5, "Máy giặt Aqua Inverter 9.5 kg AQD-A952J BK được thiết kế theo kiểu dáng máy giặt lồng ngang hiện đại, được trang bị công nghệ cân bằng AI DBT giúp máy hoạt động ổn định, êm ái, tăng thêm không gian sống cho gia đình bởi kết cấu máy siêu mỏng, tiết kiệm diện tích. ", "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpg", "Máy giặt Aqua Inverter 9.5 kg AQD-A952J BK", 720, 7690000m, 1000, null },
                    { 81, 6, "Nồi cơm điện cao tần Sunhouse kiểu dáng đơn giản, chắc chắn, lớp vỏ sáng bóng tạo nên nét sang trọng riêng của một nồi cơm điện tử", "https://cdn.tgdd.vn/Products/Images/1922/131925/sunhouse-mama-shd8955-0-600x600.jpg", "Nồi cơm điện cao tần Sunhouse 1.5 lít SHD8955", 720, 1890000m, 1000, null },
                    { 82, 6, "Nồi cơm điện tử Sharp 1.8 lít KS-COM183MV-WH với nhiều chế độ cài sẵn, công nghệ nhiệt 3D nấu cơm ngon, hẹn giờ đến 24 giờ, bảng điều khiển tiếng Việt dễ hiểu,... là công cụ đắc lực trong căn bếp gia đình.", "https://cdn.tgdd.vn/Products/Images/1922/296809/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh-021122-102925-600x600.jpg", "Nồi cơm điện tử Sharp 1.8 lít KS-COM183MV-WH", 720, 990000m, 1000, null },
                    { 83, 6, "Nồi cơm điện Sunhouse Mama có kiểu dáng thon gọn, màu đỏ trắng nổi bật, vỏ nồi bóng loáng, sang trọng tăng tính thẩm mỹ cho mọi không gian", "https://cdn.tgdd.vn/Products/Images/1922/72067/sunhouse-mama-shd-8661-220923-113258-600x600.jpg", "Nồi cơm nắp gài Sunhouse 1.8 lít SHD 8661", 720, 1440000m, 1000, null },
                    { 84, 6, "Nồi cơm điện Delites với mẫu mã trẻ trung rất phù hợp nhiều sở thích người dùng", "https://cdn.tgdd.vn/Products/Images/1922/152969/delites-ncg1805-250823-101131-600x600.jpg", "Nồi cơm nắp gài Delites 1.8 lít NCG1805", 720, 400000m, 1000, null },
                    { 85, 6, "Nồi cơm điện nắp gài BlueStone 1.8 lít RCB-5520 trang bị công nghệ 1D nấu cơm chín nhanh, lòng nồi hợp kim nhôm phủ chống dính bền tốt, điều chỉnh bằng nút gạt dễ sử dụng,... là sản phẩm tiện lợi hỗ trợ chế biến những bữa cơm thơm ngon cho gia đình.", "https://cdn.tgdd.vn/Products/Images/1922/189688/bluestone-rcb-5520-050124-113008-600x600.jpg", "Nồi cơm nắp gài BlueStone 1.8 lít RCB-5520", 720, 700000m, 1000, null },
                    { 86, 6, "Nồi cơm nắp gài Sunhouse 1 lít SHD8208C kiểu dáng nhỏ gọn, thanh lịch, màu sắc tươi sáng", "https://cdn.tgdd.vn/Products/Images/1922/203417/Slider/Untitled-1-780x433-1a-780x433.jpg", "Nồi cơm nắp gài Sunhouse 1 lít SHD8208C", 720, 490000m, 1000, null },
                    { 87, 6, "Nồi cơm điện Delites NCR1502 màu sắc hiện đại, sang trọng, kiểu dáng trẻ trung bắt mắt, sản phẩm đẹp cho không gian dùng thêm đẹp\r\n", "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/no%CC%82%CC%80i6-780x433a-780x433.jpg", "Nồi cơm nắp rời Delites 1.5 lít NCR1502", 720, 349000m, 1000, null },
                    { 88, 6, "Nồi cơm nắp gài Sunhouse 1.2 lít SHD8217W thiết kế gọn nhẹ, điều chỉnh bằng nút gạt đơn giản, công nghệ 1D nấu cơm chín nhanh, giúp phục vụ những bữa cơm nóng hổi cho gia đình.", "https://cdn.tgdd.vn/Products/Images/1922/275584/Slider/vi-vn-sunhouse-12-lit-shd8217w-1.jpg", "Nồi cơm nắp gài Sunhouse 1.2 lít SHD8217W", 720, 540000m, 1000, null },
                    { 89, 6, "Nồi cơm điện Delites sang trọng với vỏ kim loại phủ màu nâu đồng bắt mắt, sang trọng, tạo điểm nhấn trong không gian dùng\r\n", "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-noi-com-nap-roi-delites-18-lit-rc-10w003a-780x433-a-780x433.jpg", "Nồi cơm nắp rời Delites 1.8 lít RC-10W003", 720, 430000m, 1000, null },
                    { 90, 6, "Nồi cơm điện có dung tích 1 lít thích hợp để nấu cơm cho 2 - 4 người dùng", "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/Untitled-1-780x433(8)-a-780x433.jpg", "Nồi cơm nắp gài Toshiba 1 lít RC-10JH2PV(B)", 720, 550000m, 1000, null },
                    { 91, 6, "Nồi cơm điện nắp gài thiết kế màu sắc nhã nhặn, kiểu dáng sang trọng phù hợp với mọi gian bếp trong gia đình", "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928470.jpg", "Nồi cơm nắp gài AVA 1 lít JRC-100P", 720, 490000m, 1000, null },
                    { 92, 6, "Nồi cơm điện Toshiba RC-18NMFVN(WT) thiết kế chắc chắn, màu trắng sang trọng", "https://cdn.tgdd.vn/Products/Images/1922/92601/toshiba-rc-18nmfvn-wt-250823-102810-600x600.jpg", "Nồi cơm điện tử Toshiba 1.8 lít RC-18NMFVN(WT)", 720, 2890000m, 1000, null },
                    { 93, 6, "Nồi cơm nắp gài Toshiba 1.8 lít RC-18JH2PV(B) thiết kế hiện đại, màu sắc trẻ trung phù hợp mọi căn bếp", "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/noi-com-nap-gai-toshiba-rc-18jh2pv-b-18l637834603189310546.jpg", "Nồi cơm nắp gài Toshiba 1.8 lít RC-18JH2PV(B)", 720, 650000m, 1000, null },
                    { 94, 6, "Nồi cơm điện Sunhouse mama SHD8903 thiết kế gọn gàng, vỏ nồi bằng thép không gỉ bóng đẹp, bắt mắt, có tính thẩm mỹ cao", "https://cdn.tgdd.vn/Products/Images/1922/131916/sunhouse-mama-shd8903-thumb-600x600-2.jpg", "Nồi cơm điện tử Sunhouse mama 1.8 lít SHD8903 ", 720, 1290000m, 1000, null },
                    { 95, 6, "Nồi cơm điện tử Toshiba 1.8 lít RC-18DR2PV(K) thiết kế quai xách dễ cầm, màu sắc sang trọng với dung tích phù hợp cho gia đình 4 - 6 người", "https://cdn.tgdd.vn/Products/Images/1922/220499/noi-com-dien-tu-toshiba-rc-18dr2pv-k-18l-thumb-600x600-1.jpg", "Nồi cơm điện tử Toshiba 1.8 lít RC-18DR2PV(K)", 720, 2290000m, 1000, null },
                    { 96, 7, "Loa kéo Karaoke Dalton TS-15G600X 600W có thiết kế đẹp mắt với tông màu đen chủ đạo mạnh mẽ phù hợp với nhiều không gian. Thân loa karaoke làm bằng gỗ cao cấp cho chất âm tốt hơn cũng như tạo sự sang trọng cho loa.\r\n\r\n", "https://cdn.tgdd.vn/Products/Images/2162/214631/dalton-ts-15g600x-270223-020348-600x600.jpg", "Loa kéo Karaoke Dalton TS-15G600X 600W", 720, 7690000m, 1000, null },
                    { 97, 7, "Mang tiệc tùng trở nên sống động với loa di động Nanomax S-820. Với công suất âm thanh mạnh mẽ lên đến 400W, kết nối Bluetooth và thiết kế dễ mang đi, loa này hoàn hảo cho các buổi hát karaoke hoặc các sự kiện ngoài trời.", "https://cdn.tgdd.vn/Products/Images/2162/278796/loa-keo-karaoke-nanomax-s-820-400w-270223-021529-600x600.jpg", "Loa kéo Nanomax S-820", 720, 3770000m, 1000, null },
                    { 98, 7, "Nâng cao trải nghiệm âm thanh của bạn với loa karaoke Nanomax X-2000. Với thiết kế mạnh mẽ và công suất lên đến 1000W, loa này mang đến âm thanh rõ ràng cho các bữa tiệc, sự kiện hoặc các buổi biểu diễn.", "https://cdn.tgdd.vn/Products/Images/2162/308043/loa-karaoke-nanomax-x-2000-010623-041107-600x600.jpg", "Loa kéo Nanomax X-2000", 720, 7890000m, 1000, null },
                    { 99, 7, "Kích động đám đông với loa karaoke di động Mobell MK-2120C. Với kích thước nhỏ gọn và âm thanh mạnh mẽ lên đến 30W, loa này lý tưởng cho các buổi tụ tập nhỏ, buổi hát karaoke hoặc các chuyến phiêu lưu ngoài trời.", "https://cdn.tgdd.vn/Products/Images/2162/236681/loa-keo-karaoke-mobell-mk-2120c-30w-040723-111711-600x600.jpg", "Loa kéo Mobell MK-2120C", 720, 1440000m, 1000, null },
                    { 100, 7, "Trải nghiệm chất lượng âm thanh cao cấp với loa karaoke Dalton TS-12G350N. Với công suất 350W và thiết kế bền bỉ, loa này được thiết kế để mang lại hiệu suất âm thanh xuất sắc cho các buổi tiệc karaoke hoặc sự kiện.", "https://cdn.tgdd.vn/Products/Images/2162/306932/loa-keo-karaoke-dalton-ts-12g350n-100523-094658-600x600.jpg", "Loa kéo Dalton TS-12G350N", 720, 5160000m, 1000, null },
                    { 101, 7, "Đưa trải nghiệm âm thanh của bạn lên một tầm cao mới với loa karaoke Dalton TS-18G850X. Với công suất 850W đáng kinh ngạc và âm thanh chuyên nghiệp, loa này hoàn hảo cho các DJ, người biểu diễn hoặc bất kỳ ai đòi hỏi chất lượng âm thanh hàng đầu.    ", "https://cdn.tgdd.vn/Products/Images/2162/214636/dalton-ts-18g850x-270223-020450-600x600.jpg", "Loa kéo Dalton TS-18G850X", 720, 9590000m, 1000, null },
                    { 102, 7, "Tạo ấn tượng với loa karaoke di động Nanomax S-1000. Với công suất 1000W và thiết kế sang trọng, loa này mang đến âm thanh rõ ràng, động đạc cho các buổi karaoke, tiệc hoặc sự kiện của bạn.", "https://cdn.tgdd.vn/Products/Images/2162/226094/nanomax-s-1000-270223-020825-600x600.jpg", "Loa kéo Nanomax S-1000", 720, 5390000m, 1000, null },
                    { 103, 7, "Sẵn sàng để làm náo động buổi tiệc với loa karaoke Nanomax S-5000. Với công suất khủng lên đến 5000W và các tính năng tiên tiến, loa này hoàn hảo cho các buổi tụ tập lớn, sự kiện hoặc các buổi biểu diễn chuyên nghiệp.", "https://cdn.tgdd.vn/Products/Images/2162/297489/loa-karaoke-nanomax-s-5000-270223-022010-600x600.jpg", "Loa kéo Nanomax S-5000", 720, 9350000m, 1000, null },
                    { 104, 7, "Trải nghiệm chất lượng âm thanh không giới hạn với loa karaoke điện Dalton TS-18A8500. Với công suất 18.500W ấn tượng và các linh kiện cao cấp, loa này được thiết kế để mang lại âm thanh sâu lắng cho các buổi hòa nhạc, sự kiện hoặc địa điểm.", "https://cdn.tgdd.vn/Products/Images/2162/278932/loa-dien-karaoke-dalton-ts-18a8500-3000w-270223-023623-600x600.jpg", "Loa điện Dalton TS-18A8500", 720, 16790000m, 1000, null },
                    { 105, 7, "Thưởng thức âm thanh mạnh mẽ mọi nơi với loa karaoke di động Nanomax S-900. Với kích thước nhỏ gọn và công suất 420W, loa này hoàn hảo cho các buổi tiệc trong nhà, sự kiện ngoài trời hoặc các buổi karaoke cùng bạn bè.", "https://cdn.tgdd.vn/Products/Images/2162/232105/loa-keo-karaoke-nanomax-s-900-420w-270223-021046-600x600.jpg", "Loa kéo Nanomax S-900", 720, 4510000m, 1000, null },
                    { 106, 7, "Bắt đầu bữa tiệc với loa karaoke Dalton TS-12G450X. Với công suất 450W và thiết kế bền bỉ, loa này mang đến âm thanh rõ ràng, không méo mó cho các buổi karaoke, sự kiện hoặc các chuyến phiêu lưu ngoài trời.", "https://cdn.tgdd.vn/Products/Images/2162/226090/loa-karaoke-dalton-ts-12g450x-270223-020754-600x600.jpg", "Loa kéo Dalton TS-12G450X", 720, 5500000m, 1000, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "Description", "ImageUrl", "Name", "WarrantyPeriod", "price", "quantity", "status" },
                values: new object[,]
                {
                    { 107, 7, "Nâng cao trải nghiệm âm thanh của bạn với loa karaoke di động Birici NB-6889. Với thiết kế thời trang và công suất 1500W mạnh mẽ, loa này hoàn hảo cho các buổi tiệc, sự kiện hoặc các buổi biểu diễn chuyên nghiệp.", "https://cdn.tgdd.vn/Products/Images/2162/304091/loa-keo-karaoke-birici-nb-6889-150323-022702-600x600.jpg", "Loa kéo Birici NB-6889", 720, 11490000m, 1000, null },
                    { 108, 7, "Đắm chìm trong âm thanh chất lượng cao với loa tháp Samsung MX-T70/XV. Với công suất 1500W và thiết kế mềm mại, loa này mang đến âm thanh sắc nét, rõ ràng cho các buổi tiệc, sự kiện hoặc giải trí tại nhà.", "https://cdn.tgdd.vn/Products/Images/2162/220699/loa-thap-samsung-mx-t70-xv-100323-044545-600x600.jpg", "Loa tháp Samsung MX-T70/XV", 720, 7790000m, 1000, null },
                    { 109, 7, "Trải nghiệm chất lượng âm thanh vượt trội với loa karaoke điện Dalton TS-18A1500. Với công suất 15.000W và các thành phần cao cấp, loa này hoàn hảo cho các buổi hòa nhạc, sự kiện hoặc địa điểm nơi âm thanh chất lượng cao là cần thiết.", "https://cdn.tgdd.vn/Products/Images/2162/210260/dalton-ts-18a1500-270223-022539-600x600.jpg", "Loa điện Dalton TS - 18A1500", 720, 10390000m, 1000, null },
                    { 110, 7, "Sẵn sàng cho bữa tiệc với loa karaoke di động Mobell MK-5070. Với thiết kế nhỏ gọn và công suất 400W mạnh mẽ, loa này mang lại âm thanh ấn tượng cho các buổi hát karaoke, sự kiện ngoài trời hoặc các buổi tụ tập với bạn bè.", "https://cdn.tgdd.vn/Products/Images/2162/268876/loa-keo-karaoke-mobell-mk-5070-400w-270223-021421-600x600.jpg", "Loa kéo Mobell MK-5070", 720, 3470000m, 1000, null },
                    { 111, 8, "Quạt điều hòa Sunhouse SHD7727 với công suất 150W mang đến không gian mát mẻ và thoải mái cho căn phòng của bạn. Thiết kế hiện đại, hiệu suất cao và tiết kiệm năng lượng làm cho nó trở thành lựa chọn hoàn hảo cho mọi gia đình.", "https://cdn.tgdd.vn/Products/Images/7498/199117/sunhouse-shd7727-kg-040923-021104-600x600.jpg", "Sunhouse SHD7727 150W", 720, 3990000m, 1000, null },
                    { 112, 8, "Quạt điều hòa Daikiosan DM103 với công suất 175W, kiểu dáng mới, thiết kế thông minh và hiệu suất làm mát hiệu quả. Được thiết kế để đem lại sự thoải mái và tiết kiệm năng lượng cho mọi không gian sống.", "https://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-1a-1-600x600.jpg", "Daikiosan DM103 175W Mẫu mới", 720, 3990000m, 1000, null },
                    { 113, 8, "Quạt điều hòa AVA RPD-80 với công suất 130W mang đến không khí mát mẻ và dễ chịu cho mọi phòng. Thiết kế hiện đại, tiết kiệm năng lượng và hiệu suất cao làm cho nó trở thành lựa chọn lý tưởng cho gia đình của bạn.", "https://cdn.tgdd.vn/Products/Images/7498/272138/ava-rpd-80-040923-025403-600x600.jpg", "AVA RPD-80 130W", 720, 2690000m, 1000, null },
                    { 114, 8, "Quạt điều hòa Daikiosan DM102 với công suất 110W, kiểu dáng mới, hiệu suất cao và tiết kiệm năng lượng. Với khả năng làm mát hiệu quả, nó sẽ giúp bạn cảm thấy thoải mái trong mùa hè oi bức.", "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-0-600x600.jpg", "Daikiosan DM102 110W Mẫu mới", 720, 2990000m, 1000, null },
                    { 115, 8, "Máy làm mát không khí Kangaroo KG50F62 với công suất 100W mang lại không gian mát mẻ và thoải mái cho gia đình bạn. Với thiết kế nhỏ gọn, hiệu suất cao và tiết kiệm năng lượng, nó là lựa chọn lý tưởng cho các căn phòng nhỏ.", "https://cdn.tgdd.vn/Products/Images/7498/218312/may-lam-mat-khong-khi-kangaroo-kg50f62-040923-021617-600x600.jpg", "Kangaroo KG50F62 100W", 720, 1990000m, 1000, null },
                    { 116, 8, "Quạt điều hòa Sunhouse SHD7745 với công suất 125W và thiết kế mới mang lại không gian mát mẻ và thoải mái cho căn phòng của bạn. Với hiệu suất cao và tiết kiệm năng lượng, nó là sự lựa chọn hoàn hảo cho mọi gia đình.", "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-0-600x600.jpg", "Sunhouse SHD7745 125W Mẫu mới", 720, 2390000m, 1000, null },
                    { 117, 8, "Quạt điều hòa Delites RPD-30 với công suất 40W, thiết kế mới và hiệu suất làm mát hiệu quả. Với khả năng tạo ra không gian mát mẻ và dễ chịu, nó sẽ làm cho mùa hè của bạn trở nên dễ chịu hơn.", "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-0-600x600.jpg", "Delites RPD-30 40W Mẫu mới", 720, 1590000m, 1000, null },
                    { 118, 8, "Quạt điều hòa Dmax RPD-90 với công suất 200W, thiết kế mới và hiệu suất làm mát cao. Với khả năng tạo ra không gian mát mẻ và thoải mái, nó là lựa chọn lý tưởng cho mọi không gian sống.", "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-0-600x600.jpg", "Dmax RPD-90 200W Mẫu mới", 720, 3590000m, 1000, null },
                    { 119, 8, "Máy làm mát không khí Kangaroo KG50F99 với công suất 165W mang lại không gian mát mẻ và dễ chịu cho gia đình bạn. Với hiệu suất cao và tiết kiệm năng lượng, nó là lựa chọn lý tưởng cho các căn phòng lớn.", "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-0-600x600.jpg", "Kangaroo KG50F99 165W Mẫu mới", 720, 3990000m, 1000, null },
                    { 120, 8, "Máy làm mát không khí Kangaroo KG50F95 với công suất 120W và thiết kế mới mang lại không gian mát mẻ và dễ chịu cho gia đình bạn. Với hiệu suất cao và tiết kiệm năng lượng, nó là lựa chọn lý tưởng cho mọi không gian sống.", "https://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-0-600x600.jpg", "Kangaroo KG50F95 120W Mẫu mới", 720, 3470000m, 1000, null },
                    { 121, 8, "Quạt điều hòa Hòa Phát HPCF1-012 với công suất 165W mang đến không gian mát mẻ và thoải mái cho mọi căn phòng. Với thiết kế hiện đại và tiết kiệm năng lượng, nó là sự lựa chọn tuyệt vời cho mùa hè.", "https://cdn.tgdd.vn/Products/Images/7498/307875/quat-dieu-hoa-hoa-phat-hpcf1-012-040923-031050-600x600.jpg", "Hòa Phát HPCF1-012 165W", 720, 3550000m, 1000, null },
                    { 122, 8, "Quạt điều hòa Sunhouse SHD7775 với công suất 200W và thiết kế mới mang lại không gian mát mẻ và dễ chịu cho mọi phòng. Với hiệu suất cao và tiết kiệm năng lượng, nó là sự lựa chọn lý tưởng cho mọi gia đình.", "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-0-1-600x600.jpg", "Sunhouse SHD7775 200W Mẫu mới", 720, 4250000m, 1000, null },
                    { 123, 8, "Quạt điều hòa Rapido 9000D với công suất 200W mang lại không gian mát mẻ và thoải mái cho mọi phòng. Với thiết kế hiện đại và hiệu suất cao, nó là lựa chọn lý tưởng cho mọi gia đình.", "https://cdn.tgdd.vn/Products/Images/7498/219138/quat-dieu-hoa-rapido-9000d-040923-023847-600x600.jpg", "Rapido 9000D 200W", 720, 4290000m, 1000, null },
                    { 124, 8, "Quạt điều hòa Daikiosan DM202 với công suất 210W, kiểu dáng mới và hiệu suất làm mát cao. Với khả năng tạo ra không gian mát mẻ và thoải mái, nó là lựa chọn lý tưởng cho mọi không gian ", "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-0-600x600.jpg", "Daikiosan DM202 210W Mẫu mới", 720, 4590000m, 1000, null },
                    { 125, 8, "Quạt điều hòa Rapido 6000D với công suất 80W mang lại không gian mát mẻ và dễ chịu cho mọi phòng. Với thiết kế nhỏ gọn và hiệu suất cao, nó là lựa chọn lý tưởng cho các căn phòng nhỏ.", "https://cdn.tgdd.vn/Products/Images/7498/235380/rapido-6000d-040923-024256-600x600.jpg", "Rapido 6000D 80W", 720, 2750000m, 1000, null },
                    { 126, 9, "Nồi chiên không dầu Rapido SMART-7.0M với dung tích 7 lít là giải pháp hoàn hảo cho những bữa ăn ngon và lành mạnh. Với công nghệ tiên tiến, bạn có thể thưởng thức món ăn yêu thích mà không cần dầu mỡ, giúp giảm lượng calo và chất béo trong khẩu phần ăn hàng ngày.", "https://cdn.tgdd.vn/Products/Images/9418/307646/noi-chien-khong-dau-rapido-smart-70m-7-lit-240523-094953-600x600.jpg", "Nồi chiên không dầu Rapido SMART-7.0M 7 lít", 720, 1190000m, 1000, null },
                    { 127, 9, "Nồi chiên không dầu Sunhouse SHD4062 với dung tích 6 lít mang lại sự tiện lợi và hiệu quả cho việc nấu ăn hàng ngày. Với công nghệ chiên không dầu, bạn có thể tận hưởng món ăn giòn ngon mà không cần lo lắng về sức khỏe.", "https://cdn.tgdd.vn/Products/Images/9418/258338/Sunhouse-SHD4062-0-min-600x600.jpg", "Nồi chiên không dầu Sunhouse SHD4062 6 lít", 720, 1490000m, 1000, null },
                    { 128, 9, "Nồi chiên không dầu Rapido RAF-8.0M với dung tích 8 lít là lựa chọn lý tưởng cho việc chế biến các món ăn ngon mà không cần dầu mỡ. Với thiết kế thông minh và hiệu suất cao, bạn có thể thưởng thức những bữa ăn giòn ngon mà không cần lo lắng về sức khỏe.", "https://cdn.tgdd.vn/Products/Images/9418/304773/noi-chien-khong-dau-rapido-raf-80m-8-lit-310323-110541-600x600.jpg", "Nồi chiên không dầu Rapido RAF-8.0M 8 lít", 720, 1290000m, 1000, null },
                    { 129, 9, "Nồi chiên không dầu AVA KDF-593D với dung tích 7.5 lít là giải pháp hoàn hảo cho những bữa ăn lành mạnh và ngon miệng. Với công nghệ chiên không dầu tiên tiến, bạn có thể thưởng thức món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe của gia đình.", "https://cdn.tgdd.vn/Products/Images/9418/240313/ava-kdf-593d-0-600x600-1.jpg", "Nồi chiên không dầu AVA KDF-593D 7.5 lít", 720, 1290000m, 1000, null },
                    { 130, 9, "Nồi chiên không dầu AVA AF358T với dung tích 4 lít là lựa chọn hoàn hảo cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/240297/Ava-AF358T-0-600x600.jpg", "Nồi chiên không dầu AVA AF358T 4 lít", 720, 990000m, 1000, null },
                    { 131, 9, "Nồi chiên không dầu Sunhouse SHD4035 với dung tích 9 lít là giải pháp tiện lợi và hiệu quả cho việc nấu ăn hàng ngày. Với công nghệ chiên không dầu, bạn có thể chế biến những món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe và làm đẹp da dạng.", "https://cdn.tgdd.vn/Products/Images/9418/275125/275125-600x600-1.jpg", "Nồi chiên không dầu Sunhouse SHD4035 9 lít", 720, 1790000m, 1000, null },
                    { 132, 9, "Nồi chiên không dầu Sunhouse SHD4026 với dung tích 6 lít là lựa chọn hoàn hảo cho việc nấu ăn hàng ngày một cách lành mạnh và tiện lợi. Với công nghệ tiên tiến, bạn có thể thưởng thức những món ăn giòn ngon mà không cần dầu mỡ, giữ cho sức khỏe của gia đình bạn.", "https://cdn.tgdd.vn/Products/Images/9418/249385/Sunhouse-SHD4026-0-min-600x600.jpg", "Nồi chiên không dầu Sunhouse SHD4026 6 lít", 720, 1390000m, 1000, null },
                    { 133, 9, "Lò chiên không dầu Ferroli FAF-12M với dung tích 12 lít là giải pháp tiện lợi và hiệu quả cho việc nấu ăn hàng ngày. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe của gia đình.", "https://cdn.tgdd.vn/Products/Images/9418/309914/lo-chien-khong-dau-ferroli-faf-12m-12-lit-170823-112904-600x600.jpg", "Lò chiên không dầu Ferroli FAF-12M 12 lít", 720, 1490000m, 1000, null },
                    { 134, 9, "Nồi chiên không dầu Toshiba AF-74CS2SRVN(B) với dung tích 7.4 lít là lựa chọn lý tưởng cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/306722/noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-0-600x600.jpg", "Nồi chiên không dầu Toshiba AF-74CS2SRVN(B) 7.4 lít", 720, 2390000m, 1000, null },
                    { 135, 9, "Nồi chiên không dầu Kangaroo KG55AF1A với dung tích 5.2 lít là giải pháp hoàn hảo cho việc chế biến những bữa ăn lành mạnh và ngon miệng. Với công nghệ chiên không dầu tiên tiến, bạn có thể thưởng thức món ăn giòn ngon mà không cần dầu mỡ, giúp bảo vệ sức khỏe của gia đình.", "https://cdn.tgdd.vn/Products/Images/9418/217595/Kangaroo-KG55AF1A-0-600x600.jpg", "Nồi chiên không dầu Kangaroo KG55AF1A 5.2 lít", 720, 1290000m, 1000, null },
                    { 136, 9, "Nồi chiên không dầu Hafele AF-T5A với dung tích 5 lít là lựa chọn hoàn hảo cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/233494/Hafele-AF-T5A-0-600x600.jpg", "Nồi chiên không dầu Hafele AF-T5A (535.43.712) 5 lít", 720, 1990000m, 1000, null },
                    { 137, 9, "Lò chiên không dầu Sunhouse Mama SHD4088 với dung tích lớn 15 lít là lựa chọn lý tưởng cho việc chế biến những bữa ăn ngon mà không cần dầu mỡ. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/275124/275124-600x600-1.jpg", "SẢN PHẨM CAO CẤP\r\nSẢN PHẨM CAO CẤP\r\nLò chiên không dầu Sunhouse Mama SHD4088 15 lít", 720, 2690000m, 1000, null },
                    { 138, 9, "Nồi chiên không dầu AVA AF40155D với dung tích 5 lít là lựa chọn lý tưởng cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/235357/AVA-AF40155D-0-600x600.jpg", "Nồi chiên không dầu AVA AF40155D 5 lít", 720, 990000m, 1000, null },
                    { 139, 9, "Nồi chiên không dầu Philips HD9200/90 với dung tích 2.4 lít là giải pháp hoàn hảo cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ chiên không dầu, bạn có thể thưởng thức món ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/231967/Philips-HD9200-90-0-600x600.jpg", "Nồi chiên không dầu Philips HD9200/90 2.4 lít", 720, 1490000m, 1000, null },
                    { 140, 9, "Lò chiên không dầu Kangaroo KG12AF1A với dung tích 12 lít là lựa chọn lý tưởng cho việc chế biến những món ăn ngon mà không cần dầu mỡ. Với công nghệ tiên tiến, bạn có thể thưởng thức những bữa ăn giòn ngon mà không lo lắng về calo và chất béo.", "https://cdn.tgdd.vn/Products/Images/9418/242418/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit-170423-120402-600x600.jpg", "Lò chiên không dầu Kangaroo KG12AF1A 12 lít", 720, 2690000m, 1000, null },
                    { 141, 10, "Quạt đứng KDK M40K GY với 3 cánh và công suất 50W mang đến không gian mát mẻ và thoải mái cho không gian sống của bạn. Với thiết kế đẹp mắt và hiệu suất cao, quạt KDK là sự lựa chọn hoàn hảo cho ngôi nhà của bạn.", "https://cdn.tgdd.vn/Products/Images/1992/73337/kdk-m40k-xam-gy-290823-020333-600x600.jpg", "Quạt đứng KDK 3 cánh M40K GY 50W", 720, 3690000m, 1000, null },
                    { 142, 10, "Quạt treo tường KDK M40M với 3 cánh và công suất 51W mang đến không gian mát mẻ và thoải mái cho không gian sống của bạn. Với thiết kế tiện lợi và hiệu suất ổn định, quạt KDK là sự lựa chọn hoàn hảo cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/73339/kdk-m40m-290823-020422-600x600.jpg", "Quạt treo tường KDK 3 cánh M40M 51W", 720, 2770000m, 1000, null },
                    { 143, 10, "Quạt đứng Senko DH1600 với 3 cánh và công suất 47W là lựa chọn hoàn hảo cho việc làm mát không gian sống hoặc làm việc của bạn. Với thiết kế hiện đại và tính năng tiện ích, quạt Senko làm cho mọi không gian trở nên thoải mái và dễ chịu.", "https://cdn.tgdd.vn/Products/Images/1992/268450/268450-600x600.jpg", "Quạt đứng Senko 3 cánh DH1600 47W", 720, 570000m, 1000, null },
                    { 144, 10, "Quạt lửng Asia VY538990 với 5 cánh và công suất 55W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến sự thoải mái và mát mẻ cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/275524/lung-asia-vy538990-290823-034344-600x600.jpg", "Quạt lửng Asia 5 cánh VY538990 55W", 720, 470000m, 1000, null },
                    { 145, 10, "Quạt đứng Toshiba F-LSA20(H)VN với 5 cánh và công suất 60W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đẹp mắt và hiệu suất cao, quạt Toshiba mang đến không khí thoải mái và dễ chịu.", "https://cdn.tgdd.vn/Products/Images/1992/164540/toshiba-f-lsa20-h-vn-290823-022101-600x600.jpg", "Quạt đứng Toshiba 5 cánh F-LSA20(H)VN 60W", 720, 1470000m, 1000, null },
                    { 146, 10, "Quạt đứng Toshiba F-LSA10(W)VN với 5 cánh và công suất 50W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Toshiba làm cho không gian của bạn trở nên thoải mái và dễ chịu.", "https://cdn.tgdd.vn/Products/Images/1992/206027/quat-dung-toshiba-f-lsa10-w-vn-trang-290823-023754-600x600.jpg", "Quạt đứng Toshiba 5 cánh F-LSA10(W)VN 50W", 720, 990000m, 1000, null },
                    { 147, 10, "Quạt lửng Senko L1638 với 3 cánh và công suất 47W là lựa chọn hoàn hảo cho việc làm mát không gian sống hoặc làm việc của bạn. Thiết kế đẹp mắt và hiệu suất cao, quạt Senko mang đến không khí mát mẻ và thoải mái cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/268452/lung-senko-l1638-290823-034304-600x600.jpg", "Quạt lửng Senko 3 cánh L1638 47W", 720, 4390000m, 1000, null },
                    { 148, 10, "Quạt lửng Senko LTS1636 với 7 cánh và công suất 65W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đẹp mắt và hiệu suất ổn định, quạt Senko mang đến không khí thoải mái và dễ chịu cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/268453/lung-senko-lts1636-290823-034352-600x600.jpg", "Quạt lửng Senko 7 cánh LTS1636 65W", 720, 490000m, 1000, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "Description", "ImageUrl", "Name", "WarrantyPeriod", "price", "quantity", "status" },
                values: new object[,]
                {
                    { 149, 10, "Quạt đứng Asia VY539790 với 5 cánh và công suất 55W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến không khí thoải mái và dễ chịu.", "https://cdn.tgdd.vn/Products/Images/1992/275185/dung-asia-vy539790-290823-035045-600x600.jpg", "Quạt đứng Asia 5 cánh VY539790 55W", 720, 590000m, 1000, null },
                    { 150, 10, "Quạt lửng Asia VY628890 với 5 cánh và công suất 75W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến không khí mát mẻ và thoải mái cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-0-600x600.jpg", "Quạt lửng Asia 5 cánh VY628890 75W", 720, 490000m, 1000, null },
                    { 151, 10, "Quạt đứng Asia VY639990 với 6 cánh và công suất 80W là lựa chọn hoàn hảo cho việc làm mát không gian sống hoặc làm việc của bạn. Thiết kế đẹp mắt và hiệu suất cao, quạt Asia mang đến không khí mát mẻ và dễ chịu cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/275186/dung-asia-vy639990-290823-035003-600x600.jpg", "Quạt đứng Asia 6 cánh VY639990 80W", 720, 790000m, 1000, null },
                    { 152, 10, "Quạt treo tường Asia VY377790 với 3 cánh và công suất 55W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đơn giản và hiệu suất ổn định, quạt Asia mang đến không khí mát mẻ và dễ chịu cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/275528/treo-asia-vy377790-290823-033942-600x600.jpg", "Quạt treo tường Asia 3 cánh VY377790 55W", 720, 690000m, 1000, null },
                    { 153, 10, "Quạt bàn Senko B1213 với 3 cánh và công suất 40W là lựa chọn hoàn hảo cho việc làm mát không gian làm việc hoặc nơi làm việc của bạn. Thiết kế đơn giản và hiệu suất ổn định, quạt Senko làm cho không gian của bạn trở nên thoải mái và dễ chịu.", "https://cdn.tgdd.vn/Products/Images/1992/268448/ban-senko-b1213-290823-033550-600x600.jpg", "Quạt bàn Senko 3 cánh B1213 40W", 720, 350000m, 1000, null },
                    { 154, 10, "Quạt treo tường Senko TC1622 với 7 cánh và công suất 65W là giải pháp làm mát hiệu quả cho không gian sống của bạn. Thiết kế đẹp mắt và hiệu suất ổn định, quạt Senko mang đến không khí mát mẻ và dễ chịu cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/268462/quat-treo-tuong-senko-7-canh-tc1622-65w-290823-035015-600x600.jpg", "Quạt treo tường Senko 7 cánh TC1622 65W", 720, 499000m, 1000, null },
                    { 155, 10, "Quạt hộp Midea KYT30-15A với 5 cánh và công suất 40W là sự lựa chọn hoàn hảo cho việc làm mát trong không gian sống hoặc làm việc. Thiết kế đơn giản và hiệu suất ổn định, quạt Midea mang đến không khí mát mẻ và dễ chịu cho mọi không gian.", "https://cdn.tgdd.vn/Products/Images/1992/207672/midea-kyt30-15a-thumb.jpg", "Quạt hộp Midea 5 cánh KYT30-15A 40W", 720, 550000m, 1000, null },
                    { 156, 11, "Máy sấy thông hơi Galanz DV-70Q1C với dung tích 7 kg là giải pháp hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng thông minh giúp tiết kiệm thời gian và năng lượng.", "https://cdn.tgdd.vn/Products/Images/2202/302178/may-say-thong-hoi-galanz-dv-70q1c-260323-083916-600x600.jpg", "Máy sấy thông hơi Galanz 7 Kg DV-70Q1C", 720, 4390000m, 1000, null },
                    { 157, 11, "Máy sấy thông hơi Galanz DV-70T5C(S) với dung tích 7 kg là lựa chọn đáng tin cậy để làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng thông minh giúp tiết kiệm thời gian và năng lượng.", "https://cdn.tgdd.vn/Products/Images/2202/241930/may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-300x300.jpg", "Máy sấy thông hơi Galanz 7 Kg DV-70T5C(S)", 720, 4800000m, 1000, null },
                    { 158, 11, "Máy sấy thông hơi Galanz DV-70T5C(W) với dung tích 7 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.", "https://cdn.tgdd.vn/Products/Images/2202/241929/may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-270922-022611-600x600.jpg", "Máy sấy thông hơi Galanz 7 Kg DV-70T5C(W)", 720, 4700000m, 1000, null },
                    { 159, 11, "Máy sấy thông hơi Casper TD-72VWD với dung tích 7.2 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.", "https://cdn.tgdd.vn/Products/Images/2202/273320/may-say-casper-td-72vwd-fix-thumb-600x600.jpg", "Máy sấy thông hơi Casper 7.2 Kg TD-72VWD", 720, 4990000m, 1000, null },
                    { 160, 11, "Máy sấy thông hơi Electrolux EDV854J3WB với dung tích 8.5 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.", "https://cdn.tgdd.vn/Products/Images/2202/272144/may-say-thong-hoi-electrolux-85-kg-edv854j3wb-1.-1-600x600.jpg", "Máy sấy thông hơi Electrolux 8.5 Kg EDV854J3WB", 720, 9890000m, 1000, null },
                    { 161, 11, "Máy sấy thông hơi Toshiba TD-H80SEV(SK) với dung tích 7 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.", "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-070823-044325-600x600.jpg", "Máy sấy thông hơi Toshiba 7 Kg TD-H80SEV(SK)", 720, 5690000m, 1000, null },
                    { 162, 11, "Máy sấy thông hơi Electrolux EDV754H3WB với dung tích 7.5 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.", "https://cdn.tgdd.vn/Products/Images/2202/272143/may-say-thong-hoi-electrolux-75-kg-edv754h3wb-170223-031343-600x600.jpg", "Máy sấy thông hơi Electrolux 7.5 Kg EDV754H3WB", 720, 7990000m, 1000, null },
                    { 163, 11, "Máy sấy bơm nhiệt Electrolux EDH903R9WB với dung tích 9 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.", "https://cdn.tgdd.vn/Products/Images/2202/284038/may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-061122-103202-600x600.jpg", "Máy sấy bơm nhiệt Electrolux 9 Kg EDH903R9WB", 720, 21990000m, 1000, null },
                    { 164, 11, "Máy sấy thông hơi Electrolux EDV854N3SB với dung tích 8.5 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.", "https://cdn.tgdd.vn/Products/Images/2202/272145/may-say-thong-hoi-electrolux-85-kg-edv854n3sb-170223-034851-600x600.jpg", "Máy sấy thông hơi Electrolux 8.5 Kg EDV854N3SB", 720, 10490000m, 1000, null },
                    { 165, 11, "Máy sấy bơm nhiệt Electrolux EDH804H5WB với dung tích 8 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.", "https://cdn.tgdd.vn/Products/Images/2202/284036/may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-041122-052059-600x600.jpg", "Máy sấy bơm nhiệt Electrolux 8 Kg EDH804H5WB", 720, 17990000m, 1000, null },
                    { 166, 11, "Máy sấy bơm nhiệt LG DVHP50B với dung tích 10.5 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.", "https://cdn.tgdd.vn/Products/Images/2202/307973/may-say-bom-nhiet-lg-inverter-105-kg-dvhp50b-0.-600x600.jpg", "Máy sấy bơm nhiệt LG 10.5 Kg DVHP50B", 720, 20970000m, 1000, null },
                    { 167, 11, "Máy sấy thông hơi Electrolux EDS854N3SB với dung tích 8.5 kg là lựa chọn hoàn hảo cho việc làm khô quần áo một cách nhanh chóng và hiệu quả. Thiết kế hiện đại và tính năng tiên tiến giúp tiết kiệm thời gian và năng lượng.", "https://cdn.tgdd.vn/Products/Images/2202/272142/may-say-thong-hoi-electrolux-85-kg-eds854n3sb-160222-072932-600x600.jpg", "Máy sấy thông hơi Electrolux 8.5 Kg EDS854N3SB", 720, 10990000m, 1000, null },
                    { 168, 11, "Máy sấy ngưng tụ Toshiba TD-K90MEV(SK) với dung tích 8 kg là giải pháp tiện lợi và hiệu quả cho việc làm khô quần áo. Thiết kế thông minh và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.", "https://cdn.tgdd.vn/Products/Images/2202/310251/product-310251-070723-035006-600x600.jpg", "Máy sấy ngưng tụ Toshiba 8 Kg TD-K90MEV(SK)", 720, 9900000m, 1000, null },
                    { 169, 11, "Máy sấy thông hơi Beko DA8112RX0W với dung tích 8 kg là sự kết hợp hoàn hảo giữa hiệu suất và tính tiện ích. Thiết kế hiện đại và tính năng tiên tiến giúp làm khô quần áo một cách dễ dàng và hiệu quả.", "https://cdn.tgdd.vn/Products/Images/2202/227250/may-say-beko-da8112rx0w-1-300x300.jpg", "Máy sấy thông hơi Beko 8 Kg DA8112RX0W", 720, 6990000m, 1000, null },
                    { 170, 11, "Máy sấy ngưng tụ Candy CSO C10TE-S với dung tích 10 kg là giải pháp làm khô quần áo hiệu quả và tiết kiệm năng lượng. Thiết kế hiện đại và tính năng thông minh giúp làm khô quần áo một cách dễ dàng và nhanh chóng.", "https://cdn.tgdd.vn/Products/Images/2202/230073/may-say-candy-cso-c10te-s-300x300.jpg", "Máy sấy ngưng tụ Candy 10 Kg CSO C10TE-S", 720, 7190000m, 1000, null },
                    { 171, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/299619/299619-600x600.jpg", "Electrolux 23 lít EMM23D22B", 720, 2390000m, 1000, null },
                    { 172, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/299620/lo-vi-song-electrolux-emm23k22b-23-lit-140423-115410-600x600.jpg", "Electrolux 23 lít EMM23K22B", 720, 2365000m, 1000, null },
                    { 173, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/299616/299616-600x600.jpg", "Electrolux 20 lít EMM20K22W", 720, 1890000m, 1000, null },
                    { 174, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/303492/303492-min-600x600.jpg", "Panasonic 25 lít NN-ST34NBYUE", 720, 3590000m, 1000, null },
                    { 175, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/242774/bluestone-mob-7733-25-lit-0-600x600.jpg", "BlueStone 25 lít MOB-7733", 720, 2799000m, 1000, null },
                    { 176, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/303491/303491-min-600x600.jpg", "Panasonic 25 lít NN-SM33NBYUE", 720, 3070000m, 1000, null },
                    { 177, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/197818/panasonic-nn-st25jwyue-310723-025041-600x600.jpg", "Panasonic 20 lít NN-ST25JWYUE", 720, 2870000m, 1000, null },
                    { 178, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/242766/bluestone-mob-7708b-20-lit-260723-103853-600x600.jpg", "BlueStone 20 lít MOB-7708B", 720, 1849000m, 1000, null },
                    { 179, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/305855/lo-vi-song-electrolux-emg30d22bm-30-lit-240423-095632-600x600.jpg", "Electrolux 30 lít EMG30D22BM", 720, 4740000m, 1000, null },
                    { 180, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/203059/lo-vi-song-samsung-ms23k3513as-sv-n-23-lit-310723-031206-600x600.jpg", "Samsung 23 lít MS23K3513AS/SV-N", 720, 1690000m, 1000, null },
                    { 181, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/69080/sharp-r-205vn-s-20-lit-020223-111427-600x600.jpg", "Sharp 20 lít R-205VN(S)", 720, 1590000m, 1000, null },
                    { 182, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/235256/235256%20(1)-600x600.jpg", "Sharp 20 lít R-209VN-SK", 720, 1670000m, 1000, null },
                    { 183, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/203563/lo-vi-song-electrolux-emg20k38gwp-310723-031401-600x600.jpg", "Electrolux 20 lít EMG20K38GWP", 720, 1990000m, 1000, null },
                    { 184, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/316809/lo-vi-song-sharp-r-211tv-bk-21-lit-0-600x600.jpg", "Sharp 21 lít R-211TV-BK", 720, 1890000m, 1000, null },
                    { 185, 12, "", "https://cdn.tgdd.vn/Products/Images/1987/299618/299618-600x600-1.jpg", "Electrolux 23 lít EMG23D22B", 720, 2490000m, 1000, null }
                });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "Name", "ProductId", "Value" },
                values: new object[] { 1, "Volt", 1, "220" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 19, 13, 43, 29, 159, DateTimeKind.Local).AddTicks(8177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ImageUrl", "price" },
                values: new object[] { "", "", 6890000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Name", "price" },
                values: new object[] { 4, "Thịt cá tươi ngon, ăn trong ngày không cần rã đông với ngăn đông mềm -1 độ C Optimal Fresh Zone", "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/samsung-rt22m4032by-sv-140821-0917590.jpg", "", 5990000m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 17, 16, 36, 0, 404, DateTimeKind.Local).AddTicks(4593));
        }
    }
}
