using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tap.School.Api.Migrations
{
    public partial class grade_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                  CourseName = table.Column<string>(type: "TEXT", nullable: true),
                    grade = table.Column<string>(type: "Integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Grades");

        }
    }
}
