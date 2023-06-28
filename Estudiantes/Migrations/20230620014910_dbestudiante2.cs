using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estudiantes.Migrations
{
    public partial class dbestudiante2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstudianteId",
                table: "Student",
                newName: "EstudianteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstudianteID",
                table: "Student",
                newName: "EstudianteId");
        }
    }
}
