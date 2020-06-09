using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReceivedExtensions;
using Poliza.DA;
using Poliza.SI.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.API_Test
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
            _servicio.ReceivedWithAnyArgs().EditePoliza(Arg.Any<Poliza.Model.Poliza>());
            _servicio.EditePoliza(new Model.Poliza());
        }

        [Fact]
        public void EditePoliza_Error_SinCliente()
        {
            _servicio.EditePoliza(new Model.Poliza()).ThrowsForAnyArgs(new DbUpdateConcurrencyException());
            
            Assert.Throws<DbUpdateConcurrencyException>(() => _servicio.EditePoliza(new Model.Poliza()));
        }

        //ToDo0000000000000000000
        [Fact]
        public void EditePoliza_Regla_RiesgoAlto()
        {
            //_servicio.AgreguePoliza(new Poliza()).ThrowsForAnyArgs(new PolizaException());

            //Assert.Throws<DbUpdateException>(() => _servicio.AgreguePoliza(new Poliza()));

            Assert.Equal("El porcentaje de cubrimiento no puede ser superior al 50%", "");
        }

    }
}
