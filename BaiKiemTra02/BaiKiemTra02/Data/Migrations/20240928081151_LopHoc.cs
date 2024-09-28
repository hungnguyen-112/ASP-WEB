using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra02.Data.Migrations
{
    /// <inheritdoc />
    public partial class LopHoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "lopHoc");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "lopHoc");

            migrationBuilder.RenameColumn(
                name: "Teacher",
                table: "lopHoc",
                newName: "TenLopHoc");

            migrationBuilder.AddColumn<int>(
                name: "NamNhapHoc",
                table: "lopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NamRaTruong",
                table: "lopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongSinhVien",
                table: "lopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NamNhapHoc",
                table: "lopHoc");

            migrationBuilder.DropColumn(
                name: "NamRaTruong",
                table: "lopHoc");

            migrationBuilder.DropColumn(
                name: "SoLuongSinhVien",
                table: "lopHoc");

            migrationBuilder.RenameColumn(
                name: "TenLopHoc",
                table: "lopHoc",
                newName: "Teacher");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "lopHoc",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "lopHoc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
