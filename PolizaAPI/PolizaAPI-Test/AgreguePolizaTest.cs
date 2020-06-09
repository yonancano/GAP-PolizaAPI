using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReceivedExtensions;
using Poliza.BW;
using Poliza.DA;
using PolizaAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.API_Test
{
    public class AgreguePolizaTest
    {
        private readonly IRepositorio _repositorio;
        private readonly IReglasPoliza _reglas;
        
        private PolizasController _polizasController;

        public AgreguePolizaTest() 
        {
            _repositorio = Substitute.For<IRepositorio>();
            _reglas = Substitute.For<IReglasPoliza>();

            _polizasController = new PolizasController(_repositorio, _reglas);
        }

        [Fact]
        public void AgreguePoliza()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ReturnsForAnyArgs(true);
            _repositorio.AgreguePoliza(Arg.Any<Poliza.Model.Poliza>());

            _polizasController.AgreguePoliza(Escenarios.Obtenga1Poliza().Single());
        }

        [Fact]
        public void AgreguePoliza_Regla_RiesgoAlto()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ThrowsForAnyArgs(new Exception());          
                
            Assert.Throws<NotImplementedException>(() => _polizasController.AgreguePoliza(Escenarios.ObtengaRiesgoAlto_PorcentajeAlto()));
        }
    }
}
