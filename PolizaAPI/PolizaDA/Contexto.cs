using Microsoft.EntityFrameworkCore;
using PolizaDA.Enumerados;
using PolizaDA.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaDA
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options) { }

        //migrations se hicieron en la consola PM
        //seeding 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    IdCliente = 1,
                    Nombre = "Yonan Cano",
                    Email = "yonan.cano@gmail.com"

                }, new Cliente
                {
                    IdCliente = 2,
                    Nombre = "Lorena Muñozñoz",
                    Email = "lorena.munoz@gmail.com"

                });

            modelBuilder.Entity<Poliza>().HasData(
                new Poliza
                {
                    IdPoliza = 1,
                    Nombre = "Poliza 001",
                    Descripcion = "Permite la cobertura del cliente: Yonan Cano en caso relacionado con un Terremoto",
                    Precio = 900000,
                    TipoCubrimiento = (byte)TiposCubrimiento.Terremoto,
                    PorcentajeCobertura = 15,
                    TipoRiesgo = (byte)TiposRiesgo.Bajo,
                    PeriodoCobertura = 10,
                    IdCliente = 1

                }, new Poliza
                {
                    IdPoliza = 2,
                    Nombre = "Poliza 002",
                    Descripcion = "Permite la cobertura del cliente: Lorena Muñoz en caso relacionado con un Incendio",
                    Precio = 1500000,
                    TipoCubrimiento = (byte)TiposCubrimiento.Incendio,
                    PorcentajeCobertura = 82,
                    TipoRiesgo = (byte)TiposRiesgo.Medio,
                    PeriodoCobertura = 10,
                    IdCliente = 2
                }, new Poliza
                {
                    IdPoliza = 3,
                    Nombre = "Poliza 003",
                    Descripcion = "Permite la cobertura del cliente: John Doe en caso relacionado con un Robo",
                    Precio = 3250000,
                    TipoCubrimiento = (byte)TiposCubrimiento.Robo,
                    PorcentajeCobertura = 50,
                    TipoRiesgo = (byte)TiposRiesgo.Alto,
                    PeriodoCobertura = 6,
                    IdCliente = 2
                });

        }

        public DbSet<Poliza> Polizas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
