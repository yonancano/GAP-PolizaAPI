﻿using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poliza.API_Test
{
    internal static class Escenarios
    {
        public static List<Model.Poliza> EscenarioPolizas = new List<Model.Poliza>
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
                PorcentajeCobertura = 80,
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

        internal static IEnumerable<Poliza.Model.Poliza> Obtenga1Poliza() 
        {
            return EscenarioPolizas.Take(1);
        }

        internal static IEnumerable<Poliza.Model.Poliza> Obtenga3Polizas()
        {
            return EscenarioPolizas.Take(3);
        }

        internal static Poliza.Model.Poliza ObtengaPolizaPorId(int id)
        {
            return EscenarioPolizas.Find(x => x.IdCliente == id);
        }

        internal static Poliza.Model.Poliza ObtengaRiesgoAlto_PorcentajeAlto()
        {
            return EscenarioPolizas.Single(x => x.TipoRiesgo == (byte)Model.Enumerados.TiposRiesgo.Alto && x.PorcentajeCobertura == 50);
        }

    }
}
