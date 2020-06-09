using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliza.Api.Controllers.Base;
using Poliza.EF;
using Poliza.Repositorio;
using Poliza.Repositorio.Base;

namespace Poliza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IRepositorioCliente _repositorio;

        public ClientesController(RepositorioCliente repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("/ObtengaCliente")]
        public Poliza.Model.Cliente ObtengaClientePorId(int id)
        {
            //se complico el llamado a EF para llenar MisPolizas del mismo objeto Cliente
            //parcial: se crea un metodo adicional en polizas para las del cliente
            return _repositorio.ObtengaPorId(id);
        }

    }
}
