using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AnaliseAcoes.Persistence.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Atividade = table.Column<string>(type: "TEXT", nullable: true),
                    NomePregao = table.Column<string>(type: "TEXT", nullable: true),
                    Sigla = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadosFundamentalistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AtivoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cotacao = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataUltimaCotacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUltimoBalancoProcessado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MaiorCotacaoUltimoAno = table.Column<decimal>(type: "TEXT", nullable: false),
                    MenorCotacaoUltimoAno = table.Column<decimal>(type: "TEXT", nullable: false),
                    QuantidadeAcoesEmNegociacao = table.Column<long>(type: "INTEGER", nullable: false),
                    Setor = table.Column<string>(type: "TEXT", nullable: true),
                    SubSetor = table.Column<string>(type: "TEXT", nullable: true),
                    TipoPapel = table.Column<string>(type: "TEXT", nullable: true),
                    ValorFirma = table.Column<double>(type: "REAL", nullable: false),
                    ValorMercado = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosFundamentalistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadosFundamentalistas_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosFundamentalistas_AtivoId",
                table: "DadosFundamentalistas",
                column: "AtivoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosFundamentalistas");

            migrationBuilder.DropTable(
                name: "Ativos");
        }
    }
}
