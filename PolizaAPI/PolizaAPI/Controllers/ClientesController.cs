using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poliza.DA;

namespace Poliza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IRepositorio _repositorio;

        public ClientesController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("/ObtengaCliente")]
        public Poliza.Model.Cliente ObtengaClientePorId(int id)
        {

            return null;
        }

    }
}
