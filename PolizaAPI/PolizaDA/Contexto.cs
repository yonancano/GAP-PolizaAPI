using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poliza.DA
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options) { }

        //migrations se hicieron en la consola PM
        //seeding 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Cliente>().HasData(
                new Model.Cliente
                {
                    IdCliente = 1,
                    Nombre = "Yonan Cano",
                    Email = "yonan.cano@gmail.com"

                }, new Model.Cliente
                {
                    IdCliente = 2,
                    Nombre = "Lorena Muñoz",
                    Email = "lorena.munoz@gmail.com"

                }, new Model.Cliente
                {
                    IdCliente = 3,
                    Nombre = "Daniela Duran",
                    Email = "daniela.duran@gmail.com"

                }, new Model.Cliente
                {
                    IdCliente = 4,
                    Nombre = "Ernesto Enado",
                    Email = "ernesto.enado@gmail.com"

                }, new Model.Cliente
                {
                    IdCliente = 5,
                    Nombre = "Fiorela Flores",
                    Email = "fiorela.flores@gmail.com"

                }, new Model.Cliente
                {
                    IdCliente = 6,
                    Nombre = "Gabriel Guzman",
                    Email = "gabriel.guzman@gmail.com"

                });

            modelBuilder.Entity<Model.Poliza>().HasData(
                new Model.Poliza
                {
                    IdPoliza = 1,
                    Nombre = "Poliza 001",
                    Descripcion = "Permite la cobertura relacionado con un Terremoto",
                    Precio = 900000,
                    InicioVigencia = DateTime.Now,
                    TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Terremoto,
                    PorcentajeCobertura = 15,
                    TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Bajo,
                    PeriodoCobertura = 10,
                    IdCliente = 1

                }, new Model.Poliza
                {
                    IdPoliza = 2,
                    Nombre = "Poliza 002",
                    Descripcion = "Permite la cobertura relacionado con un Incendio",
                    Precio = 1500000,
                    InicioVigencia = DateTime.Now,
                    TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Incendio,
                    PorcentajeCobertura = 82,
                    TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Medio,
                    PeriodoCobertura = 10,
                    IdCliente = 1
                }, new Model.Poliza
                {
                    IdPoliza = 3,
                    Nombre = "Poliza 003",
                    Descripcion = "Permite la cobertura relacionado con un Robo",
                    Precio = 3250000,
                    InicioVigencia = DateTime.Now,
                    TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Robo,
                    PorcentajeCobertura = 50,
                    TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Alto,
                    PeriodoCobertura = 6,
                    IdCliente = 2
                }, new Model.Poliza
                {
                    IdPoliza = 4,
                    Nombre = "Poliza 003",
                    Descripcion = "Permite la cobertura relacionado con un Robo",
                    Precio = 3250000,
                    InicioVigencia = DateTime.Now,
                    TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Robo,
                    PorcentajeCobertura = 50,
                    TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Alto,
                    PeriodoCobertura = 6,
                    IdCliente = 2
                }, new Model.Poliza
                {
                    IdPoliza = 5,
                    Nombre = "Poliza 004",
                    Descripcion = "Permite la cobertura relacionado con una Pérdida",
                    Precio = 12000000,
                    InicioVigencia = DateTime.Now,
                    TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Perdida,
                    PorcentajeCobertura = 56,
                    TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.MedioAlto,
                    PeriodoCobertura = 4,
                    IdCliente = 3
                }, new Model.Poliza
                {
                    IdPoliza = 6,
                    Nombre = "Poliza 005",
                    Descripcion = "Permite la cobertura relacionado con un Robo",
                    Precio = 1350000,
                    InicioVigencia = DateTime.Now,
                    TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Robo,
                    PorcentajeCobertura = 66,
                    TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.MedioAlto,
                    PeriodoCobertura = 10,
                    IdCliente = 6
                });

        }

        public DbSet<Model.Poliza> Polizas { get; set; }
        public DbSet<Model.Cliente> Clientes { get; set; }
    }
}
