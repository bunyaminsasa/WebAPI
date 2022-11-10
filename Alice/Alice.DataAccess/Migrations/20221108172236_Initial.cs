using Microsoft.EntityFrameworkCore.Migrations;

namespace Alice.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    OgrenciNo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fakulte = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Bolum = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenci");
        }
    }
}
