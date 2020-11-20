using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreMvc.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    TarihG = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    TarihK = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Gumruk = table.Column<string>(type: "nvarchar(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
