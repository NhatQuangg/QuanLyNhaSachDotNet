using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhaSach.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sanphams",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tensanpham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soluong = table.Column<long>(type: "bigint", nullable: false),
                    dongia = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanphams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "taikhoans",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tendangnhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matkhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taikhoans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hoadons",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thanhtien = table.Column<long>(type: "bigint", nullable: false),
                    id_taikhoan = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadons", x => x.id);
                    table.ForeignKey(
                        name: "FK_hoadons_taikhoans_id_taikhoan",
                        column: x => x.id_taikhoan,
                        principalTable: "taikhoans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chitietsanphams",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soluong = table.Column<long>(type: "bigint", nullable: false),
                    id_hoadon = table.Column<long>(type: "bigint", nullable: false),
                    id_sanpham = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitietsanphams", x => x.id);
                    table.ForeignKey(
                        name: "FK_chitietsanphams_hoadons_id_hoadon",
                        column: x => x.id_hoadon,
                        principalTable: "hoadons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chitietsanphams_sanphams_id_sanpham",
                        column: x => x.id_sanpham,
                        principalTable: "sanphams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "taikhoans",
                columns: new[] { "id", "hoten", "matkhau", "tendangnhap" },
                values: new object[] { 1L, "admin", "123", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_chitietsanphams_id_hoadon",
                table: "chitietsanphams",
                column: "id_hoadon");

            migrationBuilder.CreateIndex(
                name: "IX_chitietsanphams_id_sanpham",
                table: "chitietsanphams",
                column: "id_sanpham");

            migrationBuilder.CreateIndex(
                name: "IX_hoadons_id_taikhoan",
                table: "hoadons",
                column: "id_taikhoan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chitietsanphams");

            migrationBuilder.DropTable(
                name: "hoadons");

            migrationBuilder.DropTable(
                name: "sanphams");

            migrationBuilder.DropTable(
                name: "taikhoans");
        }
    }
}
