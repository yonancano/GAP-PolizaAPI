using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReceivedExtensions;
using PolizaDA.Modelos;
using PolizaSI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PolizaAPI_Test
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
            _servicio.ReceivedWithAnyArgs().AgreguePoliza(Arg.Any<Poliza>());
            _servicio.AgreguePoliza(new Poliza());
        }

        [Fact]
        public void AgreguePoliza_Error_SinCliente()
        {
            _servicio.AgreguePoliza(new Poliza()).ThrowsForAnyArgs(new DbUpdateException());

            Assert.Throws<DbUpdateException>(() => _servicio.AgreguePoliza(new Poliza()));
        }

    }
}
