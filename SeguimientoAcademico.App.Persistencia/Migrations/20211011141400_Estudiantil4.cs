using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguimientoAcademico.App.Persistencia.Migrations
{
    public partial class Estudiantil4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DireccionGeorreferenciada",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Grado",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "MateriasInscritas",
                table: "Personas",
                newName: "Direccion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Personas",
                newName: "MateriasInscritas");

            migrationBuilder.AddColumn<string>(
                name: "DireccionGeorreferenciada",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grado",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
