using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWP391_BL3W.Migrations
{
    public partial class UpdateDBandSeederImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 2, 2, "https://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/74480/Slider/vi-vn-3.jpg" },
                    { 3, 3, "https://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-thiet-ke-(1).jpghttps://cdn.tgdd.vn/Products/Images/1989/210263/Slider/vi-vn-dung-tich-(1).jpghttps://cdn.tgdd.vn/Products/Images/1989/210263/Slider/congsuat-780x433.jpg" },
                    { 4, 4, "https://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/68568/Slider/vi-vn-3.jpg" },
                    { 5, 5, "https://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654167272451.jpghttps://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654168202480.jpghttps://cdn.tgdd.vn/Products/Images/1989/304876/Slider/binh-dun-sieu-toc-dien-quang-1.8-lit-dq-ekt06-1518-bl638210654169122563.jpg" },
                    { 6, 6, "https://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-3.jpghttps://cdn.tgdd.vn/Products/Images/1989/255619/Slider/vi-vn-sunhouse-18-lit-shd1351-4.jpg" },
                    { 7, 7, "https://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(2).jpghttps://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(3).jpghttps://cdn.tgdd.vn/Products/Images/1989/255623/Slider/vi-vn-sunhouse-18-lit-shd1353--(4).jpg" },
                    { 8, 8, "https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923030465278.jpghttps://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923031375346.jpg https://cdn.tgdd.vn/Products/Images/1989/294038/Slider/binh-dun-sieu-toc-sunhouse-mama-18-lit-shd1389638060923032445291.jpgv" },
                    { 9, 9, "https://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-3.jpghttps://cdn.tgdd.vn/Products/Images/1989/322756/binh-dun-sieu-toc-bear-15-lit-bek-e153w2-4.jpg" },
                    { 10, 10, "https://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-thiet-ke.jpghttps://cdn.tgdd.vn/Products/Images/1989/193481/Slider/cong-suat-780x433.jpghttps://cdn.tgdd.vn/Products/Images/1989/193481/Slider/vi-vn-dung-tich.jpg" },
                    { 11, 11, "https://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/224396/Slider/-congsuat-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/224396/Slider/vi-vn-dungtich.jpg" },
                    { 12, 12, "https://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-congsuat.jpghttps://cdn.tgdd.vn/Products/Images/1989/216199/Slider/vi-vn-dungtich.jpg" },
                    { 13, 13, "https://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/177836/Slider/Untitled-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/1989/177836/Slider/vi-vn-2.jpg" },
                    { 14, 14, "https://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466480780750.jpghttps://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466481600801.jpghttps://cdn.tgdd.vn/Products/Images/1989/283616/Slider/sunhouse-mama-17-lit-shd1330637944466485200682.jpg" },
                    { 15, 15, "https://cdn.tgdd.vn/Products/Images/1989/177647/Slider/Untitled-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1989/177647/Slider/vi-vn-3.jpg" },
                    { 16, 16, "https://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/217362/Slider/a4-780x433.pnghttps://cdn.tgdd.vn/Products/Images/1989/217362/Slider/vi-vn-dungtich.jpg" },
                    { 17, 17, "https://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(6).jpghttps://cdn.tgdd.vn/Products/Images/1989/204621/Slider/vi-vn-binh-dun-sieu-toc-toshiba-kt-17dr1nv-(4).jpghttps://cdn.tgdd.vn/Products/Images/1989/204621/Slider/a2-780x433.png" },
                    { 18, 18, "https://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-7.jpghttps://cdn.tgdd.vn/Products/Images/1989/203066/Slider/vi-vn-binh-dun-sieu-toc-bluestone-ktb-3417-4.jpghttps://cdn.tgdd.vn/Products/Images/1989/203066/Slider/thumb-780x433.jpg" },
                    { 19, 19, "https://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-2.jpghttps://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-3.jpghttps://cdn.tgdd.vn/Products/Images/1989/320458/binh-dun-sieu-toc-rapido-17-lit-rk1717-4.jpg" },
                    { 20, 20, "https://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-thietke.jpghttps://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-congsuat.jpghttps://cdn.tgdd.vn/Products/Images/1989/224405/Slider/vi-vn-dungtich.jpg" },
                    { 21, 21, "https://cdn.tgdd.vn/Products/Images/1982/252058/Slider/2KG855i-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516149397546.jpghttps://cdn.tgdd.vn/Products/Images/1982/252058/Slider/doi-kangaroo-kg855i637841516150627512.jpg" },
                    { 22, 22, "https://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709265189907349.jpghttps://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274051416304.jpghttps://cdn.tgdd.vn/Products/Images/1982/236629/Slider/doi-hafele-hc-i2712a637709274053406269.jpg" },
                    { 23, 23, "https://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148159663228.jpghttps://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638283148161073382.jpghttps://cdn.tgdd.vn/Products/Images/1982/236229/Slider/hafele-hc-i2732a638277628983499420.jpg" },
                    { 24, 24, "https://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208638306537136599246.jpghttps://cdn.tgdd.vn/Products/Images/1982/237344/Slider/vi-vn-doi-pramie-2208-230721-0436562.jpghttps://cdn.tgdd.vn/Products/Images/1982/237344/Slider/doi-pramie-2208-230721-0436578.jpg" },
                    { 25, 25, "https://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-3.jpghttps://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-4.jpghttps://cdn.tgdd.vn/Products/Images/1982/285114/ava-ai-32-9.jpg" },
                    { 26, 26, "https://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-1-min.jpghttps://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-2-min.jpghttps://cdn.tgdd.vn/Products/Images/1982/237011/Slider/vi-vn-doi-sunhouse-shb9111mt-3-min.jpg" },
                    { 27, 27, "https://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-3-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/271886/Slider/-shd-6015-4-780x433.jpg" },
                    { 28, 28, "https://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157188439325.jpghttps://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157187419347.jpghttps://cdn.tgdd.vn/Products/Images/1982/317824/Slider/bep-tu-hong-ngoai-lap-am-hafele-hc-h7321b638345157186249325.jpg" },
                    { 29, 29, "https://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-4-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-3-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/252514/hommy-fym20-71-9.jpg" },
                    { 30, 30, "https://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-thietkefinal.jpghttps://cdn.tgdd.vn/Products/Images/1982/234972/Slider/galanz-ch211e637701457133462016.jpghttps://cdn.tgdd.vn/Products/Images/1982/234972/Slider/vi-vn-matbepfinal.jpg" },
                    { 31, 31, "https://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-1.jpghttps://cdn.tgdd.vn/Products/Images/3305/63990/Slider/-hong-ngoai-sanaky-at-2524hgn-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/63990/Slider/vi-vn-at-2524hgn-3.jpg" },
                    { 32, 32, "https://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117081.jpghttps://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117092.jpghttps://cdn.tgdd.vn/Products/Images/3305/229373/Slider/151020-1117113.jpg" },
                    { 33, 33, "https://cdn.tgdd.vn/Products/Images/3305/236648/Slider/tongcongsuat-780x433.jpghttps://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127511.jpghttps://cdn.tgdd.vn/Products/Images/3305/236648/Slider/3-vung-nau-hafele-hc-r603d-080421-1127500.jpg" },
                    { 34, 34, "https://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-2-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-3-1.jpghttps://cdn.tgdd.vn/Products/Images/1982/318695/bep-tu-4-vung-nau-lap-am-bosch-pvq731f15e-4-1.jpg" },
                    { 35, 35, "https://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788887736001.jpghttps://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788587167004.jpghttps://cdn.tgdd.vn/Products/Images/1982/318692/Slider/bep-tu-3-vung-nau-lap-am-bosch-puj611bb5e638405788583007035.jpg" },
                    { 36, 36, "https://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-02.gifhttps://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-3.jpghttps://cdn.tgdd.vn/Products/Images/1942/279933/Slider/vi-vn-smart-samsung-4k-55-inch-ua55au7002-4.jpg" },
                    { 37, 37, "https://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-02.pnghttps://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-03.jpghttps://cdn.tgdd.vn/Products/Images/1942/303514/Slider/vi-vn-google-tivi-qled-tcl-4k-65-inch-65q646-05.jpg" },
                    { 38, 38, "https://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761528510276.gifhttps://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761529460408.gifhttps://cdn.tgdd.vn/Products/Images/1942/273391/Slider/smart-samsung-4k-55-inch-ua55bu8000637890761530420342.jpg" },
                    { 39, 39, "https://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-2.jpghttps://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-3.jpghttps://cdn.tgdd.vn/Products/Images/1942/278555/Slider/vi-vn-smart-lg-4k-65-inch-65uq8000psc-4.jpg" },
                    { 40, 40, "https://cdn.tgdd.vn/Products/Images/1942/279935/Slider/smart-samsung-4k-43-inch-ua43au7002638022060998318047.gifhttps://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-3.jpghttps://cdn.tgdd.vn/Products/Images/1942/279935/Slider/vi-vn-smart-samsung-4k-43-inch-ua43au7002-5.jpg" },
                    { 41, 41, "https://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-5.jpghttps://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-006.jpghttps://cdn.tgdd.vn/Products/Images/1942/303225/Slider/vi-vn-smart-tivi-qled-4k-55-inch-samsung-qa55q60c-9.jpg" },
                    { 42, 42, "https://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-2.pnghttps://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-4.pnghttps://cdn.tgdd.vn/Products/Images/1942/303231/Slider/vi-vn-smart-tivi-samsung-4k-55-inch-ua55cu8000-8.png" },
                    { 43, 43, "https://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-2.gifhttps://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-3.gifhttps://cdn.tgdd.vn/Products/Images/1942/278575/Slider/vi-vn-smart-nanocell-lg-4k-65-inch-65nano76sqa-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 44, 44, "https://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489862454084.jpghttps://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489863354037.jpghttps://cdn.tgdd.vn/Products/Images/1942/306073/Slider/google-tivi-tcl-43-inch-43s5400638223489864254065.jpg" },
                    { 45, 45, "https://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-006.jpghttps://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-9.jpghttps://cdn.tgdd.vn/Products/Images/1942/303224/Slider/vi-vn-smart-tivi-qled-4k-65-inch-samsung-qa65q60c-10.jpg" },
                    { 46, 46, "https://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972278342842.jpghttps://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972277412853.jpghttps://cdn.tgdd.vn/Products/Images/1942/308371/Slider/google-tivi-sony-4k-43-inch-kd-43x77l638239972276662851.jpg" },
                    { 47, 47, "https://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490700146555.jpghttps://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490701116452.jpghttps://cdn.tgdd.vn/Products/Images/1942/306075/Slider/google-tivi-tcl-32-inch-32s5400638223490702106380.jpg" },
                    { 48, 48, "https://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-2.gifhttps://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-3.gifhttps://cdn.tgdd.vn/Products/Images/1942/278576/Slider/vi-vn-smart-nanocell-lg-4k-55-inch-55nano76sqa-4.jpg" },
                    { 49, 49, "https://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996419458470.pnghttps://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996422198459.pnghttps://cdn.tgdd.vn/Products/Images/1942/311367/Slider/smart-tivi-toshiba-43-inch-43v31mp638342996424168464.png" },
                    { 50, 50, "https://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-2.pnghttps://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-4.pnghttps://cdn.tgdd.vn/Products/Images/1942/303230/Slider/vi-vn-smart-tivi-samsung-4k-65-inch-ua65cu8000-8.png" },
                    { 51, 51, "https://cdn.tgdd.vn/Products/Images/1943/220325/Slider/02-1020x571.jpghttps://cdn.tgdd.vn/Products/Images/1943/220325/Slider/03-1020x571.jpghttps://cdn.tgdd.vn/Products/Images/1943/220325/Slider/06-1020x571.jpg" },
                    { 52, 52, "https://cdn.tgdd.vn/Products/Images/1943/220326/Slider/1-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1943/220326/Slider/2-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1943/220326/Slider/4-1020x570-1.jpg" },
                    { 53, 53, "https://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-050821-0710241.pnghttps://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-100821-0218070.jpghttps://cdn.tgdd.vn/Products/Images/1943/236609/Slider/aqua-aqr-t150fa-bs-210821-1005141.jpg" },
                    { 54, 54, "https://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798790132815.jpghttps://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798792382855.jpghttps://cdn.tgdd.vn/Products/Images/1943/304189/Slider/tu-lanh-aqua-aqr-t220fa-fb638170798793442838.jpg" },
                    { 55, 55, "https://cdn.tgdd.vn/Products/Images/1943/202857/Slider/2-1020x570.pnghttps://cdn.tgdd.vn/Products/Images/1943/202857/Slider/toshiba-gr-b22vu-ukg-050821-1121262.jpghttps://cdn.tgdd.vn/Products/Images/1943/202857/Slider/198-1020x570.jpg" },
                    { 56, 56, "https://cdn.tgdd.vn/Products/Images/1943/230195/Slider/2-1020x570.pnghttps://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.pnghttps://cdn.tgdd.vn/Products/Images/1943/230195/Slider/3-1020x570-1.png" },
                    { 57, 57, "https://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb2.jpghttps://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb3.jpghttps://cdn.tgdd.vn/Products/Images/1943/294558/tu-lanh-lg-gv-b212wb4.jpg" },
                    { 58, 58, "https://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-5.jpghttps://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-6.jpghttps://cdn.tgdd.vn/Products/Images/1943/306554/samsung-inverter-382-lit-rt38cg6584b1sv-7.jpg" },
                    { 59, 59, "https://cdn.tgdd.vn/Products/Images/1943/220320/Slider/samsung-rt20har8dbu-sv-080821-0639042.jpghttps://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-2-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1943/220320/Slider/RT20HAR8DBUV-4-1020x570.jpg" },
                    { 60, 60, "https://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-080821-0341071.jpghttps://cdn.tgdd.vn/Products/Images/1943/225858/Slider/samsung-rb27n4010bu-sv-210821-0601370.jpghttps://cdn.tgdd.vn/Products/Images/1943/225858/Slider/225858-1020x570.png" },
                    { 61, 61, "https://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667257173349.jpghttps://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258003283.jpghttps://cdn.tgdd.vn/Products/Images/1943/307871/Slider/lg-gr-b256jds638216667258813389.jpg" },
                    { 62, 62, "https://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007604134225944.jpghttps://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603868094190.jpghttps://cdn.tgdd.vn/Products/Images/1943/284851/Slider/tu-lanh-aqua-inverter-456-lit-aqr-m525xa(fb)638007603817113795.jpg" },
                    { 63, 63, "https://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760509272052.jpghttps://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760510222056.jpghttps://cdn.tgdd.vn/Products/Images/1943/303228/Slider/tu-lanh-toshiba-inverter-460-lit-gr-rs600wi-pmv-37-sg638164760511042060.jpg" },
                    { 64, 64, "https://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343064927731.jpghttps://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343066856041.jpghttps://cdn.tgdd.vn/Products/Images/1943/310574/Slider/aqua-inverter-279-lit-aqr-t300fa-wfb638339343067926248.jpg" },
                    { 65, 65, "https://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404755929362-1020x571.jpghttps://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404757959374.jpghttps://cdn.tgdd.vn/Products/Images/1943/306130/Slider/tu-lanh-aqua-aqr-t400fa-fb638192404760909361.jpg" },
                    { 66, 66, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121296906251.jpghttps://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121297826281.jpghttps://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpg" },
                    { 67, 67, "https://cdn.tgdd.vn/Products/Images/1944/310181/Slider/sharp-75-kg-es-y75hv-s638301121298706292.jpghttps://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618087619203.jpghttps://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpg" },
                    { 68, 68, "https://cdn.tgdd.vn/Products/Images/1944/271700/Slider/samsung-inverter-9-kg-ww90t3040ww-sv637802618090279194.jpghttps://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-giat-nuoc-nong-panasonic-na-fd95v1brv-3.jpghttps://cdn.tgdd.vn/Products/Images/1944/227973/Slider/vi-vn-bot-min-panasonic-na-fd95v1brv-4.jpg" },
                    { 69, 69, "https://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-03.jpghttps://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-04.jpghttps://cdn.tgdd.vn/Products/Images/1944/248802/Slider/vi-vn-may-giat-samsung-inverter-8kg-ww80t3020ww-sv-05.jpg" },
                    { 70, 70, "https://cdn.tgdd.vn/Products/Images/1944/239156/Slider/vi-vn-toshiba-7-kg-aw-l805av-sg03.jpghttps://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-4-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/239156/Slider/toshiba-7-kg-aw-l805av-sg-3-1020x570.jpg" },
                    { 71, 71, "https://cdn.tgdd.vn/Products/Images/1944/302751/Slider/chuong-trinh-giat-may-giat-samsung-12kg-wa12cg5745bvsv-1018x575.jpghttps://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204011022314.jpghttps://cdn.tgdd.vn/Products/Images/1944/302751/Slider/may-giat-samsung-12kg-wa12cg5745bvsv638276204012042319.jpg" },
                    { 72, 72, "https://cdn.tgdd.vn/Products/Images/1944/212130/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-giat-nuoc-nong--panasonic-na-fd10vr1bv-3.jpghttps://cdn.tgdd.vn/Products/Images/1944/212130/Slider/vi-vn-bot-min-panasonic-na-fd10vr1bv-4.jpg" },
                    { 73, 73, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg" },
                    { 74, 74, "https://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800876583179.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800877523143.jpghttps://cdn.tgdd.vn/Products/Images/1944/302750/Slider/may-giat-samsung-14kg-wa14cg5745bvsv638258800880043169.jpg" },
                    { 75, 75, "https://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb2.jpghttps://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb3.jpghttps://cdn.tgdd.vn/Products/Images/1944/316217/electrolux-inverter-9-kg-ewf9025dqwb4.jpg" },
                    { 76, 76, "https://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528027737733.jpghttps://cdn.tgdd.vn/Products/Images/1944/274173/Slider/aqua-aqd-d902g-bk637828528028857718.jpghttps://cdn.tgdd.vn/Products/Images/1944/274173/Slider/06-1020x570.jpg" },
                    { 77, 77, "https://cdn.tgdd.vn/Products/Images/1944/230077/Slider/5-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/230077/Slider/7-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/230077/Slider/8-1020x570.jpg" },
                    { 78, 78, "https://cdn.tgdd.vn/Products/Images/1944/236158/Slider/3-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/1944/236158/Slider/4-1020x570-1.jpg" },
                    { 79, 79, "https://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734854518930.jpghttps://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734855308947.jpghttps://cdn.tgdd.vn/Products/Images/1944/316042/Slider/casper-75-kg-wt-75ng1638349734856288998.jpg" },
                    { 80, 80, "https://cdn.tgdd.vn/Products/Images/1944/307863/Slider/4-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1944/307863/Slider/5-1018x575.jpghttps://cdn.tgdd.vn/Products/Images/1944/307863/Slider/may-giat-aqua-inverter-9-5-kg-aqd-a952j-bk638271882394422354.jpg" },
                    { 81, 81, "https://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016161.jpghttps://cdn.tgdd.vn/Products/Images/1922/131925/Slider/sunhouse-mama-shd8955-210221-1016192.jpghttps://cdn.tgdd.vn/Products/Images/1922/131925/Slider/a6-780x433.png" },
                    { 82, 82, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080436398647.gifhttps://cdn.tgdd.vn/Products/Images/1922/296809/Slider/noi-com-dien-tu-sharp-18-lit-ks-com183mv-wh638144080743600911.jpghttps://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpg" },
                    { 83, 83, "https://cdn.tgdd.vn/Products/Images/1922/296809/Slider/sharp-18-lit-ks-com183mv-wh-5--2--1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1922/72067/Slider/vi-vn-cong-nghe-nau3d.jpghttps://cdn.tgdd.vn/Products/Images/1922/72067/Slider/NO2-780x433-A-780x433.jpg" },
                    { 84, 84, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921571.jpghttps://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921572.jpghttps://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpg" },
                    { 85, 85, "https://cdn.tgdd.vn/Products/Images/1922/152969/Slider/delites-ncg1805-010721-0921573.jpghttps://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-3.jpghttps://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 86, 86, "https://cdn.tgdd.vn/Products/Images/1922/189688/Slider/vi-vn-bluestone-rcb-5520-4.jpghttps://cdn.tgdd.vn/Products/Images/1922/203417/Slider/-dung-tich.jpghttps://cdn.tgdd.vn/Products/Images/1922/203417/Slider/vi-vn-cong-nghe-nau1d.jpg" },
                    { 87, 87, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-delites-ncr1502.jpghttps://cdn.tgdd.vn/Products/Images/1922/147243/Slider/n%E1%BB%93i-c%C6%A1m-n%E1%BA%AFp-r%E1%BB%9Di-delites-ncr1502-111120-0416280.jpghttps://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpg" },
                    { 88, 88, "https://cdn.tgdd.vn/Products/Images/1922/147243/Slider/-8.jpghttps://cdn.tgdd.vn/Products/Images/1922/275584/Slider/hinh-3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1922/275584/Slider/vi-vn-sunhouse-12-lit-shd8217w-4.jpg" },
                    { 89, 89, "https://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-thiet-ke.jpghttps://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-dung-tich.jpghttps://cdn.tgdd.vn/Products/Images/1922/218094/Slider/vi-vn-chat-lieu-long-noi.jpg" },
                    { 90, 90, "https://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-noi-com-nap-gai-toshiba-rc-10jh2pv-b-1l-(1).pnghttps://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-cong-nghe-nau1d-in-thuong.jpghttps://cdn.tgdd.vn/Products/Images/1922/219451/Slider/vi-vn-bang-dieu-khien.jpg" },
                    { 91, 91, "https://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928471.jpghttps://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928482.jpghttps://cdn.tgdd.vn/Products/Images/1922/240395/Slider/171121-0928483.jpg" },
                    { 92, 92, "https://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-2.jpghttps://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-toshiba-rc-18nmfvn-wt-10.jpghttps://cdn.tgdd.vn/Products/Images/1922/92601/Slider/vi-vn-cong-nghe-nau3d.jpg" },
                    { 93, 93, "https://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-thiet-ke.jpghttps://cdn.tgdd.vn/Products/Images/1922/220502/Slider/-dung-tich-1.jpghttps://cdn.tgdd.vn/Products/Images/1922/220502/Slider/vi-vn-cong-nghe-nau1d.jpg" },
                    { 94, 94, "https://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720211.jpghttps://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpghttps://cdn.tgdd.vn/Products/Images/1922/131916/Slider/sunhouse-mama-shd8903-210221-0720222.jpg" },
                    { 95, 95, "https://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-thietke2.jpghttps://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-dung-tich.jpghttps://cdn.tgdd.vn/Products/Images/1922/220499/Slider/vi-vn-cong-nghe-nau3d.jpg" },
                    { 96, 96, "https://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-18.jpghttps://cdn.tgdd.vn/Products/Images/2162/214631/Slider/1-780x433-780x433.jpghttps://cdn.tgdd.vn/Products/Images/2162/214631/Slider/vi-vn-dalton-ts-15g600x-13.jpg" },
                    { 97, 97, "https://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311729789327.jpghttps://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311732449371.jpghttps://cdn.tgdd.vn/Products/Images/2162/278796/Slider/keo-karaoke-nanomax-s-820637950311734499431.jpg" },
                    { 98, 98, "https://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-3.jpghttps://cdn.tgdd.vn/Products/Images/2162/308043/Slider/vi-vn-loa-keo-karaoke-nanomax-x-2000-4.jpg" },
                    { 99, 99, "https://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(2).jpghttps://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(3).jpghttps://cdn.tgdd.vn/Products/Images/2162/236681/Slider/vi-vn-keo-mobell-mk-2120c--(4).jpg" },
                    { 100, 100, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-3.jpghttps://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpg" },
                    { 101, 101, "https://cdn.tgdd.vn/Products/Images/2162/306932/Slider/vi-vn-loa-keo-karaoke-dalton-ts-12g350n-4.jpghttps://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014372-780x433.jpghttps://cdn.tgdd.vn/Products/Images/2162/214636/Slider/060421-1014340.jpg" },
                    { 102, 102, "https://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208261.jpghttps://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208272.jpghttps://cdn.tgdd.vn/Products/Images/2162/226094/Slider/nanomax-s-1000-060421-1208283.jpg" },
                    { 103, 103, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-3.jpghttps://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpg" },
                    { 104, 104, "https://cdn.tgdd.vn/Products/Images/2162/297489/Slider/vi-vn-loa-karaoke-nanomax-s-5000-4.jpghttps://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556233422401.jpghttps://cdn.tgdd.vn/Products/Images/2162/278932/Slider/loa-karaoke-dalton-ts-18a8500637923556232132456.jpg" },
                    { 105, 105, "https://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142290.jpghttps://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142311.jpghttps://cdn.tgdd.vn/Products/Images/2162/232105/Slider/loa-karaoke-nanomax-s-900-091220-1142322.jpg" },
                    { 106, 106, "https://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220311.jpghttps://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220322.jpghttps://cdn.tgdd.vn/Products/Images/2162/226090/Slider/dalton-ts-12g450x-060421-0220333.jpg" },
                    { 107, 107, "https://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-2.jpghttps://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpghttps://cdn.tgdd.vn/Products/Images/2162/304091/Slider/vi-vn-loa-keo-karaoke-birici-nb-6889-4.jpg" },
                    { 108, 108, "https://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325321.jpghttps://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325332.jpghttps://cdn.tgdd.vn/Products/Images/2162/220699/Slider/samsung-mx-t70-xv-120421-0325344.jpg" },
                    { 109, 109, "https://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042071.jpghttps://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042082.jpghttps://cdn.tgdd.vn/Products/Images/2162/210260/Slider/dalton-ts-18a1500-110421-1042093.jpg" },
                    { 110, 110, "https://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988717215598.jpghttps://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988715785825.jpghttps://cdn.tgdd.vn/Products/Images/2162/268876/Slider/loa-keo-karaoke-mobell-mk-5070637780988720605323.jpg" },
                    { 111, 111, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(1).jpghttps://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-vi-vn-vi-vn-vi-vn-sunhouse-shd7727-kg--(4).jpghttps://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpg" },
                    { 112, 112, "https://cdn.tgdd.vn/Products/Images/7498/199117/Slider/vi-vn-sunhouse-shd7727-kg--(2).jpghttps://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/320997/quat-dieu-hoa-daikiosan-dm103-2.jpg" },
                    { 113, 113, "https://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556893691639.jpghttps://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556894541546.jpghttps://cdn.tgdd.vn/Products/Images/7498/272138/Slider/ava-rpd-80637892556899521529.gif" },
                    { 114, 114, "https://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/320996/quat-dieu-hoa-daikiosan-dm102-4.jpg" },
                    { 115, 115, "https://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpghttps://cdn.tgdd.vn/Products/Images/7498/218312/Slider/vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(8).jpghttps://cdn.tgdd.vn/Products/Images/7498/218312/Slider/-vi-vn-may-lam-mat-khong-khi-kangaroo-kg50f62-(1)-copy.jpg" },
                    { 116, 116, "https://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/321978/quat-dieu-hoa-sunhouse-shd7745-4.jpg" },
                    { 117, 117, "https://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-12.jpghttps://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/319779/quat-dieu-hoa-delites-rpd-30-7.jpg" },
                    { 118, 118, "https://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/319781/quat-dieu-hoa-dmax-rpd-90-4.jpg" },
                    { 119, 119, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpg" },
                    { 120, 120, "https://cdn.tgdd.vn/Products/Images/7498/321770/quat-dieu-hoa-kangaroo-kg50f99-4.jpghttps://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/321769/quat-dieu-hoa-kangaroo-kg50f95-4.jpg" },
                    { 121, 121, "https://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085709130066.jpghttps://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085710240063.jpghttps://cdn.tgdd.vn/Products/Images/7498/307875/Slider/quat-dieu-hoa-hoa-phat-hpcf1-012638441085711406269.jpg" },
                    { 122, 122, "https://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-1.jpghttps://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-8.jpghttps://cdn.tgdd.vn/Products/Images/7498/321979/quat-dieu-hoa-sunhouse-shd7775-9.jpg" },
                    { 123, 123, "https://cdn.tgdd.vn/Products/Images/7498/219138/Slider/vi-vn-quat-dieu-hoa-khong-khi-rapido-9000d-(1).jpghttps://cdn.tgdd.vn/Products/Images/7498/219138/Slider/Untitled-2-780x433.jpghttps://cdn.tgdd.vn/Products/Images/7498/219138/Slider/quat-dieu-hoa-khong-khi-rapido-9000d-190821-0759520.jpg" },
                    { 124, 124, "https://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-2.jpghttps://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-3.jpghttps://cdn.tgdd.vn/Products/Images/7498/320999/quat-dieu-hoa-daikiosan-dm202-4.jpg" },
                    { 125, 125, "https://cdn.tgdd.vn/Products/Images/7498/235380/Slider/thietke-780x433.jpghttps://cdn.tgdd.vn/Products/Images/7498/235380/Slider/congsuat-780x433-1.jpghttps://cdn.tgdd.vn/Products/Images/7498/235380/Slider/dakho-780x433-1.jpg" },
                    { 126, 126, "https://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750178906564.jpghttps://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750177976576.jpghttps://cdn.tgdd.vn/Products/Images/9418/307646/Slider/noi-chien-khong-dau-rapido-smart-70m-7-lit638215750176666568.jpg" },
                    { 127, 127, "https://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit-1a-min-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342257456180.jpghttps://cdn.tgdd.vn/Products/Images/9418/258338/Slider/sunhouse-shd4062-55-lit637926342256156195-1020x570--2--1020x570.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 128, 128, "https://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662592506879.gifhttps://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638318407391409045.jpghttps://cdn.tgdd.vn/Products/Images/9418/304773/Slider/noi-chien-khong-dau-rapido-raf-80m-8-lit638240662590086953.jpg" },
                    { 129, 129, "https://cdn.tgdd.vn/Products/Images/9418/240313/Slider/ava-kdf-593d-75lit637956538234543296.jpghttps://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-3-(1).jpghttps://cdn.tgdd.vn/Products/Images/9418/240313/Slider/tinh-nang-5-(2).jpg" },
                    { 130, 130, "https://cdn.tgdd.vn/Products/Images/9418/240297/Slider/ava-af358t-4-lit637956536037141108.jpghttps://cdn.tgdd.vn/Products/Images/9418/240297/Slider/3-1020x573.jpghttps://cdn.tgdd.vn/Products/Images/9418/240297/Slider/5-1020x570.jpg" },
                    { 131, 131, "https://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-2.gifhttps://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-3.jpghttps://cdn.tgdd.vn/Products/Images/9418/275125/Slider/vi-vn-sunhouse-shd4035-9-lit-4--2--1020x570.jpg" },
                    { 132, 132, "https://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit-2-min-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474989859767-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/249385/Slider/sunhouse-shd4026-6-lit637919474988859626-1020x570.jpg" },
                    { 133, 133, "https://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194027111283.jpghttps://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194028841288.gifhttps://cdn.tgdd.vn/Products/Images/9418/309914/Slider/lo-chien-khong-dau-ferroli-faf-12m-12-lit638296194036871330.jpg" },
                    { 134, 134, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-2.jpghttps://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-3.jpghttps://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpg" },
                    { 135, 135, "https://cdn.tgdd.vn/Products/Images/9418/306722/Slider/vi-vn-noi-chien-khong-dau-toshiba-af-74cs2srvn-b-74-lit-4.jpghttps://cdn.tgdd.vn/Products/Images/9418/217595/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/217595/Slider/noi-chien-khong-dau-kangaroo-kg55af1a-2-1020x570.jpg" },
                    { 136, 136, "https://cdn.tgdd.vn/Products/Images/9418/233494/Slider/hafele-af-t5a-2-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/9418/233494/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/233494/Slider/5-1020x570.jpg" },
                    { 137, 137, "https://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035764079802.jpghttps://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit-6-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/275124/Slider/lo-chien-khong-dau-sunhouse-mama-shd4088-15-lit637928035762639897.jpg" },
                    { 138, 138, "https://cdn.tgdd.vn/Products/Images/9418/235357/Slider/ava-af40155d-5-lit637956537558080659.jpghttps://cdn.tgdd.vn/Products/Images/9418/235357/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/9418/235357/Slider/tinh-nang-5.jpg" },
                    { 139, 139, "https://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-2-1020x570-1.jpghttps://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047016485840.jpghttps://cdn.tgdd.vn/Products/Images/9418/231967/Slider/philips-hd9200-90-24-lit637679047018855747.jpg" },
                    { 140, 140, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018751589262.jpghttps://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638284018737269189.gifhttps://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpg" },
                    { 141, 141, "https://cdn.tgdd.vn/Products/Images/9418/242418/Slider/lo-chien-khong-dau-kangaroo-kg12af1a-12-lit638327078654735616.jpghttps://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(2).jpghttps://cdn.tgdd.vn/Products/Images/1992/73337/Slider/-kdk-m40k-xam-gy-(4).jpg" },
                    { 142, 142, "https://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(2).jpghttps://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(3).jpghttps://cdn.tgdd.vn/Products/Images/1992/73339/Slider/vi-vn-kdk-m40m-(4).jpg" },
                    { 143, 143, "https://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409519551001.jpghttps://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409520581014.jpghttps://cdn.tgdd.vn/Products/Images/1992/268450/Slider/dung-senko-dh1600637981409521621105.jpg" },
                    { 144, 144, "https://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221087301321.gifhttps://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221081601265.gifhttps://cdn.tgdd.vn/Products/Images/1992/275524/Slider/lung-asia-vy538990638244221096181354.jpg" },
                    { 145, 145, "https://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-1.jpghttps://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-3.jpghttps://cdn.tgdd.vn/Products/Images/1992/164540/Slider/-toshiba-f-lsa20-h-vn-2.jpg" },
                    { 146, 146, "https://cdn.tgdd.vn/Products/Images/1992/206027/Slider/-artboard-3-(1).jpghttps://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-2.jpghttps://cdn.tgdd.vn/Products/Images/1992/206027/Slider/vi-vn-artboard-1-(1).jpg" },
                    { 147, 147, "https://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861153767.jpghttps://cdn.tgdd.vn/Products/Images/1992/268452/Slider/lung-senko-l1638637962675861983811.jpghttps://cdn.tgdd.vn/Products/Images/1992/268452/Slider/vi-vn-lung-senko-l1638637962675862923843-copy.jpg" },
                    { 148, 148, "https://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831920187882.gifhttps://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831923127883.jpghttps://cdn.tgdd.vn/Products/Images/1992/268453/Slider/lung-senko-lts1636637973831922237870.jpg" },
                    { 149, 149, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792400586624.gifhttps://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792399526428.jpghttps://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpg" },
                    { 150, 150, "https://cdn.tgdd.vn/Products/Images/1992/275185/Slider/dung-asia-vy539790638366792398416416.jpghttps://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-3.jpghttps://cdn.tgdd.vn/Products/Images/1992/322619/quat-lung-asia-vy628890-75w-4.jpg" },
                    { 151, 151, "https://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784521558850.gifhttps://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784530598927.jpghttps://cdn.tgdd.vn/Products/Images/1992/275186/Slider/dung-asia-vy639990638366784498602706.jpg" },
                    { 152, 152, "https://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpghttps://cdn.tgdd.vn/Products/Images/1992/275528/vy3777901.jpghttps://cdn.tgdd.vn/Products/Images/1992/275528/vy3777905.jpg" },
                    { 153, 153, "https://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426805242552.jpghttps://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426806303120.jpghttps://cdn.tgdd.vn/Products/Images/1992/268448/Slider/ban-senko-b1213637919426807332619.gif" },
                    { 154, 154, "https://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270747742066.jpghttps://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270748552124.jpghttps://cdn.tgdd.vn/Products/Images/1992/268462/Slider/quat-treo-senko-tc1622637970270750642154.jpg" },
                    { 155, 155, "https://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-1.jpghttps://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-quat-hop-midea-kyt30-15a-trang-5.jpghttps://cdn.tgdd.vn/Products/Images/1992/207672/Slider/vi-vn-canh-quat.jpg" },
                    { 156, 156, "https://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-may-say-thong-hoi-galanz-dv-70q1c-2.jpghttps://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-khoi-luong-may-say-thong-hoi-galanz-dv-70q1c-3.jpghttps://cdn.tgdd.vn/Products/Images/2202/302178/Slider/vi-vn-chuong-trinh-say-may-say-thong-hoi-galanz-dv-70q1c-4.jpg" },
                    { 157, 157, "https://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128165.jpghttps://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128178-(1).jpghttps://cdn.tgdd.vn/Products/Images/2202/241930/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-s-100621-1128160.jpg" },
                    { 158, 158, "https://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-19.pnghttps://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-20.pnghttps://cdn.tgdd.vn/Products/Images/2202/241929/Slider/vi-vn-may-say-thong-hoi-galanz-7-kg-dv-70t5c-w-21.png" },
                    { 159, 159, "https://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253873168169.jpghttps://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874088441.jpghttps://cdn.tgdd.vn/Products/Images/2202/273320/Slider/may-say-casper-td-72vwd637895253874968425.jpg" },
                    { 160, 160, "https://cdn.tgdd.vn/Products/Images/2202/272144/Slider/2-1028x578.jpghttps://cdn.tgdd.vn/Products/Images/2202/272144/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/2202/272144/Slider/4-1020x570.jpg" },
                    { 161, 161, "https://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023825.jpghttps://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-120723-023856.jpghttps://cdn.tgdd.vn/Products/Images/2202/310253/may-say-toshiba-td-h80sev-sk-130723-113516.jpg" },
                    { 162, 162, "https://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175913318814.jpghttps://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175914328840.jpghttps://cdn.tgdd.vn/Products/Images/2202/272143/Slider/may-say-thong-hoi-electrolux-75-kg-edv754h3wb637895175915268944.jpg" },
                    { 163, 163, "https://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-2.jpghttps://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-3.jpghttps://cdn.tgdd.vn/Products/Images/2202/284038/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-9-kg-edh903r9wb-4.jpg" },
                    { 164, 164, "https://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087530263383.jpghttps://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087531273334.jpghttps://cdn.tgdd.vn/Products/Images/2202/272145/Slider/may-say-thong-hoi-electrolux-85-kg-edv854n3sb637895087532343348.jpg" },
                    { 165, 165, "https://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-khoi-luong-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-2.jpghttps://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-say-bom-nhiet-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-3.jpghttps://cdn.tgdd.vn/Products/Images/2202/284036/Slider/vi-vn-chuong-trinh-say-may-say-bom-nhiet-electrolux-8-kg-edh804h5wb-4.jpg" },
                    { 166, 166, "https://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620147203825.jpghttps://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620148293832.jpghttps://cdn.tgdd.vn/Products/Images/2202/307973/Slider/may-say-bom-nhiet-lg-%20inverter-105-kg-dvhp50b638221620149193805.jpg" },
                    { 167, 167, "https://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpghttps://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701392682546.jpghttps://cdn.tgdd.vn/Products/Images/2202/272142/Slider/may-say-thong-hoi-electrolux-85-kg-eds854n3sb637809701396132621.jpg" },
                    { 168, 168, "https://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-110955.jpghttps://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111058.jpghttps://cdn.tgdd.vn/Products/Images/2202/310251/may-say-ngung-tu-toshiba-8-kg-td-k90mev-sk-110723-111131.jpg" },
                    { 169, 169, "https://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745148.jpghttps://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745116.jpghttps://cdn.tgdd.vn/Products/Images/2202/227250/Slider/190820-0745083.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { 170, 170, "https://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344524.jpghttps://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344545.jpghttps://cdn.tgdd.vn/Products/Images/2202/230073/Slider/231120-0344492.jpg" },
                    { 171, 171, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg" },
                    { 172, 172, "https://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856450686028.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856449736008.jpghttps://cdn.tgdd.vn/Products/Images/1987/299620/Slider/lo-vi-song-electrolux-emm23k22b-23-lit638181856448716035.jpg" },
                    { 173, 173, "https://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533255389572.jpghttps://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533254489493.jpghttps://cdn.tgdd.vn/Products/Images/1987/299616/Slider/lo-vi-song-electrolux-emm20k22w-20-lit638114533251179393.jpg" },
                    { 174, 174, "https://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362669326069.jpghttps://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667866005.jpghttps://cdn.tgdd.vn/Products/Images/1987/303492/Slider/lo-vi-song-panasonic-nn-st34nbyue-25-lit638199362667026013.jpg" },
                    { 175, 175, "https://cdn.tgdd.vn/Products/Images/1987/242774/Slider/bluestone-mob-7733-25-lit637688001563014937.jpghttps://cdn.tgdd.vn/Products/Images/1987/242774/Slider/3-1020x570.jpghttps://cdn.tgdd.vn/Products/Images/1987/242774/Slider/4-1020x570.jpg" },
                    { 176, 176, "https://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082498421640.jpghttps://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082497591644.jpghttps://cdn.tgdd.vn/Products/Images/1987/303491/Slider/lo-vi-song-panasonic-nn-sm33nbyue-25-lit638193082496741625.jpg" },
                    { 177, 177, "https://cdn.tgdd.vn/Products/Images/1987/197818/Slider/2-min.jpghttps://cdn.tgdd.vn/Products/Images/1987/197818/Slider/3.jpghttps://cdn.tgdd.vn/Products/Images/1987/197818/Slider/4.jpg" },
                    { 178, 178, "https://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882448995926.jpghttps://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882450315945.jpghttps://cdn.tgdd.vn/Products/Images/1987/242766/Slider/bluestone-mob-7708b-20-lit637704882451896008.jpg" },
                    { 179, 179, "https://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053426432333.jpghttps://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053425522315.jpghttps://cdn.tgdd.vn/Products/Images/1987/305855/Slider/lo-vi-song-electrolux-emg30d22bm-30-lit638200053424072423.jpg" },
                    { 180, 180, "https://cdn.tgdd.vn/Products/Images/1987/203059/Slider/2.jpghttps://cdn.tgdd.vn/Products/Images/1987/203059/Slider/3.jpghttps://cdn.tgdd.vn/Products/Images/1987/203059/Slider/4.jpg" },
                    { 181, 181, "https://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102501.jpghttps://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-1102512.jpghttps://cdn.tgdd.vn/Products/Images/1987/69080/Slider/251021-0653220.jpg" },
                    { 182, 182, "https://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642354.jpghttps://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642396.jpghttps://cdn.tgdd.vn/Products/Images/1987/235256/Slider/150321-0642322.jpg" },
                    { 183, 183, "https://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742187747662.jpghttps://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742188627552.jpghttps://cdn.tgdd.vn/Products/Images/1987/203563/Slider/lo-vi-song-electrolux-emg20k38gwp637696742189537562.jpg" },
                    { 184, 184, "https://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333812797881.jpghttps://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333811900019.jpghttps://cdn.tgdd.vn/Products/Images/1987/316809/Slider/lo-vi-song-sharp-r-211tv-bk-21-lit638363333810992534.jpg" },
                    { 185, 185, "https://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777980886164.jpghttps://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777979636127.jpghttps://cdn.tgdd.vn/Products/Images/1987/299618/Slider/lo-vi-song-co-nuong-electrolux-emg23d22b-23-lit638131777978286125.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 19, 23, 16, 32, 657, DateTimeKind.Local).AddTicks(3573));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 19, 19, 22, 39, 11, DateTimeKind.Local).AddTicks(9751));
        }
    }
}
