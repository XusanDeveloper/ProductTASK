using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductTASK.Migrations
{
    public partial class qaytaUrinishw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserIsmi",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AspNetUsers",
                newName: "Username");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e14795b-e06a-4971-99bc-ff9372e6ed74"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 29, 45, 684, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7cdb71fb-bb3a-4b12-99db-1f2de85675a6"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 29, 45, 684, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b719b27f-d2ac-4f00-83bf-a4e56e194c70"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 7, 16, 29, 45, 684, DateTimeKind.Local).AddTicks(2101));
        }
    }
}
