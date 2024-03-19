using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApiApp.Migrations
{
    public partial class Cuahang1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuaHangs",
                columns: table => new
                {
                    MaCuaHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<int>(type: "int", nullable: false),
                    ChieuRong = table.Column<int>(type: "int", nullable: false),
                    PhoneyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHangs", x => x.MaCuaHang);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuaHangs");
        }
    }
}
