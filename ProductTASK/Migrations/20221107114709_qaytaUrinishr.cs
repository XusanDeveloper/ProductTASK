using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductTASK.Migrations
{
    public partial class qaytaUrinishr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e14795b-e06a-4971-99bc-ff9372e6ed74"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 47, 9, 11, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cdb71fb-bb3a-4b12-99db-1f2de85675a6"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 47, 9, 11, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b719b27f-d2ac-4f00-83bf-a4e56e194c70"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 47, 9, 11, DateTimeKind.Local).AddTicks(8178));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e14795b-e06a-4971-99bc-ff9372e6ed74"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 43, 36, 60, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cdb71fb-bb3a-4b12-99db-1f2de85675a6"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 43, 36, 60, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b719b27f-d2ac-4f00-83bf-a4e56e194c70"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 43, 36, 60, DateTimeKind.Local).AddTicks(5040));
        }
    }
}
