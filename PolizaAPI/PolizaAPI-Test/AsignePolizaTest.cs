using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json.Serialization;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;
using Poliza.BW;
using Poliza.DA;
using PolizaAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Poliza.API_Test
{
    public class AsignePolizaTest
    {
        private readonly IRepositorio _repositorio;
        private readonly IReglasPoliza _reglas;

        private PolizasController _polizasController;

        public AsignePolizaTest()
        {
            _repositorio = Substitute.For<IRepositorio>();
            _reglas = Substitute.For<IReglasPoliza>();

            _polizasController = new PolizasController(_repositorio, _reglas);
        }

        [Fact]
        public void AsignePoliza()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ReturnsForAnyArgs(true);
            _repositorio.AgreguePoliza(Arg.Any<Poliza.Model.Poliza>());

            _polizasController.AsignePoliza(Escenarios.Obtenga1Poliza().Single());
        }

        [Fact]
        public void AsignePoliza_Regla_RiesgoAlto()
        {
            _reglas.Validar(Arg.Any<Poliza.Model.Poliza>()).ThrowsForAnyArgs(new Exception());

            Assert.Throws<NotImplementedException>(() => _polizasController.AgreguePoliza(Escenarios.ObtengaRiesgoAlto_PorcentajeAlto()));
        }
    }
}
