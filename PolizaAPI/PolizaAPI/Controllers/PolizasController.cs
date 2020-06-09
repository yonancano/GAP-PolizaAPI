using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Poliza.DA;
using Poliza.SI.Contratos;

namespace PolizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizasController : ControllerBase
    {
        //private readonly IPoliza _servicio;
        private readonly IRepositorio _repositorio;

        public PolizasController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("/ObtengaPolizas")]
        public IEnumerable<Poliza.Model.Poliza> ObtengaPolizas()
        {
            return _repositorio.ObtengaPolizas();
        }

        [HttpGet("/ObtengaPoliza/{id}")]
        public Poliza.Model.Poliza ObtengaPolizaPorId(int id)
        {
            var poliza = _repositorio.ObtengaPolizaPorId(id);

            if (poliza == null)
            {
                return null;
            }

            return poliza;
        }

        [HttpPost("/AgreguePoliza")]
        public void AgreguePoliza([FromBody]Poliza.Model.Poliza poliza)
        {
            try
            {
                _repositorio.AgreguePoliza(poliza);
            }
            catch (DbUpdateException)
            {
                throw new NotImplementedException("No se completo la acción Agregar.");
            }
        }

        [HttpPut("/EditePoliza")]
        public bool EditePoliza([FromBody] Poliza.Model.Poliza poliza)
        {
            try
            {
                _repositorio.EditePoliza(poliza);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new NotImplementedException("No se completo la acción Editar.");
            }

            return true;
        }

        [HttpDelete("/EliminePoliza/{id}")]
        public bool EliminePoliza(int id)
        {
            try
            {
                _repositorio.EliminePoliza(id);
            }
            catch (DbUpdateException)
            {
                throw new NotImplementedException("No se completo la acción Eliminar.");
            }

            return true;
        }

    }
}
