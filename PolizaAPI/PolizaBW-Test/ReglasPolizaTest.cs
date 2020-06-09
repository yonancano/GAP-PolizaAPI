using Poliza.BW;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.BW_Test
{
    public class ReglasPolizaTest
    {

        private ReglasPoliza _reglas = new ReglasPoliza();    

        [Fact]
        public void Validar_RiesgoBajo()
        {

            var resp = _reglas.Validar(EscenarioPolizas.Single(x => x.TipoRiesgo == (byte)Model.Enumerados.TiposRiesgo.Bajo));
            
            Assert.True(resp);
        }

        [Fact]
        public void Validar_RiesgoAlto_PorcentajeBajo()
        {

            var resp = _reglas.Validar(EscenarioPolizas.Single(x => x.TipoRiesgo == (byte)Model.Enumerados.TiposRiesgo.Alto && x.PorcentajeCobertura < 50));
            
            Assert.True(resp);
        }

        [Fact]
        public void Validar_RiesgoAlto_PorcentajeLimite()
        {

            var resp = _reglas.Validar(EscenarioPolizas.Single(x => x.TipoRiesgo == (byte)Model.Enumerados.TiposRiesgo.Alto && x.PorcentajeCobertura == 50)); 
            
            Assert.True(resp);
        }

        [Fact]
        public void Validar_RiesgoAlto_PorcentajeAlto()
        {

            Assert.Throws<Exception>(() => _reglas.Validar(EscenarioPolizas.Single(x => x.TipoRiesgo == (byte)Model.Enumerados.TiposRiesgo.Alto && x.PorcentajeCobertura > 50)));
        }





        private List<Model.Poliza> EscenarioPolizas = new List<Model.Poliza>
        {
            new Model.Poliza
            {
                IdPoliza = 1,
                Nombre = "Poliza 001",
                Descripcion = "Poliza de reglas para pruebas.",
                Precio = 1100000,
                InicioVigencia = DateTime.Now,
                TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Incendio,
                PorcentajeCobertura = 55,
                TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Bajo,
                PeriodoCobertura = 10,
                IdCliente = 1
            },
            new Model.Poliza
            {
                IdPoliza = 2,
                Nombre = "Poliza 002",
                Descripcion = "Poliza de reglas para pruebas.",
                Precio = 22450000,
                InicioVigencia = DateTime.Now,
                TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Robo,
                PorcentajeCobertura = 20,
                TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Alto,
                PeriodoCobertura = 10,
                IdCliente = 1
            },
            new Model.Poliza
            {
                IdPoliza = 3,
                Nombre = "Poliza 003",
                Descripcion = "Poliza de reglas para pruebas.",
                Precio = 700000,
                InicioVigencia = DateTime.Now,
                TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Perdida,
                PorcentajeCobertura = 50,
                TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Alto,
                PeriodoCobertura = 10,
                IdCliente = 1
            },
            new Model.Poliza
            {
                IdPoliza = 4,
                Nombre = "Poliza 004",
                Descripcion = "Poliza de reglas para pruebas.",
                Precio = 12500000,
                InicioVigencia = DateTime.Now,
                TipoCubrimiento = (byte)Poliza.Model.Enumerados.TiposCubrimiento.Robo,
                PorcentajeCobertura = 72,
                TipoRiesgo = (byte)Poliza.Model.Enumerados.TiposRiesgo.Alto,
                PeriodoCobertura = 10,
                IdCliente = 1
            }
        };
    }
}
