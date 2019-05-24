using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapaAccesoAntecedentes.Migrations
{
    public partial class AntDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "internac_Pacientes",
                columns: table => new
                {
                    Id_internacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_expediente = table.Column<int>(nullable: false),
                    Id_personal = table.Column<int>(nullable: false),
                    Fecha_ingreso = table.Column<DateTime>(nullable: false),
                    Imp_diagnostica = table.Column<string>(nullable: true),
                    Tratamiento = table.Column<string>(nullable: true),
                    internac_pacienteId_internacion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_internac_Pacientes", x => x.Id_internacion);
                    table.ForeignKey(
                        name: "FK_internac_Pacientes_internac_Pacientes_internac_pacienteId_internacion",
                        column: x => x.internac_pacienteId_internacion,
                        principalTable: "internac_Pacientes",
                        principalColumn: "Id_internacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoAntecedentes",
                columns: table => new
                {
                    IdTipoAnt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomTipoAnt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAntecedentes", x => x.IdTipoAnt);
                });

            migrationBuilder.CreateTable(
                name: "EltoAntEvaluars",
                columns: table => new
                {
                    IdEltoAntEvaluar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreEltoEvaluar = table.Column<string>(nullable: true),
                    EstadoEltoEvaluar = table.Column<bool>(nullable: false),
                    Observacion = table.Column<string>(nullable: true),
                    IdInternacion = table.Column<int>(nullable: false),
                    TipoAntecedenteIdTipoAnt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EltoAntEvaluars", x => x.IdEltoAntEvaluar);
                    table.ForeignKey(
                        name: "FK_EltoAntEvaluars_TipoAntecedentes_TipoAntecedenteIdTipoAnt",
                        column: x => x.TipoAntecedenteIdTipoAnt,
                        principalTable: "TipoAntecedentes",
                        principalColumn: "IdTipoAnt",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EltoAntEvaluars_TipoAntecedenteIdTipoAnt",
                table: "EltoAntEvaluars",
                column: "TipoAntecedenteIdTipoAnt");

            migrationBuilder.CreateIndex(
                name: "IX_internac_Pacientes_internac_pacienteId_internacion",
                table: "internac_Pacientes",
                column: "internac_pacienteId_internacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EltoAntEvaluars");

            migrationBuilder.DropTable(
                name: "internac_Pacientes");

            migrationBuilder.DropTable(
                name: "TipoAntecedentes");
        }
    }
}
