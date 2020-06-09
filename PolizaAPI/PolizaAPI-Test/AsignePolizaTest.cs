using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json.Serialization;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
using Poliza.SI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.API_Test
{
    public class AsignePolizaTest
    {
        private readonly IPoliza _servicio;

        public AsignePolizaTest()
        {
            _servicio = Substitute.For<IPoliza>();
        }

        [Fact]
        public void AsignePoliza()
        {
            _servicio.AsignePoliza(new Poliza.Model.Poliza()).Returns(true);
            var poliza = _servicio.AsignePoliza(new Poliza.Model.Poliza());

            Assert.True(poliza);
        }

        [Fact]
        public void AsignePoliza_Error()
        {
            _servicio.AsignePoliza(new Poliza.Model.Poliza()).ThrowsForAnyArgs(new DbUpdateException());

            Assert.Throws<DbUpdateException>(() => _servicio.AsignePoliza(new Poliza.Model.Poliza()));
        }

    }
}
