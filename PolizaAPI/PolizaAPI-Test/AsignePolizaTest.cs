using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json.Serialization;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
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
    public class AsignePolizaTest
    {
        private readonly RepositorioPoliza _repositorio;
        private readonly IReglasPoliza _reglas;

        private PolizasController _polizasController;

        public AsignePolizaTest()
        {
            _reglas = Substitute.For<IReglasPoliza>();
            _repositorio = Substitute.For<RepositorioPoliza>();
            _polizasController = new PolizasController(_repositorio, _reglas);
        }

        [Fact]
        public void AsignePoliza()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ReturnsForAnyArgs(true);
            _repositorio.Agregue(Arg.Any<Poliza.Model.Poliza>());

            _polizasController.Agregar(Escenarios.Obtenga1Poliza().Single());
        }

        [Fact]
        public void AsignePoliza_Regla_RiesgoAlto()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ThrowsForAnyArgs(new Exception());

            Assert.Throws<NotImplementedException>(() => _polizasController.Agregar(Escenarios.ObtengaRiesgoAlto_PorcentajeAlto()));
        }
    }
}
