using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital_Pocket_Monster.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(15)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(25)", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(25)", nullable: false),
                    CardType = table.Column<string>(type: "varchar(10)", nullable: false),
                    Color = table.Column<string>(type: "varchar(10)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    Image = table.Column<string>(type: "varchar(75)", nullable: false),
                    DigivolveColor = table.Column<string>(type: "varchar(10)", nullable: false),
                    PlayCost = table.Column<int>(type: "int", nullable: false),
                    CardPower = table.Column<int>(type: "int", nullable: false),
                    Race = table.Column<string>(type: "varchar(25)", nullable: false),
                    Attribute = table.Column<string>(type: "varchar(25)", nullable: false),
                    StageLevel = table.Column<string>(type: "varchar(10)", nullable: false),
                    Rarity = table.Column<string>(type: "varchar(15)", nullable: false),
                    AmountOwned = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckName = table.Column<string>(type: "varchar(25)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackName = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountInfo");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "Packs");
        }
    }
}
