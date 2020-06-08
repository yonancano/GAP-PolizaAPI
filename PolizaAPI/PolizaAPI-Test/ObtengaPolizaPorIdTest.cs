using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using PolizaDA.Modelos;
using PolizaSI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PolizaAPI_Test
{
    public class ObtengaPolizaPorIdTest
    {
        private readonly IPoliza _servicio;

        public ObtengaPolizaPorIdTest() 
        {
            _servicio = Substitute.For<IPoliza>();
        }

        [Fact]
        public void ObtengaPolizaPorId_UnElemento()
        {
            var id = 1;
            _servicio.ObtengaPolizaPorId(id).Returns(Escenarios.ObtengaPolizaPorId(id));
            var poliza = _servicio.ObtengaPolizaPorId(id);

            Assert.Equal(id, poliza.IdPoliza);
        }

        [Fact]
        public void ObtengaPolizaPorId_SinElementos()
        {
            var id = 1;
            _servicio.ObtengaPolizaPorId(id).ReturnsNull();
            var poliza = _servicio.ObtengaPolizaPorId(id);

            Assert.Null(poliza);
        }

    }
}
