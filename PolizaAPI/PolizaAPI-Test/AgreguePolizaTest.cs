using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReceivedExtensions;
using Poliza.BW;
using Poliza.EF;
using Poliza.Repositorio;
using PolizaAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.API_Test
{
    public class AgreguePolizaTest
    {
        private readonly IRepositorioPoliza _repositorio;
        private readonly IReglasPoliza _reglas;
        
        private PolizasController _polizasController;

        public AgreguePolizaTest() 
        {
            _reglas = Substitute.For<IReglasPoliza>();
            _repositorio = Substitute.For<IRepositorioPoliza>();
            _polizasController = new PolizasController((RepositorioPoliza)_repositorio, _reglas);
        }

        [Fact]
        public void AgreguePoliza()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ReturnsForAnyArgs(true);
            _repositorio.Agregue(Arg.Any<Poliza.Model.Poliza>());

            _polizasController.Agregar(Escenarios.Obtenga1Poliza().Single());
        }

        [Fact]
        public void AgreguePoliza_Regla_RiesgoAlto()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ThrowsForAnyArgs(new Exception());          
                
            Assert.Throws<NotImplementedException>(() => _polizasController.Agregar(Escenarios.ObtengaRiesgoAlto_PorcentajeAlto()));
        }
    }
}
