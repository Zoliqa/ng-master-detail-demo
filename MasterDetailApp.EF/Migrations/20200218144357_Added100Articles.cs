using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterDetailApp.EF.Migrations
{
    public partial class Added100Articles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CreatedDateTime", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2020, 2, 17, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(6932), "Description1", "Title1" },
                    { 74, 1, new DateTime(2019, 12, 6, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(503), "Description74", "Title74" },
                    { 73, 2, new DateTime(2019, 12, 7, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(472), "Description73", "Title73" },
                    { 72, 1, new DateTime(2019, 12, 8, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(439), "Description72", "Title72" },
                    { 71, 1, new DateTime(2019, 12, 9, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(406), "Description71", "Title71" },
                    { 70, 2, new DateTime(2019, 12, 10, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(375), "Description70", "Title70" },
                    { 69, 1, new DateTime(2019, 12, 11, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(342), "Description69", "Title69" },
                    { 68, 2, new DateTime(2019, 12, 12, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(311), "Description68", "Title68" },
                    { 67, 2, new DateTime(2019, 12, 13, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(277), "Description67", "Title67" },
                    { 66, 2, new DateTime(2019, 12, 14, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(186), "Description66", "Title66" },
                    { 65, 1, new DateTime(2019, 12, 15, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(154), "Description65", "Title65" },
                    { 64, 1, new DateTime(2019, 12, 16, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(122), "Description64", "Title64" },
                    { 63, 1, new DateTime(2019, 12, 17, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(95), "Description63", "Title63" },
                    { 62, 1, new DateTime(2019, 12, 18, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(63), "Description62", "Title62" },
                    { 61, 1, new DateTime(2019, 12, 19, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(30), "Description61", "Title61" },
                    { 60, 2, new DateTime(2019, 12, 20, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9998), "Description60", "Title60" },
                    { 59, 1, new DateTime(2019, 12, 21, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9968), "Description59", "Title59" },
                    { 58, 2, new DateTime(2019, 12, 22, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9936), "Description58", "Title58" },
                    { 57, 1, new DateTime(2019, 12, 23, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9904), "Description57", "Title57" },
                    { 56, 2, new DateTime(2019, 12, 24, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9873), "Description56", "Title56" },
                    { 55, 1, new DateTime(2019, 12, 25, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9841), "Description55", "Title55" },
                    { 54, 2, new DateTime(2019, 12, 26, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9809), "Description54", "Title54" },
                    { 75, 2, new DateTime(2019, 12, 5, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(534), "Description75", "Title75" },
                    { 76, 1, new DateTime(2019, 12, 4, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(565), "Description76", "Title76" },
                    { 77, 1, new DateTime(2019, 12, 3, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(597), "Description77", "Title77" },
                    { 78, 1, new DateTime(2019, 12, 2, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(625), "Description78", "Title78" },
                    { 100, 2, new DateTime(2019, 11, 10, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1399), "Description100", "Title100" },
                    { 99, 2, new DateTime(2019, 11, 11, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1371), "Description99", "Title99" },
                    { 98, 2, new DateTime(2019, 11, 12, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1342), "Description98", "Title98" },
                    { 97, 1, new DateTime(2019, 11, 13, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1304), "Description97", "Title97" },
                    { 96, 1, new DateTime(2019, 11, 14, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1221), "Description96", "Title96" },
                    { 95, 1, new DateTime(2019, 11, 15, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1193), "Description95", "Title95" },
                    { 94, 2, new DateTime(2019, 11, 16, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1160), "Description94", "Title94" },
                    { 93, 2, new DateTime(2019, 11, 17, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1126), "Description93", "Title93" },
                    { 92, 1, new DateTime(2019, 11, 18, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1096), "Description92", "Title92" },
                    { 91, 2, new DateTime(2019, 11, 19, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1065), "Description91", "Title91" },
                    { 53, 1, new DateTime(2019, 12, 27, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9747), "Description53", "Title53" },
                    { 90, 2, new DateTime(2019, 11, 20, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1032), "Description90", "Title90" },
                    { 88, 1, new DateTime(2019, 11, 22, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(968), "Description88", "Title88" },
                    { 87, 1, new DateTime(2019, 11, 23, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(938), "Description87", "Title87" },
                    { 86, 1, new DateTime(2019, 11, 24, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(908), "Description86", "Title86" },
                    { 85, 1, new DateTime(2019, 11, 25, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(878), "Description85", "Title85" },
                    { 84, 1, new DateTime(2019, 11, 26, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(848), "Description84", "Title84" },
                    { 83, 1, new DateTime(2019, 11, 27, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(817), "Description83", "Title83" },
                    { 82, 2, new DateTime(2019, 11, 28, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(783), "Description82", "Title82" },
                    { 81, 2, new DateTime(2019, 11, 29, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(718), "Description81", "Title81" },
                    { 80, 1, new DateTime(2019, 11, 30, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(686), "Description80", "Title80" },
                    { 79, 2, new DateTime(2019, 12, 1, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(655), "Description79", "Title79" },
                    { 89, 1, new DateTime(2019, 11, 21, 16, 43, 56, 918, DateTimeKind.Local).AddTicks(1001), "Description89", "Title89" },
                    { 52, 1, new DateTime(2019, 12, 28, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9715), "Description52", "Title52" },
                    { 51, 2, new DateTime(2019, 12, 29, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9683), "Description51", "Title51" },
                    { 50, 1, new DateTime(2019, 12, 30, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9651), "Description50", "Title50" },
                    { 22, 2, new DateTime(2020, 1, 27, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8670), "Description22", "Title22" },
                    { 21, 1, new DateTime(2020, 1, 28, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8639), "Description21", "Title21" },
                    { 20, 1, new DateTime(2020, 1, 29, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8606), "Description20", "Title20" },
                    { 19, 2, new DateTime(2020, 1, 30, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8575), "Description19", "Title19" },
                    { 18, 2, new DateTime(2020, 1, 31, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8545), "Description18", "Title18" },
                    { 17, 2, new DateTime(2020, 2, 1, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8511), "Description17", "Title17" },
                    { 16, 2, new DateTime(2020, 2, 2, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8481), "Description16", "Title16" },
                    { 15, 2, new DateTime(2020, 2, 3, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8448), "Description15", "Title15" },
                    { 14, 1, new DateTime(2020, 2, 4, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8416), "Description14", "Title14" },
                    { 13, 1, new DateTime(2020, 2, 5, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8384), "Description13", "Title13" },
                    { 12, 2, new DateTime(2020, 2, 6, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8351), "Description12", "Title12" },
                    { 11, 2, new DateTime(2020, 2, 7, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8320), "Description11", "Title11" },
                    { 10, 1, new DateTime(2020, 2, 8, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8285), "Description10", "Title10" },
                    { 9, 2, new DateTime(2020, 2, 9, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8182), "Description9", "Title9" },
                    { 8, 2, new DateTime(2020, 2, 10, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8151), "Description8", "Title8" },
                    { 7, 1, new DateTime(2020, 2, 11, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8119), "Description7", "Title7" },
                    { 6, 2, new DateTime(2020, 2, 12, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8088), "Description6", "Title6" },
                    { 5, 2, new DateTime(2020, 2, 13, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8049), "Description5", "Title5" },
                    { 4, 1, new DateTime(2020, 2, 14, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8019), "Description4", "Title4" },
                    { 3, 1, new DateTime(2020, 2, 15, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(7985), "Description3", "Title3" },
                    { 2, 2, new DateTime(2020, 2, 16, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(7934), "Description2", "Title2" },
                    { 23, 2, new DateTime(2020, 1, 26, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8701), "Description23", "Title23" },
                    { 24, 2, new DateTime(2020, 1, 25, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8731), "Description24", "Title24" },
                    { 25, 2, new DateTime(2020, 1, 24, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8798), "Description25", "Title25" },
                    { 38, 1, new DateTime(2020, 1, 11, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9215), "Description38", "Title38" },
                    { 47, 1, new DateTime(2020, 1, 2, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9557), "Description47", "Title47" },
                    { 46, 1, new DateTime(2020, 1, 3, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9528), "Description46", "Title46" },
                    { 45, 1, new DateTime(2020, 1, 4, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9495), "Description45", "Title45" },
                    { 44, 1, new DateTime(2020, 1, 5, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9465), "Description44", "Title44" },
                    { 43, 1, new DateTime(2020, 1, 6, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9433), "Description43", "Title43" },
                    { 42, 2, new DateTime(2020, 1, 7, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9401), "Description42", "Title42" },
                    { 41, 1, new DateTime(2020, 1, 8, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9369), "Description41", "Title41" },
                    { 40, 2, new DateTime(2020, 1, 9, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9338), "Description40", "Title40" },
                    { 39, 2, new DateTime(2020, 1, 10, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9304), "Description39", "Title39" },
                    { 26, 1, new DateTime(2020, 1, 23, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8830), "Description26", "Title26" },
                    { 37, 1, new DateTime(2020, 1, 12, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9181), "Description37", "Title37" },
                    { 36, 2, new DateTime(2020, 1, 13, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9151), "Description36", "Title36" },
                    { 35, 2, new DateTime(2020, 1, 14, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9119), "Description35", "Title35" },
                    { 34, 2, new DateTime(2020, 1, 15, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9087), "Description34", "Title34" },
                    { 33, 1, new DateTime(2020, 1, 16, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9054), "Description33", "Title33" },
                    { 32, 2, new DateTime(2020, 1, 17, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9022), "Description32", "Title32" },
                    { 31, 2, new DateTime(2020, 1, 18, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8991), "Description31", "Title31" },
                    { 30, 2, new DateTime(2020, 1, 19, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8959), "Description30", "Title30" },
                    { 29, 1, new DateTime(2020, 1, 20, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8927), "Description29", "Title29" },
                    { 28, 2, new DateTime(2020, 1, 21, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8894), "Description28", "Title28" },
                    { 27, 1, new DateTime(2020, 1, 22, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(8862), "Description27", "Title27" },
                    { 48, 1, new DateTime(2020, 1, 1, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9588), "Description48", "Title48" },
                    { 49, 1, new DateTime(2019, 12, 31, 16, 43, 56, 917, DateTimeKind.Local).AddTicks(9619), "Description49", "Title49" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2020, 2, 18, 16, 43, 56, 907, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2020, 2, 18, 16, 43, 56, 914, DateTimeKind.Local).AddTicks(293));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2020, 2, 18, 16, 37, 6, 852, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2020, 2, 18, 16, 37, 6, 857, DateTimeKind.Local).AddTicks(7489));
        }
    }
}
