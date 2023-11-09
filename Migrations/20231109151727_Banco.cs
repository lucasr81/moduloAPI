using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moduloAPI.Migrations
{
    /// <inheritdoc />
    public partial class Banco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    IdCurso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instrutor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.IdCurso);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    IdModulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCurso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.IdModulo);
                    table.ForeignKey(
                        name: "FK_Modulo_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "IdCurso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    IdAula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    IdModulo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.IdAula);
                    table.ForeignKey(
                        name: "FK_Aulas_Modulo_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulo",
                        principalColumn: "IdModulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionarioManager",
                columns: table => new
                {
                    IdQuestionManager = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiberarQuestao = table.Column<bool>(type: "bit", nullable: false),
                    IdModulo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionarioManager", x => x.IdQuestionManager);
                    table.ForeignKey(
                        name: "FK_QuestionarioManager_Modulo_IdModulo",
                        column: x => x.IdModulo,
                        principalTable: "Modulo",
                        principalColumn: "IdModulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionario",
                columns: table => new
                {
                    IdQuestionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UploadImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enunciado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcaoUm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcaoDois = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcaoTres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcaoQuatro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpcaoCinco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespostaCorreta = table.Column<int>(type: "int", nullable: false),
                    IdQuestionManager = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionario", x => x.IdQuestionario);
                    table.ForeignKey(
                        name: "FK_Questionario_QuestionarioManager_IdQuestionManager",
                        column: x => x.IdQuestionManager,
                        principalTable: "QuestionarioManager",
                        principalColumn: "IdQuestionManager",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_IdModulo",
                table: "Aulas",
                column: "IdModulo");

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_IdCurso",
                table: "Modulo",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Questionario_IdQuestionManager",
                table: "Questionario",
                column: "IdQuestionManager");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionarioManager_IdModulo",
                table: "QuestionarioManager",
                column: "IdModulo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Questionario");

            migrationBuilder.DropTable(
                name: "QuestionarioManager");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
