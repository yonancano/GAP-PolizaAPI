using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReceivedExtensions;
using Poliza.SI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.API_Test
{
    public class AgreguePolizaTest
    {
        private readonly IPoliza _servicio;

        public AgreguePolizaTest() 
        {
            _servicio = Substitute.For<IPoliza>();
        }

        //ToDo Received
        [Fact]
        public void AgreguePoliza()
        {
            _servicio.ReceivedWithAnyArgs().AgreguePoliza(Arg.Any<Poliza.Model.Poliza>());
            _servicio.AgreguePoliza(new Poliza.Model.Poliza());
        }

        [Fact]
        public void AgreguePoliza_Error_SinCliente()
        {
            _servicio.AgreguePoliza(new Model.Poliza()).ThrowsForAnyArgs(new DbUpdateException());

            Assert.Throws<DbUpdateException>(() => _servicio.AgreguePoliza(new Model.Poliza()));
        }

        //ToDo0000000000000000000
        [Fact]
        public void AgreguePoliza_Regla_RiesgoAlto()
        {
            //_servicio.AgreguePoliza(new Poliza()).ThrowsForAnyArgs(new PolizaException());

            //Assert.Throws<DbUpdateException>(() => _servicio.AgreguePoliza(new Poliza()));
            Assert.Equal("El porcentaje de cubrimiento no puede ser superior al 50%", "");
        }

    }
}
