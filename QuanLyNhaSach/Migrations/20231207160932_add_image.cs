using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhaSach.Migrations
{
    /// <inheritdoc />
    public partial class add_image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "anh",
                table: "sanphams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anh",
                table: "sanphams");
        }
    }
}
