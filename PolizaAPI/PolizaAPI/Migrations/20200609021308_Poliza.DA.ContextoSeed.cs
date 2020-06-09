using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poliza.Api.Migrations
{
    public partial class PolizaDAContextoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 1,
                column: "InicioVigencia",
                value: new DateTime(2020, 6, 8, 20, 13, 7, 699, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 2,
                column: "InicioVigencia",
                value: new DateTime(2020, 6, 8, 20, 13, 7, 700, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 3,
                column: "InicioVigencia",
                value: new DateTime(2020, 6, 8, 20, 13, 7, 700, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 4,
                column: "InicioVigencia",
                value: new DateTime(2020, 6, 8, 20, 13, 7, 700, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 5,
                column: "InicioVigencia",
                value: new DateTime(2020, 6, 8, 20, 13, 7, 700, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 6,
                column: "InicioVigencia",
                value: new DateTime(2020, 6, 8, 20, 13, 7, 700, DateTimeKind.Local).AddTicks(6465));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 1,
                column: "InicioVigencia",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 2,
                column: "InicioVigencia",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 3,
                column: "InicioVigencia",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 4,
                column: "InicioVigencia",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 5,
                column: "InicioVigencia",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Poliza",
                keyColumn: "IdPoliza",
                keyValue: 6,
                column: "InicioVigencia",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
