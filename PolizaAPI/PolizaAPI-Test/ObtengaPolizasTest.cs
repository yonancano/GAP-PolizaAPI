using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using PolizaDA.Modelos;
using PolizaSI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PolizaAPI_Test
{
    public class ObtengaPolizasTest
    {
        private readonly IPoliza _servicio;

        public ObtengaPolizasTest() 
        {
            _servicio = Substitute.For<IPoliza>();
        }

        [Fact]
        public void ObtengaPolizas_UnElemento()
        {
            _servicio.ObtengaPolizas().Returns(Escenarios.Obtenga1Poliza());
            var polizas = _servicio.ObtengaPolizas();

            Assert.Single(polizas);
        }

        [Fact]
        public void ObtengaPolizas_TresElementos()
        {
            _servicio.ObtengaPolizas().Returns(Escenarios.Obtenga3Polizas());
            var polizas = _servicio.ObtengaPolizas();

            Assert.Equal(3, polizas.Count());
        }

        [Fact]
        public void ObtengaPolizas_SinElementos()
        {
            _servicio.ObtengaPolizas().Returns(new List<Poliza>());
            var polizas = _servicio.ObtengaPolizas();

            Assert.False(polizas.Any());
        }

    }
}
