using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lybrary.Migrations
{
    public partial class RecoverMagazine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Magazines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Magazines");
        }
    }
}
