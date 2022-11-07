using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductTASK.Migrations
{
    public partial class UI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserIsmi",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e14795b-e06a-4971-99bc-ff9372e6ed74"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 17, 14, 32, 737, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cdb71fb-bb3a-4b12-99db-1f2de85675a6"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 17, 14, 32, 737, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b719b27f-d2ac-4f00-83bf-a4e56e194c70"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 17, 14, 32, 737, DateTimeKind.Local).AddTicks(2211));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserIsmi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e14795b-e06a-4971-99bc-ff9372e6ed74"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 17, 9, 16, 145, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cdb71fb-bb3a-4b12-99db-1f2de85675a6"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 17, 9, 16, 145, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b719b27f-d2ac-4f00-83bf-a4e56e194c70"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 17, 9, 16, 145, DateTimeKind.Local).AddTicks(5091));
        }
    }
}
