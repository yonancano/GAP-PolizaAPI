using Microsoft.EntityFrameworkCore.Migrations;

namespace PolizaAPI.Migrations
{
    public partial class PolizaDAContexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    IdPoliza = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    TipoCubrimiento = table.Column<byte>(nullable: false),
                    PorcentajeCobertura = table.Column<byte>(nullable: false),
                    PeriodoCobertura = table.Column<byte>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    TipoRiesgo = table.Column<byte>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizas", x => x.IdPoliza);
                    table.ForeignKey(
                        name: "FK_Polizas_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "IdCliente", "Email", "Nombre" },
                values: new object[] { 1, "yonan.cano@gmail.com", "Yonan Cano" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "IdCliente", "Email", "Nombre" },
                values: new object[] { 2, "lorena.munoz@gmail.com", "Lorena Muñozñoz" });

            migrationBuilder.InsertData(
                table: "Polizas",
                columns: new[] { "IdPoliza", "Descripcion", "IdCliente", "Nombre", "PeriodoCobertura", "PorcentajeCobertura", "Precio", "TipoCubrimiento", "TipoRiesgo" },
                values: new object[] { 1, "Permite la cobertura del cliente: Yonan Cano en caso relacionado con un Terremoto", 1, "Poliza 001", (byte)10, (byte)15, 900000m, (byte)1, (byte)1 });

            migrationBuilder.InsertData(
                table: "Polizas",
                columns: new[] { "IdPoliza", "Descripcion", "IdCliente", "Nombre", "PeriodoCobertura", "PorcentajeCobertura", "Precio", "TipoCubrimiento", "TipoRiesgo" },
                values: new object[] { 2, "Permite la cobertura del cliente: Lorena Muñoz en caso relacionado con un Incendio", 2, "Poliza 002", (byte)10, (byte)82, 1500000m, (byte)2, (byte)2 });

            migrationBuilder.InsertData(
                table: "Polizas",
                columns: new[] { "IdPoliza", "Descripcion", "IdCliente", "Nombre", "PeriodoCobertura", "PorcentajeCobertura", "Precio", "TipoCubrimiento", "TipoRiesgo" },
                values: new object[] { 3, "Permite la cobertura del cliente: John Doe en caso relacionado con un Robo", 2, "Poliza 003", (byte)6, (byte)50, 3250000m, (byte)3, (byte)4 });

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_IdCliente",
                table: "Polizas",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
