using Microsoft.EntityFrameworkCore.Migrations;

namespace softSys_1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deliv",
                columns: table => new
                {
                    delivsID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DriverName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliv", x => x.delivsID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoresID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StoreName = table.Column<string>(maxLength: 60, nullable: false),
                    food = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoresID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    usersID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.usersID);
                });

            migrationBuilder.CreateTable(
                name: "DelivStore",
                columns: table => new
                {
                    StoresID = table.Column<int>(nullable: false),
                    delivsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelivStore", x => new { x.StoresID, x.delivsID });
                    table.ForeignKey(
                        name: "FK_DelivStore_Stores_StoresID",
                        column: x => x.StoresID,
                        principalTable: "Stores",
                        principalColumn: "StoresID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelivStore_deliv_delivsID",
                        column: x => x.delivsID,
                        principalTable: "deliv",
                        principalColumn: "delivsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DelivStore_delivsID",
                table: "DelivStore",
                column: "delivsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DelivStore");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "deliv");
        }
    }
}
