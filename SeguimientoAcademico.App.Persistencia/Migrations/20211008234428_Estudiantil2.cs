using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguimientoAcademico.App.Persistencia.Migrations
{
    public partial class Estudiantil2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividad_Estudiantes_EstudianteId",
                table: "Actividad");

            migrationBuilder.DropForeignKey(
                name: "FK_Materia_Estudiantes_EstudianteId",
                table: "Materia");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendacion_Estudiantes_EstudianteId",
                table: "Recomendacion");

            migrationBuilder.DropTable(
                name: "Maestros");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "FamiliarDesignados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomendacion",
                table: "Recomendacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materia",
                table: "Materia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actividad",
                table: "Actividad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutores",
                table: "Tutores");

            migrationBuilder.RenameTable(
                name: "Recomendacion",
                newName: "Recomendaciones");

            migrationBuilder.RenameTable(
                name: "Materia",
                newName: "Materias");

            migrationBuilder.RenameTable(
                name: "Actividad",
                newName: "Actividades");

            migrationBuilder.RenameTable(
                name: "Tutores",
                newName: "Personas");

            migrationBuilder.RenameIndex(
                name: "IX_Recomendacion_EstudianteId",
                table: "Recomendaciones",
                newName: "IX_Recomendaciones_EstudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Materia_EstudianteId",
                table: "Materias",
                newName: "IX_Materias_EstudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Actividad_EstudianteId",
                table: "Actividades",
                newName: "IX_Actividades_EstudianteId");

            migrationBuilder.AddColumn<string>(
                name: "DireccionGeorreferenciada",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstudianteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamiliarDesignadoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grado",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitud",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitud",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MateriasInscritas",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parentesco",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TarjetaProfesional",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomendaciones",
                table: "Recomendaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materias",
                table: "Materias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actividades",
                table: "Actividades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EstudianteId",
                table: "Personas",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividades_Personas_EstudianteId",
                table: "Actividades",
                column: "EstudianteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Personas_EstudianteId",
                table: "Materias",
                column: "EstudianteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_EstudianteId",
                table: "Personas",
                column: "EstudianteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendaciones_Personas_EstudianteId",
                table: "Recomendaciones",
                column: "EstudianteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actividades_Personas_EstudianteId",
                table: "Actividades");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Personas_EstudianteId",
                table: "Materias");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_EstudianteId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Recomendaciones_Personas_EstudianteId",
                table: "Recomendaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recomendaciones",
                table: "Recomendaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materias",
                table: "Materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actividades",
                table: "Actividades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EstudianteId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DireccionGeorreferenciada",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EstudianteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Grado",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "MateriasInscritas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Parentesco",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Recomendaciones",
                newName: "Recomendacion");

            migrationBuilder.RenameTable(
                name: "Materias",
                newName: "Materia");

            migrationBuilder.RenameTable(
                name: "Actividades",
                newName: "Actividad");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Tutores");

            migrationBuilder.RenameIndex(
                name: "IX_Recomendaciones_EstudianteId",
                table: "Recomendacion",
                newName: "IX_Recomendacion_EstudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_EstudianteId",
                table: "Materia",
                newName: "IX_Materia_EstudianteId");

            migrationBuilder.RenameIndex(
                name: "IX_Actividades_EstudianteId",
                table: "Actividad",
                newName: "IX_Actividad_EstudianteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recomendacion",
                table: "Recomendacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materia",
                table: "Materia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actividad",
                table: "Actividad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutores",
                table: "Tutores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FamiliarDesignados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamiliarDesignados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionGeorreferenciada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamiliarDesignadoId = table.Column<int>(type: "int", nullable: true),
                    Grado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MateriasInscritas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estudiantes_FamiliarDesignados_FamiliarDesignadoId",
                        column: x => x.FamiliarDesignadoId,
                        principalTable: "FamiliarDesignados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maestros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maestros_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_FamiliarDesignadoId",
                table: "Estudiantes",
                column: "FamiliarDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Maestros_EstudianteId",
                table: "Maestros",
                column: "EstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actividad_Estudiantes_EstudianteId",
                table: "Actividad",
                column: "EstudianteId",
                principalTable: "Estudiantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materia_Estudiantes_EstudianteId",
                table: "Materia",
                column: "EstudianteId",
                principalTable: "Estudiantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recomendacion_Estudiantes_EstudianteId",
                table: "Recomendacion",
                column: "EstudianteId",
                principalTable: "Estudiantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
