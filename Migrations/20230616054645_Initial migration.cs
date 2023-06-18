using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculatorLab7.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nr1 = table.Column<double>(type: "float", nullable: false),
                    Nr2 = table.Column<double>(type: "float", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Results = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
