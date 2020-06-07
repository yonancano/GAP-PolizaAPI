using Microsoft.EntityFrameworkCore;
using PolizaAPI.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolizaAPI.DA
{
    public class Repositorio : DbContext
    {
        public Repositorio(DbContextOptions options) : base(options) { }

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
                    TipoRiesgo = (byte)TiposRiesgo.Medio,
                    PeriodoCobertura = 10,
                    IdCliente = 2
                });

        }

        public DbSet<Poliza> Polizas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
