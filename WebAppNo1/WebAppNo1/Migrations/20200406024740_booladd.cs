using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppNo1.Migrations
{
    public partial class booladd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(nullable: true),
                    direct = table.Column<string>(nullable: true),
                    primilry = table.Column<string>(nullable: true),
                    forien = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conptions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Individals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    age = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    province = table.Column<string>(nullable: true),
                    macle = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individals", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conptions");

            migrationBuilder.DropTable(
                name: "Individals");
        }
    }
}
