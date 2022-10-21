using Microsoft.EntityFrameworkCore.Migrations;

namespace softSys_1.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "deliv",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "address",
                table: "deliv");
        }
    }
}
