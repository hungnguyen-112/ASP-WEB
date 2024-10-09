using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiKiemTra02.Data.Migrations
{
    /// <inheritdoc />
    public partial class LopHocMoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "lopHoc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "lopHoc");
        }
    }
}
