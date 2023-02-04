using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPumpMVC.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Typ",
                table: "Pump",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Typ",
                table: "Pump");
        }
    }
}
