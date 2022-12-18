using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetOpdracht1.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubNaam = table.Column<string>(name: "Club_Naam", type: "nvarchar(max)", nullable: false),
                    ClubAdres = table.Column<string>(name: "Club_Adres", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Niveau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Klassement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ELOPunten = table.Column<int>(name: "ELO_Punten", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveau", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubId = table.Column<int>(name: "Club_Id", type: "int", nullable: false),
                    SpelerVoornaam = table.Column<string>(name: "Speler_Voornaam", type: "nvarchar(max)", nullable: false),
                    spelerAchternaam = table.Column<string>(name: "speler_Achternaam", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Niveau");

            migrationBuilder.DropTable(
                name: "Speler");
        }
    }
}
