using Microsoft.EntityFrameworkCore.Migrations;

namespace Digital_Pocket_Monster.Migrations
{
    public partial class RenamedDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Cards",
                newName: "cardDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cardDescription",
                table: "Cards",
                newName: "description");
        }
    }
}
