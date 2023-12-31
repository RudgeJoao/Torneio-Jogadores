using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorneioApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Age = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Titles = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Games = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Goals = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    GoalsPerGame = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    Picture = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
