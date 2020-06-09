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
    public class EditePolizaTest
    {
        private readonly RepositorioPoliza _repositorio;
        private readonly IReglasPoliza _reglas;

        private PolizasController _polizasController;

        public EditePolizaTest()
        {
            _reglas = Substitute.For<IReglasPoliza>();
            _repositorio = Substitute.For<RepositorioPoliza>();
            _polizasController = new PolizasController(_repositorio, _reglas);
        }

        [Fact]
        public void EditePoliza()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ReturnsForAnyArgs(true);
            _repositorio.Edite(Arg.Any<Poliza.Model.Poliza>());

            _polizasController.Editar(Escenarios.Obtenga1Poliza().Single());
        }

        [Fact]
        public void EditePoliza_Regla_RiesgoAlto()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ThrowsForAnyArgs(new Exception());

            Assert.Throws<NotImplementedException>(() => _polizasController.Editar(Escenarios.ObtengaRiesgoAlto_PorcentajeAlto()));
        }

    }
}
