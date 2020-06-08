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
    public class EditePolizaTest
    {
        private readonly IPoliza _servicio;

        public EditePolizaTest() 
        {
            _servicio = Substitute.For<IPoliza>();
        }

        //ToDo Received
        [Fact]
        public void EditePoliza()
        {
            _servicio.ReceivedWithAnyArgs().EditePoliza(Arg.Any<Poliza>());
            _servicio.EditePoliza(new Poliza());
        }

        [Fact]
        public void EditePoliza_Error_SinCliente()
        {
            _servicio.EditePoliza(new Poliza()).ThrowsForAnyArgs(new DbUpdateConcurrencyException());
            
            Assert.Throws<DbUpdateConcurrencyException>(() => _servicio.EditePoliza(new Poliza()));
        }

    }
}
