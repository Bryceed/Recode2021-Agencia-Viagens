using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WellN_M2_AgenciaViagens.Migrations
{
    public partial class RecodeAgenciaTrabalho2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbBuyList",
                columns: table => new
                {
                    SecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    UID = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qtdd = table.Column<int>(type: "int", nullable: false),
                    plannedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbBuyList", x => x.SecID);
                });

            migrationBuilder.CreateTable(
                name: "dbClients",
                columns: table => new
                {
                    UID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    criadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbClients", x => x.UID);
                    table.ForeignKey(
                        name: "FK_dbClients_dbBuyList_SecID",
                        column: x => x.SecID,
                        principalTable: "dbBuyList",
                        principalColumn: "SecID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbPackages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preco = table.Column<double>(type: "float", nullable: false),
                    precoOriginal = table.Column<double>(type: "float", nullable: true),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pessoasContempladas = table.Column<int>(type: "int", nullable: false),
                    hasOnibus = table.Column<bool>(type: "bit", nullable: false),
                    hasAviao = table.Column<bool>(type: "bit", nullable: false),
                    hasNavio = table.Column<bool>(type: "bit", nullable: false),
                    hasHotel = table.Column<bool>(type: "bit", nullable: false),
                    hasAlimentacao = table.Column<bool>(type: "bit", nullable: false),
                    SecID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbPackages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dbPackages_dbBuyList_SecID",
                        column: x => x.SecID,
                        principalTable: "dbBuyList",
                        principalColumn: "SecID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suporte",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suporte", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Suporte_dbBuyList_SecID",
                        column: x => x.SecID,
                        principalTable: "dbBuyList",
                        principalColumn: "SecID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbClients_SecID",
                table: "dbClients",
                column: "SecID");

            migrationBuilder.CreateIndex(
                name: "IX_dbPackages_SecID",
                table: "dbPackages",
                column: "SecID");

            migrationBuilder.CreateIndex(
                name: "IX_Suporte_SecID",
                table: "Suporte",
                column: "SecID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbClients");

            migrationBuilder.DropTable(
                name: "dbPackages");

            migrationBuilder.DropTable(
                name: "Suporte");

            migrationBuilder.DropTable(
                name: "dbBuyList");
        }
    }
}
