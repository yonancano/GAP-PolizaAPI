using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolizaSI.Contratos;

namespace PolizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizasController : ControllerBase
    {
        private readonly IPoliza _servicio;

        public PolizasController(IPoliza servicio)
        {
            _servicio = servicio;
        }

        [HttpGet("/ObtengaPolizas")]
        public IEnumerable<PolizaDA.Modelos.Poliza> ObtengaPolizas()
        {
            return _servicio.ObtengaPolizas();
        }

        [HttpGet("/ObtengaPoliza/{id}")]
        public PolizaDA.Modelos.Poliza ObtengaPolizaPorId(int id)
        {
            var poliza = _servicio.ObtengaPolizaPorId(id);

            if (poliza == null)
            {
                return null;
            }

            return poliza;
        }

        [HttpPost("/AgreguePoliza")]
        public void AgreguePoliza([FromBody]PolizaDA.Modelos.Poliza poliza)
        {
            try
            {
                _servicio.AgreguePoliza(poliza);
            }
            catch (DbUpdateException)
            {
                throw new NotImplementedException("No se completo la acción Agregar.");
            }
        }

        [HttpPut("/EditePoliza")]
        public bool EditePoliza([FromBody] PolizaDA.Modelos.Poliza poliza)
        {
            try
            {
                _servicio.EditePoliza(poliza);
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
                _servicio.EliminePoliza(id);
            }
            catch (DbUpdateException)
            {
                throw new NotImplementedException("No se completo la acción Eliminar.");
            }

            return true;
        }

    }
}
