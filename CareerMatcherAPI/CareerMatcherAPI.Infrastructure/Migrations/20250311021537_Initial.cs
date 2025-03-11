using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerMatcherAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<string>(type: "text", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Concursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CodConcurso = table.Column<int>(type: "integer", nullable: false),
                    Orgao = table.Column<string>(type: "text", nullable: false),
                    Edital = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profissoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeProfissao = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DateDeleted = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoConcurso",
                columns: table => new
                {
                    CandidatosConcursoId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcursosCandidatoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoConcurso", x => new { x.CandidatosConcursoId, x.ConcursosCandidatoId });
                    table.ForeignKey(
                        name: "FK_CandidatoConcurso_Candidatos_CandidatosConcursoId",
                        column: x => x.CandidatosConcursoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoConcurso_Concursos_ConcursosCandidatoId",
                        column: x => x.ConcursosCandidatoId,
                        principalTable: "Concursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoProfissao",
                columns: table => new
                {
                    ProfissaoCandidatosId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfissoesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoProfissao", x => new { x.ProfissaoCandidatosId, x.ProfissoesId });
                    table.ForeignKey(
                        name: "FK_CandidatoProfissao_Candidatos_ProfissaoCandidatosId",
                        column: x => x.ProfissaoCandidatosId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoProfissao_Profissoes_ProfissoesId",
                        column: x => x.ProfissoesId,
                        principalTable: "Profissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConcursoProfissao",
                columns: table => new
                {
                    ConcursoVagasId = table.Column<Guid>(type: "uuid", nullable: false),
                    VagaConcursosId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcursoProfissao", x => new { x.ConcursoVagasId, x.VagaConcursosId });
                    table.ForeignKey(
                        name: "FK_ConcursoProfissao_Concursos_VagaConcursosId",
                        column: x => x.VagaConcursosId,
                        principalTable: "Concursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConcursoProfissao_Profissoes_ConcursoVagasId",
                        column: x => x.ConcursoVagasId,
                        principalTable: "Profissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoConcurso_ConcursosCandidatoId",
                table: "CandidatoConcurso",
                column: "ConcursosCandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoProfissao_ProfissoesId",
                table: "CandidatoProfissao",
                column: "ProfissoesId");

            migrationBuilder.CreateIndex(
                name: "IX_ConcursoProfissao_VagaConcursosId",
                table: "ConcursoProfissao",
                column: "VagaConcursosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoConcurso");

            migrationBuilder.DropTable(
                name: "CandidatoProfissao");

            migrationBuilder.DropTable(
                name: "ConcursoProfissao");

            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropTable(
                name: "Concursos");

            migrationBuilder.DropTable(
                name: "Profissoes");
        }
    }
}
