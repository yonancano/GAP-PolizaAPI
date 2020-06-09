using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poliza.Api.Migrations
{
    public partial class PolizaEFContextoContextoApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Poliza",
                columns: table => new
                {
                    IdPoliza = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 60, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: false),
                    TipoCubrimiento = table.Column<byte>(nullable: false),
                    PorcentajeCobertura = table.Column<byte>(nullable: false),
                    InicioVigencia = table.Column<DateTime>(nullable: false),
                    PeriodoCobertura = table.Column<byte>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    TipoRiesgo = table.Column<byte>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliza", x => x.IdPoliza);
                    table.ForeignKey(
                        name: "FK_Poliza_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "IdCliente", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "yonan.cano@gmail.com", "Yonan Cano" },
                    { 2, "lorena.munoz@gmail.com", "Lorena Muñoz" },
                    { 3, "daniela.duran@gmail.com", "Daniela Duran" },
                    { 4, "ernesto.enado@gmail.com", "Ernesto Enado" },
                    { 5, "fiorela.flores@gmail.com", "Fiorela Flores" },
                    { 6, "gabriel.guzman@gmail.com", "Gabriel Guzman" }
                });

            migrationBuilder.InsertData(
                table: "Poliza",
                columns: new[] { "IdPoliza", "Descripcion", "IdCliente", "InicioVigencia", "Nombre", "PeriodoCobertura", "PorcentajeCobertura", "Precio", "TipoCubrimiento", "TipoRiesgo" },
                values: new object[,]
                {
                    { 1, "Permite la cobertura relacionado con un Terremoto", 1, new DateTime(2020, 6, 9, 0, 37, 13, 191, DateTimeKind.Local).AddTicks(3349), "Poliza 001", (byte)10, (byte)15, 900000m, (byte)1, (byte)1 },
                    { 2, "Permite la cobertura relacionado con un Incendio", 1, new DateTime(2020, 6, 9, 0, 37, 13, 192, DateTimeKind.Local).AddTicks(4574), "Poliza 002", (byte)10, (byte)82, 1500000m, (byte)2, (byte)2 },
                    { 3, "Permite la cobertura relacionado con un Robo", 2, new DateTime(2020, 6, 9, 0, 37, 13, 192, DateTimeKind.Local).AddTicks(4634), "Poliza 003", (byte)6, (byte)50, 3250000m, (byte)3, (byte)4 },
                    { 4, "Permite la cobertura relacionado con un Robo", 2, new DateTime(2020, 6, 9, 0, 37, 13, 192, DateTimeKind.Local).AddTicks(4637), "Poliza 003", (byte)6, (byte)50, 3250000m, (byte)3, (byte)4 },
                    { 5, "Permite la cobertura relacionado con una Pérdida", 3, new DateTime(2020, 6, 9, 0, 37, 13, 192, DateTimeKind.Local).AddTicks(4639), "Poliza 004", (byte)4, (byte)56, 12000000m, (byte)4, (byte)3 },
                    { 6, "Permite la cobertura relacionado con un Robo", 6, new DateTime(2020, 6, 9, 0, 37, 13, 192, DateTimeKind.Local).AddTicks(4641), "Poliza 005", (byte)10, (byte)66, 1350000m, (byte)3, (byte)3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poliza_IdCliente",
                table: "Poliza",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poliza");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
