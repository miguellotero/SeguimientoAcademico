using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguimientoAcademico.App.Persistencia.Migrations
{
    public partial class Estudiantil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MateriaAsignada",
                table: "Maestros",
                newName: "TarjetaProfesional");

            migrationBuilder.AddColumn<int>(
                name: "EstudianteId",
                table: "Maestros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamiliarDesignadoId",
                table: "Estudiantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitud",
                table: "Estudiantes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitud",
                table: "Estudiantes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actividad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avance = table.Column<int>(type: "int", nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actividad_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materia_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recomendacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sugerencia = table.Column<int>(type: "int", nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recomendacion_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maestros_EstudianteId",
                table: "Maestros",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_FamiliarDesignadoId",
                table: "Estudiantes",
                column: "FamiliarDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Actividad_EstudianteId",
                table: "Actividad",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_EstudianteId",
                table: "Materia",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendacion_EstudianteId",
                table: "Recomendacion",
                column: "EstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_FamiliarDesignados_FamiliarDesignadoId",
                table: "Estudiantes",
                column: "FamiliarDesignadoId",
                principalTable: "FamiliarDesignados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maestros_Estudiantes_EstudianteId",
                table: "Maestros",
                column: "EstudianteId",
                principalTable: "Estudiantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_FamiliarDesignados_FamiliarDesignadoId",
                table: "Estudiantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Maestros_Estudiantes_EstudianteId",
                table: "Maestros");

            migrationBuilder.DropTable(
                name: "Actividad");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Recomendacion");

            migrationBuilder.DropIndex(
                name: "IX_Maestros_EstudianteId",
                table: "Maestros");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_FamiliarDesignadoId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "EstudianteId",
                table: "Maestros");

            migrationBuilder.DropColumn(
                name: "FamiliarDesignadoId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "TarjetaProfesional",
                table: "Maestros",
                newName: "MateriaAsignada");
        }
    }
}
