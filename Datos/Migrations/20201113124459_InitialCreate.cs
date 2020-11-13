using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    CodPago = table.Column<string>(type: "varchar(15)", nullable: false),
                    CodPersona = table.Column<string>(type: "varchar(15)", nullable: true),
                    TipoPago = table.Column<string>(type: "varchar(30)", nullable: true),
                    FechaPago = table.Column<DateTime>(type: "date", nullable: false),
                    ValorPago = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    ValorIvaPago = table.Column<decimal>(type: "decimal(6,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.CodPago);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "varchar(15)", nullable: false),
                    TipoDocumento = table.Column<string>(type: "varchar(10)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(20)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(20)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(15)", nullable: true),
                    Pais = table.Column<string>(type: "varchar(20)", nullable: true),
                    Departamento = table.Column<string>(type: "varchar(20)", nullable: true),
                    Ciudad = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
