using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poliza.API_Test
{
    internal static class Escenarios
    {
        private static List<Poliza.Model.Poliza> Polizas = new List<Poliza.Model.Poliza>
        {
            new Poliza.Model.Poliza
            {
                IdPoliza = 1,
                Nombre = "Poliza Test 1",
                Descripcion = "Descripcion de la prueba",
                Precio = 1000000,
                TipoCubrimiento = (byte) Poliza.Model.Enumerados.TiposCubrimiento.Terremoto,
                PorcentajeCobertura = 10,
                TipoRiesgo = (byte) Poliza.Model.Enumerados.TiposRiesgo.Bajo,
                PeriodoCobertura = 10,
                IdCliente = 1
            },
            new Poliza.Model.Poliza
            {
                IdPoliza = 2,
                Nombre = "Poliza Test 2",
                Descripcion = "Descripcion de la prueba",
                Precio = 2000000,
                TipoCubrimiento = (byte) Poliza.Model.Enumerados.TiposCubrimiento.Terremoto,
                PorcentajeCobertura = 20,
                TipoRiesgo = (byte) Poliza.Model.Enumerados.TiposRiesgo.Medio,
                PeriodoCobertura = 20,
                IdCliente = 2
            },
            new Poliza.Model.Poliza
            {
                IdPoliza = 3,
                Nombre = "Poliza Test 3",
                Descripcion = "Descripcion de la prueba",
                Precio = 3000000,
                TipoCubrimiento = (byte) Poliza.Model.Enumerados.TiposCubrimiento.Incendio,
                PorcentajeCobertura = 30,
                TipoRiesgo = (byte) Poliza.Model.Enumerados.TiposRiesgo.Alto,
                PeriodoCobertura = 30,
                IdCliente = 2
            },
        };

        internal static IEnumerable<Poliza.Model.Poliza> Obtenga1Poliza() 
        {
            return Polizas.Where(x => x.IdCliente == 1);
        }

        internal static List<Poliza.Model.Poliza> Obtenga3Polizas()
        {
            return Polizas;
        }

        internal static Poliza.Model.Poliza ObtengaPolizaPorId(int id)
        {
            return Polizas.Find(x => x.IdCliente == id);
        }

    }
}
