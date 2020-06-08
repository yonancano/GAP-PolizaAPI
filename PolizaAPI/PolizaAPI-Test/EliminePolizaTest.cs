using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json.Serialization;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
using PolizaDA.Modelos;
using PolizaSI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PolizaAPI_Test
{
    public class EliminePolizaTest
    {
        private readonly IPoliza _servicio;

        public EliminePolizaTest()
        {
            _servicio = Substitute.For<IPoliza>();
        }

        [Fact]
        public void EliminePoliza()
        {
            var id = 1;
            _servicio.EliminePoliza(id).Returns(true);
            var poliza = _servicio.EliminePoliza(id);

            Assert.True(poliza);
        }

        [Fact]
        public void EliminePoliza_Error()
        {
            var id = 0;
            _servicio.EliminePoliza(id).ThrowsForAnyArgs(new DbUpdateException());

            Assert.Throws<DbUpdateException>(() => _servicio.EliminePoliza(id));
        }

    }
}
