using Microsoft.EntityFrameworkCore.Migrations;

namespace SAT_Proje.Migrations
{
    public partial class sat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanıcı = table.Column<string>(type: "Varchar(10)", nullable: true),
                    Şifre = table.Column<string>(type: "Varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Durums",
                columns: table => new
                {
                    DurumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunSayısı = table.Column<int>(type: "int", nullable: false),
                    MusterıSayısı = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durums", x => x.DurumId);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunBarkod = table.Column<int>(type: "int", nullable: false),
                    UrunFıyat = table.Column<int>(type: "int", nullable: false),
                    UrunAdet = table.Column<int>(type: "int", nullable: false),
                    UrunAcıklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "Musterı",
                columns: table => new
                {
                    MusterıId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusterıAdıSoyadı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusterıAcıkAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Musterıtel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusterıSehır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SıparıDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musterı", x => x.MusterıId);
                    table.ForeignKey(
                        name: "FK_Musterı_Uruns_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Uruns",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musterı_UrunId",
                table: "Musterı",
                column: "UrunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Durums");

            migrationBuilder.DropTable(
                name: "Musterı");

            migrationBuilder.DropTable(
                name: "Uruns");
        }
    }
}
