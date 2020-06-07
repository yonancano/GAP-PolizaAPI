using Microsoft.EntityFrameworkCore.Migrations;

namespace PolizaAPI.Migrations
{
    public partial class PolizaAPIDARepositorioSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "IdPoliza", "Descripcion", "IdCliente", "Nombre", "PeriodoCobertura", "Precio", "TipoCubrimiento", "TipoRiesgo" },
                values: new object[] { 1, "Permite la cobertura del cliente: Yonan Cano en caso relacionado con un Terremoto", 1, "Poliza 001", (byte)10, 900000m, (byte)1, (byte)1 });

            migrationBuilder.InsertData(
                table: "Polizas",
                columns: new[] { "IdPoliza", "Descripcion", "IdCliente", "Nombre", "PeriodoCobertura", "Precio", "TipoCubrimiento", "TipoRiesgo" },
                values: new object[] { 2, "Permite la cobertura del cliente: Lorena Muñoz en caso relacionado con un Incendio", 2, "Poliza 002", (byte)10, 1500000m, (byte)2, (byte)2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Polizas",
                keyColumn: "IdPoliza",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Polizas",
                keyColumn: "IdPoliza",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "IdCliente",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "IdCliente",
                keyValue: 2);
        }
    }
}
