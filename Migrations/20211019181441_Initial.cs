using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GearsCharacters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CharacterDesc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CharacterAge = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CharacterImage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearsCharacters", x => x.CharacterID);
                });

            migrationBuilder.CreateTable(
                name: "GearsGuns",
                columns: table => new
                {
                    GunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GunName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GunDesc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GunDamage = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    GunShots = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    GunImage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearsGuns", x => x.GunID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GearsCharacters");

            migrationBuilder.DropTable(
                name: "GearsGuns");
        }
    }
}
