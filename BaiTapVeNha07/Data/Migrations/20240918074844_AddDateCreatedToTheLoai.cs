using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiTap07.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDateCreatedToTheLoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCraeted",
                table: "TheLoai",
                newName: "DateCreated");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "TheLoai",
                newName: "DateCraeted");
        }
    }
}
