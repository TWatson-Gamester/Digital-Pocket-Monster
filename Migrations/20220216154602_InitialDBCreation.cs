using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital_Pocket_Monster.Migrations
{
    public partial class InitialDBCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "varchar(15)", nullable: false),
                    lastName = table.Column<string>(type: "varchar(25)", nullable: false),
                    username = table.Column<string>(type: "varchar(50)", nullable: false),
                    password = table.Column<string>(type: "varchar(50)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false)
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
                    name = table.Column<string>(type: "varchar(25)", nullable: false),
                    description = table.Column<string>(type: "varchar(250)", nullable: false),
                    cardType = table.Column<string>(type: "varchar(10)", nullable: false),
                    color = table.Column<string>(type: "varchar(10)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    cardNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    image = table.Column<string>(type: "varchar(75)", nullable: false),
                    digivolveColor = table.Column<string>(type: "varchar(10)", nullable: false),
                    playCost = table.Column<int>(type: "int", nullable: false),
                    cardPower = table.Column<int>(type: "int", nullable: false),
                    race = table.Column<string>(type: "varchar(25)", nullable: false),
                    attribute = table.Column<string>(type: "varchar(25)", nullable: false),
                    stageLevel = table.Column<string>(type: "varchar(10)", nullable: false),
                    rarity = table.Column<string>(type: "varchar(15)", nullable: false),
                    amountOwned = table.Column<int>(type: "int", nullable: false)
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
                    deckName = table.Column<string>(type: "varchar(25)", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: true)
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
                    packName = table.Column<string>(type: "varchar(25)", nullable: false)
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
