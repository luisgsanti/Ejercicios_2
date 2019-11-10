using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica_1.Migrations
{
    public partial class ImpuestosDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Impuestos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroLiquidacion = table.Column<int>(nullable: false),
                    Grados = table.Column<int>(nullable: false),
                    ValorImpuesto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuestos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Impuestos");
        }
    }
}
