using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterDetailApp.EF.Migrations
{
    public partial class AddedTwoCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "Name" },
                values: new object[] { 1, new DateTime(2020, 2, 18, 16, 37, 6, 852, DateTimeKind.Local).AddTicks(4818), "Category1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "Name" },
                values: new object[] { 2, new DateTime(2020, 2, 18, 16, 37, 6, 857, DateTimeKind.Local).AddTicks(7489), "Category2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
