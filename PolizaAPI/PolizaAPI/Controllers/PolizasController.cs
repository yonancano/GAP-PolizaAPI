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

        // GET: api/Polizas
        //[Route("/ObtengaPolizas")]
        [HttpGet("/ObtengaPolizas")]
        public IEnumerable<PolizaDA.Modelos.Poliza> ObtengaPolizas()
        {
            return _servicio.ObtengaPolizas();
        }

        // GET: api/Polizas/5
        //[Route("/ObtengaPoliza/{id}")]
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

        // POST: api/Polizas
        [HttpPost("/AgreguePoliza/{id}")]
        public void AgreguePoliza(PolizaDA.Modelos.Poliza poliza)
        {
            try
            {
                _servicio.AgrueguePoliza(poliza);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        // PUT: api/Polizas/5
        [HttpPut("/EditePoliza/{id}")]
        public bool EditePoliza(PolizaDA.Modelos.Poliza poliza)
        {
            try
            {
                _servicio.EditePoliza(poliza);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;                
            }

            return true;
        }


        // DELETE: api/Polizas/5
        [HttpDelete("/EliminePoliza/{id}")]
        public bool EliminePoliza(int id)
        {
            try
            {
                _servicio.EliminePoliza(id);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return true;
        }

    }
}
